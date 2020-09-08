using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using docker_webapi.Models;
using docker_webapi.Services;

namespace docker_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return this.employeeService.GetEmployees();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            this.employeeService.AddEmployee(employee);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
