using System.ComponentModel.DataAnnotations;

namespace fur_ever_homes.Models
{
    public class RegisterPet
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string Sex { get; set; }

        [Required]
        [MaxLength(30)]
        public string Birthdate { get; set; }

        [Required]
        [MaxLength(30)]
        public string Breed { get; set; }

        [Required]
        [MaxLength(100)]
        public string ImageURL { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
