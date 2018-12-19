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
        private IMovieRepository MovieRepository;

        public MovieService()
        {
            MovieRepository = new MovieRepository();
        }
        public void Save(Movie entity)
        {
            MovieRepository.Save(entity);
        }

        public void Delete(int code)
        {
            MovieRepository.Delete(code);
        }

        public void Update(Movie entity)
        {
            entity.Recorder = null;
            entity.Gender = null;
            entity.Ranking = null;
            entity.TypeMovie = null;
            MovieRepository.Update(entity);
        }

        public Movie GetByCode(int code)
        {
            return MovieRepository.GetByCode(code);
        }

        public List<Movie> findByName(string name)
        {
            return MovieRepository.Where(m => m.Title.ToLower().Equals(name.ToLower())).ToList();
        }

        public IEnumerable<Movie> All()
        {
            return MovieRepository.GetAll();
        }

        public List<Movie> GetAllMoviesWithTypeMovies()
        {
           return  MovieRepository.GetAllMoviesWithTypeMovies();
        }


        public List<Movie> GetAllMoviesWithTypeMoviesByName(string movieName)
        {
            return MovieRepository.GetAllMoviesWithTypeMoviesByName(movieName);
        }


        public Movie GetMovieWithAllInfoByCode(int movieCode)
        {
           return MovieRepository.GetMovieWithAllInfoByCode(movieCode);
        }
    }
}
