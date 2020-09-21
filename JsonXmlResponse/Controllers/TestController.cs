using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JsonXmlResponse.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<Employee> Get()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee { Id = 1, Name = "Lokendra", Department = "IT" },
                new Employee { Id = 2, Name = "Ram", Department = "Sales" }
            };
            return emp.ToList();
        }

        [HttpGet("getemp/{id}.{format?}"), FormatFilter]
        public IEnumerable<Employee> GetEmployee(int id)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee { Id = 1, Name = "Lokendra", Department = "IT" },
                new Employee { Id = 2, Name = "Ram", Department = "Sales" }
            };
            return emp.Where(e => e.Id == id).ToList();
        }
    }
}
