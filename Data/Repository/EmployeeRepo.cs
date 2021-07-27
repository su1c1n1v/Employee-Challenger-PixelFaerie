using Employee.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly Context.Context _context;
        public EmployeeRepo(Context.Context context)
        {
            _context = context;
        }

        public void CreateEmployee(Models.Employee employee)
        {
            _context.Employee.Add(employee);
        }

        public void DeleteEmployee(Models.Employee employee)
        {
            _context.Employee.Remove(employee);
        }

        public IEnumerable<Models.Employee> GetAllEmployee()
        {
            return _context.Employee.ToList();
        }

        public Models.Employee getEmployeeById(int id)
        {
            return _context.Employee.FirstOrDefault(Temp => Temp.EmployeeId == id); ;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEmployee(Models.Employee employee)
        {
            
        }
    }
}
