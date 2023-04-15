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
        public Salary(int Level, int AllowanceSalaryId)
        {
           this.Level = Level;
            this.AllowanceSalaryId = AllowanceSalaryId;
        }
        public Salary(int id,int Level, int AllowanceSalaryId)
        {
            this.Id = id;
            this.Level = Level;
            this.AllowanceSalaryId = AllowanceSalaryId;
        }

        public int Id { get; set; }
        public int? Coefficient { get; set; }
        public int? Level { get; set; }
        public int? AllowanceSalaryId { get; set; }
        public int? NetSalary { get; set; }

        public virtual levelSalary LevelSalary { get; set; }
        public virtual allowanceSalary AllowanceSalary { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
