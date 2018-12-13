using Models.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using BLL.Service.Interfaces;

namespace BLL.Service
{
    public class RankingService :  IRankingService
    {

        RankingRepository UnitOfWorkRanking { get; set; }

        public RankingService()
        {
            this.UnitOfWorkRanking = new RankingRepository();
        }
        
        public void Save(Ranking ranking)
        {
            UnitOfWorkRanking.Save(ranking);
        }

        public IEnumerable<Ranking> All()
        {
            return UnitOfWorkRanking.GetAll();
        }

        public List<Ranking> findByName(string name)
        {
            return UnitOfWorkRanking.Where(c => c.Name.ToLower().Equals(name.ToLower())).ToList();
        }


        public Ranking GetByCode(int code)
        {
            return UnitOfWorkRanking.GetByCode(code);
        }

        public void Delete(int code)
        {
            UnitOfWorkRanking.Delete(code);
        }

        public void Update(Ranking ranking)
        {
            UnitOfWorkRanking.Update(ranking);
        }




        public Ranking GetSingleByName(string name)
        {
            return UnitOfWorkRanking.GetSingleByName(name);
        }
    }


}

