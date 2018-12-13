using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class LoanMovie
    {
        public int LoanMovieCode { get; set; }
        public int LoanCode { get; set; }
        public int MovieCode { get; set; }
        public DateTime DateReturn { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal FineValue { get; set; }
        public decimal Value { get; set; }
        public bool?  Returned { get; set; }
        public virtual Loan Loan { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
