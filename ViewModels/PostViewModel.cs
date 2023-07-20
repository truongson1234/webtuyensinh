using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class PostViewModel
    {
        public PostModel Post { get; set; }
        public CategoryModel Category { get; set; }
        public IEnumerable<PostModel> Posts { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
