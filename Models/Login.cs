using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fur_ever_homes.Models
{
    public class LogIn
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username does not exist")]
        [MaxLength(30, ErrorMessage = "Username does not exist")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
