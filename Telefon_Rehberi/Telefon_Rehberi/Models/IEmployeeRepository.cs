using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telefon_Rehberi.Controllers
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
