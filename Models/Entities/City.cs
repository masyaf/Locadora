using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public  class City
    {
        public City()
        {
            this.Customers = new List<Customer>();
            this.Employees = new List<Employee>();
        }

        public int CityCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
