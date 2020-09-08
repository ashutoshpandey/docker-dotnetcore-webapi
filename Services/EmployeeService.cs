using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using docker_webapi.Models;

namespace docker_webapi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private AppDbContext dbContext;

        public EmployeeService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList<Employee>();
        }

        public bool AddEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();

            return true;
        }
    }
}