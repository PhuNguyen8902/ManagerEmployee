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
    public class projectController
    {
        ProjectService projectService = new ProjectService();

        public DataTable GetProjectData(int isActive)
        {
            return projectService.GetProjectData(isActive);
        }

        public DataTable GetProjectEmployeeData(int employeeId) { 
            return projectService.GetProjectEmployeeData(employeeId);
        }
        public DataTable getEmployeeWorkInSpecificProject(int projectId)
        {
            return projectService.getEmployeeWorkInSpecificProject(projectId);
        }
        public bool addProject(Project project) { 
            return projectService.addProject(project);
        }

        public bool updateProject(Project project)
        {
            return projectService.updateProject(project);
        }
        public bool deleteProject(int id) { 
            return projectService.deleteProject(id);
        }
        public bool addEmployeeToProject(EmployeeProject ep)
        {
            return projectService.addEmployeeToProject(ep);
        }
        public bool deleteEmployeeInProject(int employeeId, int projectId)
        {
            return projectService.deleteEmployeeInProject(employeeId, projectId);
        }

        public void Search(ComboBox cbSearch, TextBox tbSearch, ComboBox cbSearchActive,DateTimePicker DTPSearch, DataGridView dgvDepartment)
        {
            string str = "employeeDB.dbo.project";
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
                    DataTable dataTable = projectService.findById(id, str);
                    dgvDepartment.DataSource = dataTable;
                }
            }
            else if (selectedValue == "name")
            {
                string strName = tbSearch.Text;
                DataTable dataTable = projectService.findByCodition(strName, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "description")
            {
                string strDescription = tbSearch.Text;
                DataTable dataTable = projectService.findByCodition(strDescription, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "start_date")
            {
                string strStartDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectService.findByCodition(strStartDate, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "end_date")
            {
                string strEndDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectService.findByCodition(strEndDate, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
            else { 
                string strActive = cbSearchActive.SelectedItem.ToString();
                string Active = "0";
                if (strActive == "Active")
                    Active = "0";
                else
                    Active = "1";
                DataTable dataTable = projectService.findByCodition(Active, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }

        }

    }
}
