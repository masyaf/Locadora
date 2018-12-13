using DAL;
using Models.Entities;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CityService : IBaseService<City>
    {

        IUnitOfWork<City> UnitOfWorkCity { get; set; }

        public CityService()
        {
           UnitOfWorkCity = new CityRepository();
        }

        public void Save(City city)
        {
            UnitOfWorkCity.Save(city);
        }



        public void Delete(int code)
        {
            UnitOfWorkCity.Delete(code);

        }

        public void Update(City city)
        {
            UnitOfWorkCity.Update(city);
        }

   
        public City GetByCode(int code)
        {
            return UnitOfWorkCity.GetByCode(code);
        }

        public List<City> findByName(string name)
        {
           return UnitOfWorkCity.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public IEnumerable<City> All()
        {
            return UnitOfWorkCity.GetAll();
        }
    }
}
