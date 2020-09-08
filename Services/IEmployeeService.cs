using System.Collections.Generic;

namespace docker_webapi.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        bool AddEmployee(Employee employee);
    }
}