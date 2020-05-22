using System.Collections.Generic;
using Telefon_Rehberi.Controllers;

namespace Telefon_Rehberi
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeID(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int id);

    }
}
