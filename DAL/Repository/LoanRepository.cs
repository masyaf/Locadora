using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public  class LoanRepository : BaseContext<Loan>, ILoanRepository
    {


        public List<Loan> findByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Loan> GetAllLoanWithMoviesAndLoans()
        {
            return DbSet.Include("LoanMovies").Include("LoanMovies.Movie.TypeMovie").ToList();
        }


        public List<Loan> GetAllLoanWithCustomer()
        {


            return DbSet.Include("Customer").ToList();
        }

        public override int Update(Loan newLoan)
        {

            Entry(newLoan).State = EntityState.Modified;
            foreach (var item in newLoan.LoanMovies)
            {
                if (item.DeliveryDate.Value != DateTime.MinValue)
                {
                    Entry(item).State = EntityState.Modified;
                }
                
            }
          

            return this.SaveChanges();
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }


        public Loan GetLoanWithMoviesByCode(int code)
        {
            return DbSet.Include("LoanMovies")
                                      .Include("LoanMovies.Movie.TypeMovie")
                                      .Include("Customer")
                                      .Include("Employee")
                                      .Where(l => l.LoanCode == code)
                                      .FirstOrDefault();
        }


        public List<Loan> GetAllLoanWithCustomerByReturned()
        {
            return DbSet.Include("Customer").Where(l => l.Completed == true).AsNoTracking().ToList();
        }


        public List<Loan> GetAllLoanWithCustomerByCustomerName(string customerName)
        {
           return  DbSet.Include("Customer").Where(l => l.Customer.Name.ToLower().Contains(customerName.ToLower())).AsNoTracking().ToList();
        }


        public List<Loan> GetAllLoanWithCustomerByCustomerName(string customerName, bool completed)
        {
            return DbSet.Include("Customer").Where(l => l.Completed == completed  
                                                                          &&   l.Customer.Name.ToLower().Contains(customerName.ToLower()))
                                                                                                                                         .AsNoTracking().ToList();
        }
    }
}
