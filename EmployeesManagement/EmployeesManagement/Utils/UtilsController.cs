using EmployeesManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Utils
{
    internal class UtilsController
    {
        UtilsService utilsService = new UtilsService();
        public void loadSpecificColumnToComboBoxByItsId(ComboBox cbDepartment, String specificColumn, String table)
        {
            utilsService.loadSpecificColumnToComboBoxByItsId(cbDepartment, specificColumn, table);
        }

        public int getIdFromValueOfComboBox(ComboBox comboBox)
        {
            return utilsService.getIdFromValueOfComboBox(comboBox);
        }
        public Boolean isPhoneNumber(String phone)
        {
            return utilsService.isPhoneNumber(phone);
        }
       
        public int numberOfEmployees()
        {
            return utilsService.numberOfEmployees();
        }
        public int numberOfProjects()
        {
            return utilsService.numberOfProjects();
        }
        public int numberOfDepartment()
        {
            return utilsService.numberOfDepartments();
        }
        public List<int> numberOfYear()
        {
            return utilsService.numberOfYear();
        }
        public int numberOfPorjectOfYear(int year)
        {
            return utilsService.numberOfPorjectOfYear(year);
        }
    }
}
