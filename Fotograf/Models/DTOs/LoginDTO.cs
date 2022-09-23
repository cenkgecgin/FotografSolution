using System.ComponentModel.DataAnnotations;

namespace Fotograf.Models.DTOs
{
    public class LoginDTO
    {
        [Required]
        [MinLength(4, ErrorMessage = "Email Alani en az 5 karakter olmaildir")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}
