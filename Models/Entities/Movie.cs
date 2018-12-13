using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Movie
    {
        public Movie()
        {
            this.LoanMovies = new List<LoanMovie>();
        }

        public int MovieCode { get; set; }
        public string Title { get; set; }
        public int GenderCode { get; set; }
        public int RankingCode { get; set; }
        public int RecorderCode { get; set; }
        public int Stock { get; set; }
        public int YearProduction { get; set; }
        public int Duration { get; set; }
        public int TypeMovieCode { get; set; }
        public virtual ICollection<LoanMovie> LoanMovies { get; set; }
        public virtual Ranking Ranking { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Recorder Recorder { get; set; }
        public virtual TypeMovie TypeMovie { get; set; }
    }
}
