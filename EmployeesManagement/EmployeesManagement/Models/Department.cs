using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public Department(string Name, string Phone,string Address)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
        }
        public Department(int Id, string Name, string Phone, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
