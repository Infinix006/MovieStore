using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DTOs
{
    public class LoginModel
    {

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
