using System.ComponentModel.DataAnnotations;

namespace fur_ever_homes.Models
{
    public class Login
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
