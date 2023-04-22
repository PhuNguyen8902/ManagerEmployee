using System;
using System.Collections.Generic;

namespace EmployeesManagement.Models
{
    public partial class Timekeeping
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public TimeSpan? WorkingHour { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
