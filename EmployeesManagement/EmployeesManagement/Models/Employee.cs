using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Accounts = new HashSet<Account>();
            Timekeepings = new HashSet<Timekeeping>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public byte Gender { get; set; }
        public string? HomeTown { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalaryId { get; set; }
        public int? PositionId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Position? Position { get; set; }
        public virtual Salary? Salary { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Timekeeping> Timekeepings { get; set; }
    }
}
