using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        [Required]
        public int PersonId { get; set; }


        [Required]
        public string EmployeeNum { get; set; }

        [Required]
        public DateTime EmployeeDate { get; set; }
        public DateTime Terminated { get; set; }
    }
}
