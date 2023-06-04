using System.ComponentModel.DataAnnotations;

namespace fur_ever_homes.Models
{
    public class SignUp
    {
        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Contact Number")]
        [Phone(ErrorMessage = "Please enter a valid contact number")]
        public string ContactNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }
    }
}
