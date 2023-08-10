using Microsoft.Ajax.Utilities;
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
        private readonly WebtuyensinhDbContext _context;
        private readonly HomeService _service;

        public HomeController(WebtuyensinhDbContext context, HomeService service)
        {
            _context = context;
            _service = service;
        }

        public IActionResult Index()
        {

            var qmenu = _context.MenuItemModel
                .Where(m => m.GroupID == 1)
                .Where(m => m.ParentID == null);
            //if (!User.Identity.IsAuthenticated)
            //    qmenu.Where(m => m.DisplayCondition == Conditions.NotAuthentication || m.DisplayCondition == Conditions.Normal);
            //if (User.Identity.IsAuthenticated)
            //    qmenu.Where(m => m.DisplayCondition == Conditions.Authentication || m.DisplayCondition == Conditions.Normal);
            //if (User.IsInRole("Admin"))
            //    qmenu.Where(m => m.DisplayCondition == Conditions.RoleAdmin || m.DisplayCondition == Conditions.NotAuthentication || m.DisplayCondition == Conditions.Normal);

            var menu = qmenu.Select(m => new MenuItemModel
                {
                    Id = m.Id,
                    GroupID = m.GroupID,
                    ParentID = m.ParentID,
                    Name = m.Name,                 
                    URL = m.URL,
                    Controller = m.Controller,
                    Action = m.Action,
                    DisplayCondition = m.DisplayCondition,
                    DisplayOrder = m.DisplayOrder,
                    Target = m.Target,
                    Status = m.Status,
                    Child = _context.MenuItemModel
                        .Where(m2 => m2.ParentID == m.Id)
                        .OrderBy(m2 => m2.DisplayOrder)
                        .ToList()
                })
                .OrderBy(m => m.DisplayOrder)
                .ToList();

            //Lấy ra 2 bản ghi mới nhất
            var article_main = _service.GetPostsMain();

            //Lấy ra 3 bản mới nhất của các danh mục
            var article_tab1 = _service.GetPostsTab(2);
            var article_tab2 = _service.GetPostsTab(1);
            var article_tab3 = _service.GetPostsTab(3);

            //Lấy ra 6 bản ghi danh mục
            var cates = _service.GetCategories();

            var cate_germany = _service.GetCategoryById(1);
            var cate_korea = _service.GetCategoryById(2);
            var cate_japan = _service.GetCategoryById(3);
            var cate_australia = _service.GetCategoryById(4);
            var cate_canada = _service.GetCategoryById(5);

            var model = new HomeViewModel
            {
                Menu = menu,
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