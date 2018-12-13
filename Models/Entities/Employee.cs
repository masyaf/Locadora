using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class Employee
    {
        public Employee()
        {
            this.Loans = new List<Loan>();
        }

        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public string DocumentRg { get; set; }
        public string DocumentCpf { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Neighborhood   { get; set; }
        public int CityCode { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual City City { get; set; }
    }
}
