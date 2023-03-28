using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class EmployeeProject
    {
        public int? EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Role { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Project? Project { get; set; }
    }
}
