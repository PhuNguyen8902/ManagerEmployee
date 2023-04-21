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
    internal class departmentController
    {
        DepartmentService departmentService = new DepartmentService();
        public DataTable GetDepartmentData()
        {
            return departmentService.GetDepartmentData();
        }
        public bool addDepartment(Department department)
        {
            return departmentService.addDepartment(department);
        }
        public bool updateDepartment(Department department)
        {
            return departmentService.updateDepartment(department);
        }
        public bool deleteDepartment(int departmentId)
        {
            return departmentService.deleteDepartment(departmentId);
        }
        public DataTable findById(int id, string str) {
            return departmentService.findById(id, str);
        }
        public void Search(ComboBox cbSearch, TextBox tbSearch,DataGridView dgvDepartment ) {
            string str = "employeeDB.dbo.department";
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = departmentService.findById(id, str);
                    dgvDepartment.DataSource = dataTable;
                }
            }
            else if (selectedValue == "phone")
            {
                int phone;
                if (!int.TryParse(tbSearch.Text, out phone))
                {
                    MessageBox.Show("Please enter a number for the Phone!");
                    return;
                }
                else
                {
                    string strPhone = phone.ToString();
                    DataTable dataTable = departmentService.findByCodition(strPhone, str,selectedValue);
                    dgvDepartment.DataSource = dataTable;
                }
            }
            else 
            {
                string strValue = tbSearch.Text;
                DataTable dataTable = departmentService.findByCodition(strValue, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
            
        }


        public Department getDepartmentOfEmployee(int departmentId) { 
            return departmentService.getDepartmentOfEmployee(departmentId);
         }
    }
}
