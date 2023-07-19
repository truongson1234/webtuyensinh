using System.ComponentModel.DataAnnotations;

namespace webtuyensinh.Models
{
    public class FileUpload
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
