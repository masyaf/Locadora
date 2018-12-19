using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MovieRepository : BaseContext<Movie>, IMovieRepository
    {

        public List<Movie> GetAllMoviesWithTypeMovies()
        {
            return DbSet.Include("TypeMovie").ToList();
        }


        public List<Movie> GetAllMoviesWithTypeMoviesByName(string name)
        {
            return DbSet.Include("TypeMovie").Where(m => m.Title.ToLower().Contains(name.ToLower())).ToList();
        }


        public Movie GetMovieWithAllInfoByCode(int movieCode)
        {
            return DbSet.Include("TypeMovie")
                        .Include("Ranking")
                        .Include("Gender").
                         Include("Recorder").
                         Where(m => m.MovieCode == movieCode).
                         FirstOrDefault();
        }

        public override int Update(Movie movie)
        {

        
                Entry(movie).State = EntityState.Modified;
         
            return this.SaveChanges();
        }
    }
}
