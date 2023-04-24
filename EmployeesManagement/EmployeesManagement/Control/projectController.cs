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
        // project in Admin
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
        public bool updateEmployeeInProject(EmployeeProject ep)
        {
            return projectService.updateEmployeeInProject(ep);
        }
        public DataTable findById(int id, string str) { 
            return projectService.findById(id, str);
        }

        public DataTable findEmployeeProjectByProjectId(int id,int emid) {
            return projectService.findEmployeeProjectByProjectId(id,emid);
        }

        public DataTable findByCodition(string address, string str, string codition) { 
            return projectService.findByCodition(address,str, codition);
        }

        public DataTable findEmployeeProjectByCodition(string value, int emid, string codition) { 
            return projectService.findEmployeeProjectByCodition(value, emid, codition);
        }

        public Project getProject(int proId) { 
            return projectService.getProject(proId);
        }

    }
}
