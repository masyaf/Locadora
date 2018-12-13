using DAL;
using Infraestructure.Repository;
using Models.Entities;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CityService
    {

        IUnitOfWork<Ranking> UnitOfWorkUser { get; set; }

                public CityService()
        {
            this.UnitOfWorkUser = new RankingRepository();
        }
 
        public void Save(City city)
        {
            repository.Save(city);
        }



        public void Delete(City city)
        {
            repository.Delete(city);

        }

        public void Update(City city)
        {
            repository.Update(city);
        }

        public List<City> FindByName(string name)
        {
            return repository.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
