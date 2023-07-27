using webtuyensinh.Models;

namespace webtuyensinh.Services
{
    public class HomeService
    {
        private readonly WebtuyensinhDbContext _context;

        public HomeService(WebtuyensinhDbContext context)
        {
            _context = context;
        }
        public IEnumerable<PostModel> GetPostsMain()
        {
            return _context.PostModel
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
                .OrderBy(x => x.CreatedAt)
                .Take(2);
        }
        public IEnumerable<PostModel> GetPostsTab(int cateTabId)
        {
            return _context.PostModel
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
                .Where(at1 => at1.CategoryId == cateTabId)
                .OrderBy(x => x.CreatedAt)
                .Take(3);
        }
        public IEnumerable<CategoryModel> GetCategories()
        {
            return _context.CategoryModel
                .Join(_context.PostModel,
                c => c.Id,
                p => p.CategoryId,
                (c, p) => new CategoryModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Posts = c.Posts.Where(pc => pc.CategoryId == c.Id),
                })
                .Take(6);
        }
        public CategoryModel GetCategoryById(int categoryId)
        {
            return _context.CategoryModel
                    .Where(c => c.Id == categoryId)
                    .Join(_context.PostModel,
                    c => c.Id,
                    p => p.CategoryId,
                    (c, p) => new CategoryModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description,
                        Posts = c.Posts.Where(pc => pc.CategoryId == c.Id),
                    }).First();
        }
    }
}
