using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using DAL.Repository.Interfaces;
using System.Data.Entity;



namespace DAL.Repository
{
    public class CityRepository  : BaseContext<City>, ICityRepository
    {


        public List<City> AllCitiesAsNoTracking()
        {
            return null;
        }

        public City GetByCodeAsNoTracking(int code)
        {
            throw new NotImplementedException();
        }

        public override int Update(City city)
        {

            Entry(city).State = EntityState.Modified;
            return this.SaveChanges();
        }
    }
}
