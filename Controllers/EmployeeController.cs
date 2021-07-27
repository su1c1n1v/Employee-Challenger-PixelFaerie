using Employee.Data.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _repository;

        public EmployeeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<Data.Models.Employee> GetEmployee()
        {
            return Ok(_repository.GetAllEmployee());
        }
        
        [HttpGet("{id}")]
        public ActionResult<Data.Models.Employee> GetEmployeeById(int id)
        {
            return Ok(_repository.getEmployeeById(id));
        }

        [HttpPost]
        public ActionResult<Data.Models.Employee> CreateEmployee(Data.Models.Employee employee)
        {
            _repository.CreateEmployee(employee);
            _repository.SaveChanges();
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Data.Models.Employee> UpdateEmployee(int id, Data.Models.Employee employee)
        {
            var getEmployee = _repository.getEmployeeById(id);
            if (getEmployee == null)
            {
                return NotFound();
            }
            getEmployee = employee;
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Data.Models.Employee> DeleteEmployee(int id)
        {
            var employee = _repository.getEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            _repository.DeleteEmployee(employee);
            return NoContent();
        }
    }
}
