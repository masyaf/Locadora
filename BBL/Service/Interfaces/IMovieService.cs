﻿using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface IMovieService  : IBaseService<Movie>
    {
        List<Movie> GetAllMoviesWithTypeMovies();
        List<Movie>  GetAllMoviesWithTypeMoviesByName(string movieName);
        Movie GetMovieWithAllInfoByCode(int movieCode);

    }
}
