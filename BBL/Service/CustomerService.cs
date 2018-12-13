using BLL.Service.Interfaces;
using DAL;
using DAL.Repository;
using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository UnitOfWorkCustomer;
    
       public CustomerService(){
           UnitOfWorkCustomer = new CustomerRepository();
        }

       public void Save(Customer entity)
       {
           UnitOfWorkCustomer.Save(entity);
       }

       public void Delete(int code)
       {
           UnitOfWorkCustomer.Delete(code);
       }

       public void Update(Customer entity)
       {
           entity.City = null;
           UnitOfWorkCustomer.Update(entity);
       }

       public Customer GetByCode(int code)
       {
           return UnitOfWorkCustomer.GetByCode(code);
       }

       public List<Customer> findByName(string name)
       {
           return UnitOfWorkCustomer.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
       }

       public IEnumerable<Customer> All()
       {
           return UnitOfWorkCustomer.GetAll();
       }


       public IList<Customer> AllCustomersWithCity()
       {
           return UnitOfWorkCustomer.AllCustomersWithCity();
       }
    }
}
