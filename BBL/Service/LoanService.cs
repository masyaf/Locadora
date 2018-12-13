using BLL.Service.Interfaces;
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
   public  class LoanService : ILoanService
    {
       private ILoanRepository LoanRepository;

       public LoanService()
       {
           LoanRepository = new LoanRepository();
       }
        public void Save(Loan entity)
        {
            LoanRepository.Save(entity);
        }

        public void Delete(int code)
        {
            LoanRepository.Delete(code);
        }

        public void Update(Loan entity)
        {
            LoanRepository.Update(entity);
        }

        public Loan GetByCode(int code)
        {
           return  LoanRepository.GetByCode(code);
        }

        public List<Loan> findByName(string name)
        {
            return LoanRepository.findByName(name);
        }

        public IEnumerable<Loan> All()
        {
            return LoanRepository.GetAll();
        }

        public List<Loan> GetAllLoanWithMoviesAndLoans()
        {
            return LoanRepository.GetAllLoanWithMoviesAndLoans();
        }


        public IQueryable<Loan> GetAllLoanWithCustomer()
        {
            return LoanRepository.GetAllLoanWithCustomer();
        }
    }
}
