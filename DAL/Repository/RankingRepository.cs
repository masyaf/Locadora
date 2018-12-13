using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RankingRepository : BaseContext<Ranking>, IRankingRepository
    {
        public Ranking GetSingleByName(String name)
        {
            return Where(r => r.Name.Equals(name)).FirstOrDefault();
        }
    }
}
