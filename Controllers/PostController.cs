using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NuGet.Protocol;
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
        [HttpGet]
        [Route("/tags/{name}")]
        public IActionResult PostsForTag(string name)
        {
            var tags = _context.TagModel.Where(x => x.Name.Contains(name)).ToList();
            var posts = _context.PostModel.Where(t => t.PostTags.Any(pt => pt.Tag.Name.Contains(name))).ToList();

            var model = new PostViewModel
            {
                Tags = tags,
                Posts = posts
            };
            return View(model);
        }
        [HttpGet]
        [Route("/blogs/{url}")]
        public IActionResult PostsForCategory(string url)
        {
            var model = new CategoryViewModel();
            var cate = _context.CategoryModel.Where(p => p.Url.Contains(url));
            if(cate.Any())
            {
                var posts = _context.PostModel
                                .Join(_context.CategoryModel,
                                        p => p.CategoryId,
                                        c => c.Id,
                                        (p, c) => new PostModel
                                        {
                                            Id = p.Id,
                                            Title = p.Title,
                                            Avartar = p.Avartar,
                                            Content = p.Content,
                                            Description = p.Description,
                                            Url = p.Url,
                                            CreatedAt = p.CreatedAt,
                                            UpdatedAt = p.UpdatedAt,
                                            CategoryId = p.CategoryId,
                                            Category = c,
                                        }
                                        )
                                .Where(p => p.CategoryId == cate.First().Id)
                                .ToList();
                model.Category = cate.First();
                model.Posts = posts;
            }

            return View(model);
        }
        [HttpGet]
        [Route("/blogs/{url}.html")]
        public IActionResult Details(string url)
        {
            var post = _context.PostModel
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
                            Url = p1.Url,
                            CreatedAt = p1.CreatedAt,
                            UpdatedAt = p1.UpdatedAt,
                            CategoryId = p1.CategoryId,
                            Category = c2,
                        }
                        )
                .Where(p => p.Url.Contains(url))
                .FirstOrDefault();

            var tags = _context.PostTagModel.Where(pt => pt.PostID == post.Id).Select(pt => pt.Tag).ToList();
            var relatedPosts = _context.PostModel
                .Where(p => p.CategoryId == post.CategoryId || p.Title.Contains(post.Title) && p.Id != post.Id)
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Avartar = p.Avartar,
                    Content = p.Content,
                    Description = p.Description,
                    Url = p.Url,
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt,
                    CategoryId = p.CategoryId,
                })
                .Take(3)
                .ToList();
            var menu = _context.MenuItemModel
                .Where(mi => mi.GroupID == 2)
                .ToList();

            var model = new PostViewModel
            {
                Post = post,
                Posts = relatedPosts,
                Tags = tags,
                MenuCategories = menu
            };

            return View(model);
        }
    }
}
