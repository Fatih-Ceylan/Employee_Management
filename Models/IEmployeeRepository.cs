﻿using System.Collections.Generic;
namespace EmployeeManagement
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
