using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
