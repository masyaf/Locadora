using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Recorder
    {
        public Recorder()
        {
            this.Movies = new List<Movie>();
        }

        public int RecorderCode { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
