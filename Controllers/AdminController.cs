using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
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
        public IActionResult AdmissionsManager(int? page, string searchA = "")
        {
            int pageSize = 3;
            int pageNumber = page ?? 1;

            var admissions = _context.AdmissionModel.Where(p => p.Name.Contains(searchA)).Select(p => p).ToList();

            var pagedData = admissions.ToPagedList(pageNumber, pageSize);
            return View(pagedData);
        }
        public IActionResult PostsManager()
        {
            var posts = _context.PostModel.Select(p => p);

            var model = new PostViewModel
            {
                Posts = posts
            };
            return View(model);
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
    }
}
