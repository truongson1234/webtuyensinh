using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webtuyensinh.Models
{
    [Table("Users")]
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "User";
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
