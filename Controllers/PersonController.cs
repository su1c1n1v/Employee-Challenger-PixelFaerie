using Employee.Data.Interface;
using Employee.Data.Models;
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
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepo _repository;

        public PersonController(IPersonRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<Person> GetPerson()
        {
            return Ok(_repository.GetAllPerson());
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            return Ok(_repository.getPersonById(id));
        }

        [HttpPost]
        public ActionResult<Person> CreatePerson(Person person)
        {
            _repository.CreatePerson(person);
            _repository.SaveChanges();
            return Ok(person);
        }

        [HttpPut("{id}")]
        public ActionResult<Person> UpdatePerson(int id, Person person)
        {
            var getPerson = _repository.getPersonById(id);
            if (getPerson == null)
            {
                return NotFound();
            }
            getPerson = person;
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Person> DeletePerson(int id)
        {
            var person = _repository.getPersonById(id);
            if (person == null)
            {
                return NotFound();
            }
            _repository.DeletePerson(person);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
