using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetByFirstName(string firstName)
        {
            return _employeeDal.GetAll(e => e.FirstName == firstName);
        }

        public Employee GetById(int Id)
        {
            return _employeeDal.Get(e => e.Id == Id);
        }

        public List<Employee> GetByLastName(string lastName)
        {
            return _employeeDal.GetAll(e => e.LastName == lastName);
        }

        public void Update(Employee employee)
        {
             _employeeDal.Update(employee);
        }
    }
}
