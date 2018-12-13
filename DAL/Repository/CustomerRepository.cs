using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public  class CustomerRepository : BaseContext<Customer>, ICustomerRepository
    {
        public IList<Customer> AllCustomersWithCity()
        {
            return DbSet.Include("City").ToList();
        }
    }
}
