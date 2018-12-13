using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface IGenderService : IBaseService<Gender>
    {
        Gender GetSingleByName(string name);
    }
}
