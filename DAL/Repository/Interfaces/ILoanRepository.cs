using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface ILoanRepository : IUnitOfWork<Loan>
    {
        List<Loan> findByName(string name);

        List<Loan> GetAllLoanWithMoviesAndLoans();
        List<Loan> GetAllLoanWithCustomer();
        Loan GetLoanWithMoviesByCode(int code);
        List<Loan> GetAllLoanWithCustomerByReturned();
        List<Loan> GetAllLoanWithCustomerByCustomerName(string customerName);
        List<Loan> GetAllLoanWithCustomerByCustomerName(string customerName, bool completed);
    }
}
