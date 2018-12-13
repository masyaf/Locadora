using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
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
    }
}
