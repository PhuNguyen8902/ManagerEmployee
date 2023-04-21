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
    public class employeeController
    {
        EmployeeService empService = new EmployeeService();

        public DataTable getEmployee()
        {
            return empService.GetEmployeeData();
        }
        public bool addEmployee(Employee employee)
        {
            return empService.addEmployee(employee);
        }
        public bool deleteEmployee(int empId)
        {
            return empService.deleteEmployee(empId);
        }
        public bool updateEmployee(Employee employee)
        {
            return empService.updateEmployee(employee);
        }

        public Employee getInforEmployee(int id) {
            return empService.getInforEmployee(id);
        }

        public Account getAccountOfEmployee(int emid) {
            return empService.getAccountOfEmployee(emid);
        }

        public Boolean updateInforEmployee(Employee e){
            return empService.updateInforEmployee(e);
        }
    }
}
