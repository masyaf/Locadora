using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class TypeMovie
    {
        public TypeMovie()
        {
            this.Movie = new List<Movie>();
        }

        public int TypeMovieCode { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Day { get; set; }
        public decimal? Fine { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}
