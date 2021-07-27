using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Interface
{
    public interface IEmployeeRepo
    {
        IEnumerable<Models.Employee> GetAllEmployee();

        Models.Employee getEmployeeById(int id);

        bool SaveChanges();

        void UpdateEmployee(Models.Employee employee);

        void DeleteEmployee(Models.Employee employee);

        void CreateEmployee(Models.Employee employee);
    }
}
