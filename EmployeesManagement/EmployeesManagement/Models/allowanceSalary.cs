using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Models
{
    public partial class allowanceSalary
    {
        public allowanceSalary()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public int? Allowance { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
