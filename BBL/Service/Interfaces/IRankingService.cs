using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface IRankingService : IBaseService<Ranking>
    {
       Ranking GetSingleByName(string name);
    }
}
