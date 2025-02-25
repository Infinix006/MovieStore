using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MovieStore.Models.Domain;
using MovieStore.Models.DTOs;

namespace MovieStore.Repositories.Interfaces
{
    public interface IGenreService
    {
        bool Add(Genre model);

        bool Update (Genre model);

        Genre GetById(int id);

        bool Delete(int id);

        IQueryable<Genre> List();
    }
}
