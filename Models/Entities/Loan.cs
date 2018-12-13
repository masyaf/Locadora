using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Loan
    {
        public Loan()
        {
            this.LoanMovies = new List<LoanMovie>();
        }

        public int LoanCode { get; set; }
        public DateTime DateLoan { get; set; }
        public int CustomerCode { get; set; }
        public int EmployeeCode { get; set; }
        public decimal Amount { get; set; }
        public bool Completed { get; set; }
        public decimal AmountMuclt { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual IList<LoanMovie> LoanMovies { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
