using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;
using webtuyensinh.Models;
using webtuyensinh.Services;
using webtuyensinh.ViewModels;

namespace webtuyensinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _service;

        public HomeController(HomeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            //Lấy ra 2 bản ghi mới nhất
            var article_main = _service.GetPostsMain();

            //Lấy ra 3 bản mới nhất của các danh mục
            var article_tab1 = _service.GetPostsTab(1);
            var article_tab2 = _service.GetPostsTab(2);
            var article_tab3 = _service.GetPostsTab(3);

            //Lấy ra 6 bản ghi danh mục
            var cates = _service.GetCategories();

            var cate_germany = _service.GetCategoryById(2);
            var cate_korea = _service.GetCategoryById(2);
            var cate_japan = _service.GetCategoryById(2);
            var cate_australia = _service.GetCategoryById(2);
            var cate_canada = _service.GetCategoryById(2);

            var model = new HomeViewModel
            {
                ArticleMain = article_main,
                ArticleCateOne = article_tab1,
                ArticleCateTwo = article_tab2,
                ArticleCateThree = article_tab3,
                Categories = cates,
                CateNation = new List<CategoryModel>
                {
                    cate_germany,
                    cate_korea,
                    cate_japan,
                    cate_australia,
                    cate_canada
                }
            };

            return View(model);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}