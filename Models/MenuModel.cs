using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webtuyensinh.Models
{
    [Table("Menus")]
    public class MenuModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<MenuItemModel> Menus { get; set; }
    }
}
