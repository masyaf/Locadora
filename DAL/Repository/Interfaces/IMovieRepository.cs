using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IMovieRepository : IUnitOfWork<Movie>
    {
       List<Movie> GetAllMoviesWithTypeMovies();
    }

}
