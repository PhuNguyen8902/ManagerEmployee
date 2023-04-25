using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Models
{
    public class PassApp
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
