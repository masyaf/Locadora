using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.ModelView
{
   public static  class MovieModelView
    {
     

        public static int MovieCode { get; set; }
        public static string Title { get; set; }
        public static int Stock { get; set; }
        public static int TypeMovieCode { get; set; }
        public static List<LoanMovie> LoanMovies { get; set; }
        public static  Ranking Ranking { get; set; }
        public static  Gender Gender { get; set; }
        public static  Recorder Recorder { get; set; }
        public static TypeMovie TypeMovie { get; set; }

    }
}
