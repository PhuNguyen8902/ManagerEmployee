using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Models
{
    public class Notify
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }

    }
}
