using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface ITypeMovieService : IBaseService<TypeMovie>
    {
        TypeMovie GetSingleByName(string name);
    }
}
