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

        public DataTable GetProjectData()
        {
            return projectService.GetProjectData();
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
    }
}
