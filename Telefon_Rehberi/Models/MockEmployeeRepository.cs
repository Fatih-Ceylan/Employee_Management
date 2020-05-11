using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Telefon_Rehberi.Controllers
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id =11, Name = "Mary", Email="asdaa"}
            };
        }
        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }
        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(a => a.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
        public Employee GetEmployeeID(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(b => b.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
            }
            return employee;
        }
    }
}
