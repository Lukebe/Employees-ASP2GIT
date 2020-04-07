using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees_ASP2.Domain;
using Employees_ASP2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employees_ASP2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //public EmployeesController(IEmployeeRepository employeesRepository)
        //{
        //    this.employeeRepository = employeesRepository;
        //}
        //public IEmployeeRepository employeeRepository { get; set; }

        // GET <controller>/5
        [HttpGet()]
        public ICollection<Department> Get()
        {
            var departmentR = new DepartmentRepository();
            return departmentR.GetAllDepartments();
        }

        // // GET api/<controller>/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Department value)
        {
            var employeeR = new DepartmentRepository();
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