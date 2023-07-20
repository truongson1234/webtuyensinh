using elFinder.NetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System.Collections.Generic;
using webtuyensinh.Models;
using webtuyensinh.ViewModels;
using X.PagedList;

namespace webtuyensinh.Controllers
{
    //[Authorize(Roles = "Admin")]
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
        public IActionResult PostCreate()
        {
            var categories = _context.CategoryModel.Select(c => c);
            var model = new PostViewModel
            {
                Categories = categories
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> PostCreate(IFormFile postedFile, PostModel post)
        {
            if (postedFile == null || postedFile.Length == 0)
                return BadRequest("No file selected for upload...");

            string fileName = Path.GetFileName(postedFile.FileName);
            var uploadDirectory = "Uploads";
            var filePath = Path.Combine(uploadDirectory, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await postedFile.CopyToAsync(stream);
            }

            post.Avartar = fileName;
            post.CreatedAt = DateTime.Now;
            _context.PostModel.Add(post);
            _context.SaveChanges();
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
                            CreatedAt = p1.CreatedAt,
                            UpdatedAt = p1.UpdatedAt,
                            CategoryId = p1.CategoryId,
                            Category = c2,
                        }
                        )
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

            var model = new PostViewModel
            {
                Post = post,
                Categories = cate
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> PostUpdate (IFormFile postedFile, PostModel post)
        {
            if (postedFile != null)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                var uploadDirectory = "Uploads";
                var filePath = Path.Combine(uploadDirectory, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await postedFile.CopyToAsync(stream);
                }

                post.Avartar = fileName;
            }

            post.UpdatedAt = DateTime.Now;
            _context.PostModel.Update(post);
            _context.SaveChanges();
            return RedirectToAction("PostsManager");
        }
        [HttpPost]
        public async Task<IActionResult> PostDelete(int post_id) 
        {
            var post = await _context.AdmissionModel.FirstOrDefaultAsync(p => p.Id == post_id);

            _context.AdmissionModel.Remove(post);
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
    }
}
