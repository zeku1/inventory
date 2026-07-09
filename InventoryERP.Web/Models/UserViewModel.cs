using System.ComponentModel.DataAnnotations;

namespace InventoryERP.Web.Models
{
    public class UserViewModel
    {
        public string? Id { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}
