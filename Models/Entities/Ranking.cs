using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Ranking
    {
        public Ranking()
        {
            this.Movies = new List<Movie>();
        }

        
        public int RankingCode { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
