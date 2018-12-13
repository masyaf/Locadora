using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
  public  interface ILoanService : IBaseService<Loan>
    {
      List<Loan> GetAllLoanWithMoviesAndLoans();
      IQueryable<Loan> GetAllLoanWithCustomer();
    }
}
