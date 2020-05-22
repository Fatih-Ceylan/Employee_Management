using System.Collections.Generic;
using System.Linq;

namespace Telefon_Rehberi
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id =11, Name = "Mary", Email="asdaa", Department =  Dept.GM},
                 new Employee(){Id= 2, Name= "Ahmet", Department=Dept.HR,Email="asd@aasd.com"},
                new Employee(){Id= 3, Name= "Selma", Department=Dept.GM,Email="bb@bb.com"}
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
            return _employeeList;
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
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
