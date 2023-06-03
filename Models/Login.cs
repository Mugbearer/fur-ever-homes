using System.ComponentModel.DataAnnotations;

namespace fur_ever_homes.Models
{
    public class Login
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string username { get; set; }
    }
}
