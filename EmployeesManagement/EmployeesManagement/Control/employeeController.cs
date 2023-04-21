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
        public int getIdByDeparementName(String name)
        {
            return empService.getIdByDeparementName(name);
        }
        public int getIdByNetSalary(int netSalary)
        {
            return empService.getIdByNetSalary(netSalary);
        }
        public int getIdByPositionName(String name)
        {
            return empService.getIdByPositionName(name);
        }

        public Employee getInforEmployee(int id){
            return empService.getInforEmployee(id);
        }

        public Account getAccountOfEmployee(int emid) { 
            return empService.getAccountOfEmployee(emid);
        }
    }
}
