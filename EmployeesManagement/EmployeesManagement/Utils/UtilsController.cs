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
       
    }
}
