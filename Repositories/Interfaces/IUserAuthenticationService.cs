using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MovieStore.Models.DTOs;

namespace MovieStore.Repositories.Interfaces
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel login);

        Task LogoutAsync();

        Task<Status> RegisterAsync(RegistrationModel login);
    }
}
