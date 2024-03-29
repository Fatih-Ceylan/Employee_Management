﻿using EmployeeManagement.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLEmployeeRepository> _logger;

        public SQLEmployeeRepository(AppDbContext context , ILogger<SQLEmployeeRepository> logger)
        {
            this.context = context;
            _logger = logger;
        }
        public Employee Add(Employee employee)
        {

            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            //CheckConnection();
            return context.Employees;
        }

        public Employee GetEmployeeID(int id)
        {
            _logger.LogTrace("Trace Log");
            _logger.LogDebug("Debug Log");
            _logger.LogInformation("Information Log");
            _logger.LogWarning("Warning Log");
            _logger.LogError("Error Log");
            _logger.LogCritical("Critical Log");

            return context.Employees.Find(id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }

        /// <summary>
        /// Determines sql connection state.
        /// </summary>
        /// <returns></returns>
        public bool CheckConnection()
        {
            try
            {
                context.Database.CanConnect();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
    }
}
