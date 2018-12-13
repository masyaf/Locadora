using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface IBaseService<T>  where T : class
    {
         void Save(T entity);

         void Delete(int code);
         void Update(T entity);

         T GetByCode(int code);
         List<T> findByName(string name);

           IEnumerable<T> All();
    }
}
