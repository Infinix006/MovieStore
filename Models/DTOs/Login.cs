using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DTOs
{
    public class Login
    {

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
