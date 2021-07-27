using Employee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Interface
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAllPerson();

        Person getPersonById(int id);

        bool SaveChanges();

        void UpdatePerson(Person person);

        void DeletePerson(Person person);

        void CreatePerson(Person person);
    }
}
