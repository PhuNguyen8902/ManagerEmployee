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

        public DataTable GetDepartmentData()
        {
            return projectService.GetDepartmentData();
        }
    }
}
