using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class PostCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "CategoryId là bắt buộc.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tiêu đề là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được vượt quá 100 ký tự.")]
        public string Title { get; set; }

        [Url(ErrorMessage = "Định dạng URL hình đại diện không hợp lệ.")]
        public string Avartar { get; set; }

        public string? Tags { get; set; }

        [Required(ErrorMessage = "Mô tả là bắt buộc.")]
        [StringLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nội dung là bắt buộc.")]
        public string Content { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public IEnumerable<TagModel> TagsOfPost { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
