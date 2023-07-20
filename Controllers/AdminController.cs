using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public IActionResult AdmissionsEdit(int id)
        {
            var admission = _context.AdmissionModel.FirstOrDefault(a => a.Id == id);

            var model = new AdmissionViewModel
            {
                Admission = admission
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AdmissionsUpdate(AdmissionModel admission)
        {
            admission.UpdatedAt = DateTime.Now;
            _context.AdmissionModel.Update(admission);
            _context.SaveChanges();
            return RedirectToAction("AdmissionsManager");
        }
        [HttpPost]
        public async Task<IActionResult> AdmissionsDelete(int admission_id)
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
        public IActionResult PostsEdit(int id) 
        {
            var cate = _context.CategoryModel.ToList();
            var post = _context.PostModel
                    .Join(_context.CategoryModel,
                        p1 => p1.CategoryId,
                        c2 => c2.Id,
                        (p1, c2) => new PostModel { 
                            Id = p1.Id,
                            Title = p1.Title,
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
        public IActionResult PostUpdate (PostModel post)
        {
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
    }
}
