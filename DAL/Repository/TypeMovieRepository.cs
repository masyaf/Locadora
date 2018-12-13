using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public  class TypeMovieRepository : BaseContext<TypeMovie> , ITypeMovieRepository
    {
        public TypeMovie GetSingleByName(string name)
        {
            return Where(t => t.Name.Equals(name)).FirstOrDefault();
        }
    }
}
