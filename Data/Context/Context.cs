using Employee.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Context
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Models.Employee> Employee { get; set; }
    }
}
