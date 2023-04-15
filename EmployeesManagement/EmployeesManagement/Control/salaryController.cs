using EmployeesManagement.Models;
using EmployeesManagement.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Control
{
    internal class salaryController
    {
        SalaryService salaryService = new SalaryService();
        public DataTable GetSalaryData()
        {
            return salaryService.GetSalaryData();
        }
        public void LoadLevelData(ComboBox comboBox)
        {
            salaryService.LoadLevelData(comboBox);
        }
        public void LoadAllowanceData(ComboBox comboBox) {
            salaryService.LoadAllowanceData(comboBox);
        }
        public bool addSalary(int level, int allowance) {
            return salaryService.addSalary(level, allowance);
        }
        public bool updateSalary(int level, int allowance, Salary salary) {
            return salaryService.updateSalary(level, allowance, salary);
        }
        public bool deleteSalary(int id) {
            return salaryService.deleteSalary(id);
        }
        public void loadComboBoxSearch(ComboBox cbSearch, List<string> strList)
        {
            salaryService.loadComboBoxSearch(cbSearch, strList);
        }
        public DataTable findById(int id, string str)
        {
            return salaryService.findById(id, str);
        }
        public DataTable findByCoefficient(int coefficient, string str){
            return salaryService.findByCoefficient(coefficient, str);
        }
        public DataTable findByLevel(string level, string str) { 
        return salaryService.findByLevel(level, str);
        }
       
        public DataTable findByAllowance(int allowance, string str) { 
            return salaryService.findByAllowance(allowance, str);
        }
        public DataTable findByNetSalary(int net_salary, string str) { 
            return salaryService.findByNetSalary(net_salary, str);
        }
      
    }
}
