using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryModel Category { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
