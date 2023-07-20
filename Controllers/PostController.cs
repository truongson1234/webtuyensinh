using Microsoft.AspNetCore.Mvc;

namespace webtuyensinh.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
