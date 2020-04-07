using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees_ASP;
using Employees_ASP2.Domain;
using Employees_ASP2.Repositories;
using Microsoft.AspNetCore.Mvc;
using NHibernate;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employees_ASP2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //public EmployeesController(IEmployeeRepository employeesRepository)
        //{
        //    this.employeeRepository = employeesRepository;
        //}
        //public IEmployeeRepository employeeRepository { get; set; }

        // GET <controller>/5
        [HttpGet("{id}")]
        public ICollection<Employee> Get(int id)
        {
            var employeeR = new EmployeeRepository();
            return employeeR.GetByDepartment(id);
        }

        // // GET api/<controller>/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST <controller>
        [HttpPost]
        public void Post([FromBody]Employee value)
        {
            var employeeR = new EmployeeRepository();
            employeeR.Add(value);

        }

        // // PUT api/<controller>/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/<controller>/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
