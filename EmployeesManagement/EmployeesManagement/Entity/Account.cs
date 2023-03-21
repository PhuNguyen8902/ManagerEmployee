using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Entity
{
    internal class Account
    {
        private int id;
        private string userName;
        private string password;
        private string fullName;
        private string email;
        private string type;

        public Account()
        {
        }

        public Account(string userName, string password, string fullName, string email, string type)
        {
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.email = email;
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string Type { get => type; set => type = value; }
    }
}
