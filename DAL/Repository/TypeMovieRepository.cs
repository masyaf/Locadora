using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        public override void Delete(int code)
        {
            var TypeMovie = GetByCode(code);
            try
            {
                Entry(TypeMovie).State = EntityState.Deleted;
                base.Delete(code);
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
                throw new DbUpdateException("Não é possível excluir esta entidade, pois a mesma está vinculada à outros dados");
                
            }

        }
    }
}
