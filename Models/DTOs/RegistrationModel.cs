using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DTOs
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email{ get; set; }

        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&*()_+={}\[\]|\\:;""'<>,.?/-]).+$")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }

        public string Role { get; set; }
    }
}
