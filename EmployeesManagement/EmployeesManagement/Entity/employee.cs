using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Entity
{
    [Table("employee")]
    public class employee
    {
        private int id;
        private string name;
        private string phone;
        private DateTime dateOfBirth;
        private int gender;
        private string homeTown;

        public employee()
        {
        }

        public employee(string name, string phone, DateTime dateOfBirth, int gender, string homeTown)
        {
            this.name = name;
            this.phone = phone;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.homeTown = homeTown;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Gender { get => gender; set => gender = value; }
        public string HomeTown { get => homeTown; set => homeTown = value; }
    }
}
