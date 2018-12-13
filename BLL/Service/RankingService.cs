
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RankingService
    {
        private RankingRepository repository;

        public RankingService(){
            repository = new RankingRepository();
        }
        public void Save(Ranking ranking)
        {
            repository.Save(ranking);
        }

        public IEnumerable<Ranking> All()
        {
            return repository.GetAll();
        }



        public List<Ranking> findByName(string name)
        {
            return repository.Where(c => c.Name.ToLower().Equals(name.ToLower())).ToList();
        }

        public void Delete(Ranking ranking)
        {
            repository.Delete(ranking);
        }

        public void Update(Ranking ranking)
        {
            repository.Update(ranking);
        }



    }


}
