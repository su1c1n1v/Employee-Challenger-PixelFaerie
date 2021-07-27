using Employee.Data.Interface;
using Employee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Repository
{
    public class PersonRepo : IPersonRepo
    {
        private readonly Context.Context _context;
        public PersonRepo(Context.Context context)
        {
            _context = context;
        }
        public void CreatePerson(Person person)
        {
            _context.Person.Add(person);
        }

        public void DeletePerson(Person person)
        {
            _context.Person.Remove(person);
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return _context.Person.ToList();
        }

        public Person getPersonById(int id)
        {
            return _context.Person.FirstOrDefault(Temp => Temp.PersonId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePerson(Person person)
        {
            
        }
    }
}
