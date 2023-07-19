using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webtuyensinh.Models;
using webtuyensinh.ViewModels;

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
        public IActionResult AdmissionsManager()
        {
            var admissions = _context.AdmissionModel.Select(p => p);

            var model = new AdmissionViewModel
            {
                Admissions = admissions
            };
            return View(model);
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

    }
}
