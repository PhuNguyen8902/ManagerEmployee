using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Models
{
    public partial class levelSalary
    {
        public levelSalary()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public int? Coefficient { get; set; }
        public string Level { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
