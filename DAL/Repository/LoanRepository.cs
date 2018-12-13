using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
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


        public IEnumerable<Loan> GetAllLoanWithCustomer()
        {

            var Return =  DbSet.Select(l => new {l.LoanCode, l.DateLoan });
            return null;
        }
    }
}
