using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webtuyensinh.Models;
using webtuyensinh.ViewModels;

namespace webtuyensinh.Controllers
{
    public class PostController : Controller
    {
        private readonly WebtuyensinhDbContext _context;

        public PostController(WebtuyensinhDbContext context)
        {
            _context = context;
        }

        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            var categories = _context.CategoryModel.Select(c => c);
            var model = new PostViewModel
            {
                Categories = categories
            };
            return View(model);
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostModel post)
        {
            try
            {
                post.CreatedAt = DateTime.Now;
                _context.PostModel.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                //admission.CreatedAt = DateTime.Now;
                //_context.AdmissionModel.Add(admission);
                //_context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
