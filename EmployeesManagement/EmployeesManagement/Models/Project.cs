using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public Project(string Name, string Description, string StartDate, string EndDate)
        {
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        public Project(int Id, string Name, string Description, string StartDate, string EndDate, bool IsActive)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsActive = IsActive;
        }
    }
}
