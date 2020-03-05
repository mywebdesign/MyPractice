using System.ComponentModel.DataAnnotations;

namespace FitHolic.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}