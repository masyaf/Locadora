using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;



namespace DAL.Repository
{
    public class CityRepository  : BaseContext<City>, IUnitOfWork<City>
    {

       
    }
}
