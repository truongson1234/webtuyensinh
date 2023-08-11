using Azure;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using webtuyensinh.Models;
using webtuyensinh.ViewModels;
using X.PagedList;

namespace webtuyensinh.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly WebtuyensinhDbContext _context;
        public AdminController(WebtuyensinhDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        ///ADMISSION
        public IActionResult AdmissionsManager(int? page, string searchA = "")
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;

            var admissions = _context.AdmissionModel.Where(p => p.Name.Contains(searchA)).Select(p => p).ToList();

            var pagedData = admissions.ToPagedList(pageNumber, pageSize);
            return View(pagedData);
        }
        public IActionResult AdmissionEdit(int id)
        {
            var admission = _context.AdmissionModel.FirstOrDefault(a => a.Id == id);

            var model = new AdmissionViewModel
            {
                Admission = admission
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AdmissionUpdate(AdmissionModel admission)
        {
            admission.UpdatedAt = DateTime.Now;
            _context.AdmissionModel.Update(admission);
            _context.SaveChanges();
            return RedirectToAction("AdmissionsManager");
        }
        [HttpPost]
        public async Task<IActionResult> AdmissionDelete(int admission_id)
        {
            var admission = await _context.AdmissionModel.FirstOrDefaultAsync(p => p.Id == admission_id);

            _context.AdmissionModel.Remove(admission);
            await _context.SaveChangesAsync();

            return RedirectToAction("AdmissionsManager");
        }

        public IActionResult ExportExcel()
        {
            var data = _context.AdmissionModel.Select(d => d);

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                worksheet.Cells.LoadFromCollection(data, true);

                var stream = new MemoryStream(package.GetAsByteArray());

                Response.Headers.Add("Content-Disposition", "attachment; filename=admissions.xlsx");
                Response.Headers.Add("Content-Type", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
        }


        ///POST
        public IActionResult PostsManager(int? page, string searchP = "")
        {
            int pageSize = 3;
            int pageNumber = page ?? 1;

            var posts = _context.PostModel
                .Join(_context.CategoryModel,
                        p1 => p1.CategoryId,
                        c2 => c2.Id,
                        (p1, c2) => new PostModel
                        {
                            Id = p1.Id,
                            Title = p1.Title,
                            Avartar = p1.Avartar,
                            Content = p1.Content,
                            Description = p1.Description,
                            CreatedAt = p1.CreatedAt,
                            UpdatedAt = p1.UpdatedAt,
                            CategoryId = p1.CategoryId,
                            Category = c2,
                        }
                        )
                .Where(p => p.Category.Name.Contains(searchP))
                .Where(p => p.Title.Contains(searchP))
                .Where(p => p.Content.Contains(searchP))
                .Where(p => p.Description.Contains(searchP))
                .ToList();

            var pagedData = posts.ToPagedList(pageNumber, pageSize);

            return View(pagedData);
        }
        [HttpGet]
        [Route("/api/tags")]
        public JsonResult TagsAutoComplete()
        {
            var tags = _context.TagModel.ToList();
            return Json(tags);
        }
        public IActionResult PostCreate()
        {
            var categories = _context.CategoryModel.Select(c => c);
            var model = new PostCreateViewModel
            {
                Categories = categories,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> PostCreate(IFormFile postedFile, PostCreateViewModel postCreate)
        {
            if (postedFile == null || postedFile.Length == 0)
            {
                return BadRequest("Không tìm thấy ảnh đại diện tải lên...");
            }

            string fileName = Path.GetFileName(postedFile.FileName);
            var filePath = Path.Combine("Uploads", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await postedFile.CopyToAsync(stream);
            }

            var post = new PostModel
            {
                Id = postCreate.Id,
                CategoryId = postCreate.CategoryId,
                Title = postCreate.Title,
                Avartar = fileName,
                Description = postCreate.Description,
                Url = Slugify(postCreate.Title),
                Content = postCreate.Content,
                CreatedAt = DateTime.Now,
            };

            _context.PostModel.Add(post);
            _context.SaveChanges();

            if(postCreate.Tags != null)
                PostTagsToDB(postCreate.Tags, post.Id);

            return RedirectToAction("PostsManager");
        }
        public IActionResult PostEdit(int id) 
        {
            var cate = _context.CategoryModel.ToList();
            var post = _context.PostModel
                    .Join(_context.CategoryModel,
                        p1 => p1.CategoryId,
                        c2 => c2.Id,
                        (p1, c2) => new PostModel { 
                            Id = p1.Id,
                            Title = p1.Title,
                            Avartar = p1.Avartar,
                            Content = p1.Content,
                            Description = p1.Description,
                            Url = p1.Url,
                            CreatedAt = p1.CreatedAt,
                            UpdatedAt = p1.UpdatedAt,
                            CategoryId = p1.CategoryId,
                            Category = c2,
                        }
                        )
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

            string tags = JsonConvert.SerializeObject(_context.PostTagModel
                .Where(t => t.PostID == id)
                .Select(pt => new { 
                    value = pt.Tag.Name, 
                    id = pt.Tag.Id })
                .ToList());

            var model = new PostCreateViewModel
            {
                Id = post.Id,
                CategoryId = post.CategoryId,
                Title = post.Title,
                Avartar = post.Avartar,
                Content = post.Content,
                Description = post.Description,
                Tags = tags,
                Categories = cate
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> PostUpdate (IFormFile postedFile, PostCreateViewModel postCreate)
        {
            var post = new PostModel
            {
                Id = postCreate.Id,
                CategoryId = postCreate.CategoryId,
                Title = postCreate.Title,
                Description = postCreate.Description,
                Url = Slugify(postCreate.Title),
                Content = postCreate.Content,
                UpdatedAt = DateTime.Now,
            };

            if (postedFile != null)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                var filePath = Path.Combine("Uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await postedFile.CopyToAsync(stream);
                }
                post.Avartar = fileName;
            } else {
                post.Avartar = postCreate.Avartar;
            }

            _context.PostModel.Update(post);
            _context.SaveChanges();

            if (postCreate.Tags != null)
                PostTagsToDB(postCreate.Tags, post.Id);
            return RedirectToAction("PostsManager");
        }
        [HttpPost]
        public async Task<IActionResult> PostDelete(int post_id) 
        {
            var post = await _context.PostModel.FirstOrDefaultAsync(p => p.Id == post_id);

            _context.PostModel.Remove(post);
            await _context.SaveChangesAsync();

            return RedirectToAction("PostsManager");
        }


        ///CATE
        public IActionResult CategoriesManager(int? page, string searchC = "")
        {
            int pageSize = 5;
            int pageNumber = page ?? 1;

            var cates = _context.CategoryModel.Where(p => p.Name.Contains(searchC)).ToList();

            var pagedData = cates.ToPagedList(pageNumber, pageSize);
            return View(pagedData);
        }
        public IActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryCreate(CategoryModel category)
        {
            category.Url = Slugify(category.Name);
            category.CreatedAt = DateTime.Now;
            _context.CategoryModel.Add(category);
            _context.SaveChanges();
            return RedirectToAction("CategoriesManager");
        }
        public IActionResult CategoryEdit(int id)
        {
            var cate = _context.CategoryModel.Where(c => c.Id == id).FirstOrDefault();
            var model = new CategoryViewModel
            {
                Category = cate
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CategoryUpdate(CategoryModel category)
        {
            category.Url = Slugify(category.Name);
            category.UpdatedAt = DateTime.Now;
            _context.CategoryModel.Update(category);
            _context.SaveChanges();
            return RedirectToAction("CategoriesManager");
        }
        [HttpPost]
        public async Task<IActionResult> CategoryDelete(int cate_id)
        {
            var cate = await _context.CategoryModel.FirstOrDefaultAsync(c => c.Id == cate_id);

            _context.CategoryModel.Remove(cate);
            await _context.SaveChangesAsync();

            return RedirectToAction("CategoriesManager");
        }


        // Menu 
        public IActionResult MenusManager()
        {

            var menugroups = _context.MenuModel.ToList();
            var menus = _context.MenuItemModel
                .Join(_context.MenuModel,
                m => m.GroupID,
                mg => mg.Id,
                (m, mg) => new MenuItemModel 
                {
                    Id = m.Id,
                    Name = m.Name,
                    URL = m.URL,
                    Controller = m.Controller,
                    Action = m.Action,
                    DisplayOrder = m.DisplayOrder,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    Group = mg,
                })
                .ToList();

            var model = new MenuViewModel
            {
                Menus = menus,
                MenuGroups = menugroups,
            };

            return View(model);
        }
        // Menus group
        public IActionResult MenuCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MenuCreate(MenuModel menuGroup)
        {
            menuGroup.CreatedAt = DateTime.Now;
            _context.MenuModel.Add(menuGroup);
            _context.SaveChanges();
            return RedirectToAction("MenusManager");
        }
        public IActionResult MenuEdit(int id)
        {
            var mg = _context.MenuModel.Where(mg => mg.Id == id).FirstOrDefault();
            var model = new MenuViewModel
            {
                MenuGroup = mg
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> MenuUpdate(MenuModel menuGroup)
        {
            menuGroup.UpdatedAt = DateTime.Now;
            _context.MenuModel.Update(menuGroup);
            _context.SaveChanges();
            return RedirectToAction("MenusManager");
        }
        [HttpPost]
        public async Task<IActionResult> MenuDelete(int mg_id)
        {
            var mg = await _context.MenuModel.FirstOrDefaultAsync(c => c.Id == mg_id);

            _context.MenuModel.Remove(mg);
            await _context.SaveChangesAsync();

            return RedirectToAction("MenusManager");
        }

        // Menus group
        public IActionResult MenuItemCreate()
        {
            var mgs = _context.MenuModel.ToList();
            var pms = _context.MenuItemModel.ToList();

            var model = new MenuViewModel
            {
                MenuGroups = mgs,
                ParentMenus = pms
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> MenuItemCreate(MenuItemModel menu)
        {
            if (menu.Controller == null && menu.Action != null)
                menu.Action = null;
            if (menu.URL == null && menu.Controller == null && menu.Action == null)
                menu.URL = "#";
            menu.CreatedAt = DateTime.Now;
            _context.MenuItemModel.Add(menu);
            _context.SaveChanges();
            return RedirectToAction("MenusManager");
        }
        public IActionResult MenuItemEdit(int id)
        {
            var menu = _context.MenuItemModel
                .Where(m => m.Id == id)
                .Join(_context.MenuModel,
                m => m.GroupID,
                mg => mg.Id,
                (m, mg) => new MenuItemModel
                {
                    Id = m.Id,
                    ParentID = m.ParentID,
                    GroupID = m.GroupID,
                    Name = m.Name,
                    URL = m.URL,
                    Controller = m.Controller,
                    Action = m.Action,
                    DisplayCondition = m.DisplayCondition,
                    DisplayOrder = m.DisplayOrder,
                    CreatedAt = m.CreatedAt,
                    UpdatedAt = m.UpdatedAt,
                    Group = mg,
                })
                .FirstOrDefault();

            var mgs = _context.MenuModel.ToList();
            var pms = _context.MenuItemModel.Where(m => m.Id != id).ToList();

            var model = new MenuViewModel
            {
                Menu = menu,
                MenuGroups = mgs,
                ParentMenus = pms
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> MenuItemUpdate(MenuItemModel menu)
        {
            if (menu.Controller == null && menu.Action != null)
                menu.Action = null;
            if (menu.URL == null && menu.Controller == null && menu.Action == null)
                menu.URL = "#";
            menu.UpdatedAt = DateTime.Now;
            _context.MenuItemModel.Update(menu);
            _context.SaveChanges();
            return RedirectToAction("MenusManager");
        }
        [HttpPost]
        public async Task<IActionResult> MenuItemDelete(int m_id)
        {
            var menu = await _context.MenuModel.FirstOrDefaultAsync(c => c.Id == m_id);

            _context.MenuModel.Remove(menu);
            await _context.SaveChangesAsync();

            return RedirectToAction("MenusManager");
        }

        public void PostTagsToDB(string tags, int post_id)
        {
            var tagStrings = tags.Split(',');

            _context.PostTagModel.RemoveRange(_context.PostTagModel.Where(pt => pt.PostID == post_id));

            foreach (var tagStr in tagStrings)
            {
                if (!int.TryParse(tagStr.Trim(), out int tagId))
                {
                    var tag = new TagModel { Name = tagStr.Trim() };
                    _context.TagModel.Add(tag);
                    _context.SaveChanges();

                    tagId = tag.Id;
                }
                var postTags = new PostTagModel { PostID = post_id, TagID = tagId };
                _context.PostTagModel.Add(postTags);
            }
            _context.SaveChanges();
        }


        public string Slugify(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("input");
            }

            var normalizedString = input.Normalize(NormalizationForm.FormKD);
            var stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);

                if (category == UnicodeCategory.LowercaseLetter || category == UnicodeCategory.UppercaseLetter || category == UnicodeCategory.DecimalDigitNumber)
                {
                    stringBuilder.Append(c);
                }
                else if (c == ' ' || c == '-')
                {
                    stringBuilder.Append("-");
                }
            }

            return stringBuilder.ToString().ToLower();
        }
    }

}
