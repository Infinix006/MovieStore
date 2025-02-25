using MovieStore.Models.Domain;
using MovieStore.Repositories.Interfaces;

namespace MovieStore.Repositories.Implementation
{
    public class GenreService : IGenreService
    {
        public readonly ApplicationDbContext Context;

        public GenreService(ApplicationDbContext Context)
        {
            this.Context = Context;
        }

        public bool Add(Genre model)
        {
            try
            {
                Context.Add(model);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if(data == null)
                    return false;
                Context.Remove(data);
                Context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Genre GetById(int id)
        {
            try
            {
                return Context.Genre.Find(id);
            }
            catch (Exception ex)
            {
                return new Genre();
            }
        }

        public IQueryable<Genre> List()
        {
            var data = Context.Genre.AsQueryable();
            return data;
        }

        public bool Update(Genre model)
        {
            try
            {
                Context.Update(model);
                Context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
