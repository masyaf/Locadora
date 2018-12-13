using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Gender
    {
        public Gender()
        {
            this.Movies = new List<Movie>();
        }

        public int GenderCode { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
