using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace webtuyensinh.Models
{
    [Table("MenuItems")]
    public class MenuItemModel
    {
        [Key]
        public int Id { get; set; }
        public int? GroupID { get; set; }
        public int? ParentID { get; set; }
        [Required]
        [MaxLength(250)]
        public string? Name { get; set; }
        [MaxLength(500)]
        public string? URL { get; set; }
        [MaxLength(250)]
        public string? Controller { get; set; }
        [MaxLength(250)]
        public string? Action { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public Conditions DisplayCondition { get; set; }
        [MaxLength(10)]
        public string? Target { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public MenuModel Group { get; set; }
        [NotMapped]
        public ICollection<MenuItemModel> Child { get; set; } = new List<MenuItemModel>();
    }
    
    public enum Conditions
    {
        [Display(Name = "Bình thường")]
        Normal = 0,
        [Display(Name = "Chưa đăng nhập")]
        NotAuthentication = 1,
        [Display(Name = "Đăng nhập")]
        Authentication = 2,
        [Display(Name = "Vai trò 'Quản trị viên'")]
        RoleAdmin = 3
    }

}
