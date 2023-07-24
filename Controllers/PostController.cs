﻿using Microsoft.AspNetCore.Authorization;
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
        public IActionResult Details(int id)
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
                Post = post
            };

            return View(model);
        }
    }
}
