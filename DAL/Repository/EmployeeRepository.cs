using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EmployeeRepository : BaseContext<Employee>, IEmployeeRepository
    {

        public List<Employee> AllEmployeesWithCity()
        {
            return DbSet.Include("City").ToList();
        }
    }
}
