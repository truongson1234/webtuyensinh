using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using webtuyensinh.Models;

namespace webtuyensinh.Controllers
{
    public class CustomerController : Controller
    {
        private readonly WebtuyensinhDbContext _context;

        public CustomerController(WebtuyensinhDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AdmissionModel admissionModel)
        {
            admissionModel.CreatedAt = DateTime.Now;
            _context.AdmissionModel.Add(admissionModel);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
