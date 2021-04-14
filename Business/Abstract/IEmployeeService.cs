using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        List<Employee> GetByFirstName(string firstName);
        List<Employee> GetByLastName(string lastName);

        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
    }
}
