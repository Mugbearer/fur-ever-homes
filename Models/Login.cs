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
        [MinLength(8)]
        [MaxLength(30)]
        public string Password { get; set; }
    }
}
