using Microsoft.AspNetCore.Mvc;
using webtuyensinh.ViewModels;

namespace webtuyensinh.Controllers
{
    public class CategoryController : Controller
    {
        public readonly WebtuyensinhDbContext _context;
        public CategoryController(WebtuyensinhDbContext context) {
            _context = context;
        }
        public IActionResult Index()
        {

            //var model = new CategoryViewModel
            //{
            //    Categories = 
            //}
            return View();
        }
    }
}
