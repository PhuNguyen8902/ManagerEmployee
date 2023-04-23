using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class EmployeeProject
    {
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public string? Description { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Role { get; set; }

        public EmployeeProject(int employeeId, int projectId, string startDate, string endDate) { 
            this.EmployeeId = employeeId;
            this.ProjectId = projectId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public EmployeeProject(string startDate, string endDate) {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public virtual Employee? Employee { get; set; }
        public virtual Project? Project { get; set; }
    }
}
