using BLL.Service.Interfaces;
using DAL;
using DAL.Repository;
using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MovieService : IMovieService
    {
        private IMovieRepository IUnitOfWorkMovie;

        public MovieService()
        {
            IUnitOfWorkMovie = new MovieRepository();
        }
        public void Save(Movie entity)
        {
            IUnitOfWorkMovie.Save(entity);
        }

        public void Delete(int code)
        {
            IUnitOfWorkMovie.Delete(code);
        }

        public void Update(Movie entity)
        {
            IUnitOfWorkMovie.Update(entity);
        }

        public Movie GetByCode(int code)
        {
            return IUnitOfWorkMovie.GetByCode(code);
        }

        public List<Movie> findByName(string name)
        {
            return IUnitOfWorkMovie.Where(m => m.Title.ToLower().Equals(name.ToLower())).ToList();
        }

        public IEnumerable<Movie> All()
        {
            return IUnitOfWorkMovie.GetAll();
        }

        public List<Movie> GetAllMoviesWithTypeMovies()
        {
           return  IUnitOfWorkMovie.GetAllMoviesWithTypeMovies();
        }
    }
}
