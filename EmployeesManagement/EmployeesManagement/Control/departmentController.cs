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

        public DataTable findByCodition(string address, string str, string codition) { 
            return departmentService.findByCodition(address, str, codition);
        }
        public Department getDepartmentOfEmployee(int departmentId) { 
            return departmentService.getDepartmentOfEmployee(departmentId);
         }
    }
}
