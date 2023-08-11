using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class CategoryViewModel
    {
        public string? Url { get; set; }
        public CategoryModel Category { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<PostModel> Posts { get; set; }
        public AdmissionModel AdmissionForm { get; set; }
    }
}
