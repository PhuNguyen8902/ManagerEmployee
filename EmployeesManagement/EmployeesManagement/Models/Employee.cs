using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeesManagement.Models
{
    public partial class Employee
    {

        public Employee()
        {
            Accounts = new HashSet<Account>();
            Timekeepings = new HashSet<Timekeeping>();
            Notifys = new HashSet<Notify>();
        }
        public Employee(string Name, string Phone, byte Gender, string Hometown, int DepartmentId, int SalaryId, int PositionId)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Gender = Gender;
            this.HomeTown = Hometown;
            this.DepartmentId = DepartmentId;
            this.SalaryId = SalaryId;
            this.PositionId = PositionId;
        }
        public Employee(int id, string Name, string Phone, byte Gender, string Hometown, int DepartmentId, int SalaryId, int PositionId)
        {
            this.Id = id;
            this.Name = Name;
            this.Phone = Phone;
            this.Gender = Gender;
            this.HomeTown = Hometown;
            this.DepartmentId = DepartmentId;
            this.SalaryId = SalaryId;
            this.PositionId = PositionId;
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
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
        public virtual ICollection<Notify> Notifys { get; set; }


    }
}
