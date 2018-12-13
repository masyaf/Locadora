using BLL.Service.Interfaces;
using DAL;
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
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository IUnitOfWorkEmployee;

        public EmployeeService()
        {
            IUnitOfWorkEmployee = new EmployeeRepository();
        }

        public void Save(Employee entity)
        {
            IUnitOfWorkEmployee.Save(entity);
        }

        public void Delete(int code)
        {
            IUnitOfWorkEmployee.Delete(code);
        }

        public void Update(Employee entity)
        {
            entity.City = null;
            IUnitOfWorkEmployee.Update(entity);
        }

        public Employee GetByCode(int code)
        {
            return IUnitOfWorkEmployee.GetByCode(code);
        }

        public List<Employee> findByName(string name)
        {
            return IUnitOfWorkEmployee.Where(e => e.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public IEnumerable<Employee> All()
        {
            return IUnitOfWorkEmployee.GetAll();
        }

        public IList<Employee> AllEmployeesWithCity()
        {
            return IUnitOfWorkEmployee.AllEmployeesWithCity();
        }
    }
}
