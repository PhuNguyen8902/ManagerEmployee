using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class Salary
    {
        public Salary()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string? Coefficient { get; set; }
        public string Level { get; set; } = null!;
        public string? Allowance { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
