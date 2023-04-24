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

        public Employee getInforEmployee(int id)
        {
            return empService.getInforEmployee(id);
        }


        public Boolean updateInforEmployee(Employee e)
        {
            return empService.updateInforEmployee(e);
        }

        public Employee getInforManagerOfEmployee(int departmentId)
        {
            return empService.getInforManagerOfEmployee(departmentId);
        }

        public DataTable getEmployeeNeedAssignData() { 
            return empService.getEmployeeNeedAssignData();
        }
        public Position getPositionValue(int id) { 
            return empService.getPositionValue(id);
        }

        public DataTable searchEmployeeNeedAssignData(string condition, int value) { 
            return empService.searchEmployeeNeedAssignData(condition, value);
        }

        public Position getPositionValueByName(string name) { 
            return empService.getPositionValueByName(name);
        }
        public List<int> getEmployeesInDepartment(int deid) {
            return empService.getEmployeesInDepartment(deid);
        }
        public List<int> getEmployeesInEmployeeProject(int proid) { 
            return empService.getEmployeesInEmployeeProject(proid);
        }

        // Manager controller

        public DataTable GetEmployeeDataByItsManagerId(int managerId)
        {
            return empService.GetEmployeeDataByItsManagerId(managerId);
        }

        public bool addEmployeeByManager(Employee employee)
        {
            return empService.addEmployeeByManager(employee);
        }
        public int getDepartmentIdByManagerId(int managerId)
        {
            return empService.getDepartmentIdByManagerId(managerId);
        }
        public Department GetDepartmentDataByManagerId(int managerid)
        {
            return empService.GetDepartmentDataByManagerId(managerid);
        }

        // Employee trong Department
        public DataTable GetEmployeeDataInDeparment(int deId) { 
            return empService.GetEmployeeDataInDeparment(deId);
        }
        public DataTable searchEmployeeDataInDeparmentByConditionId(int deId, string condition, string value) { 
            return empService.searchEmployeeDataInDeparmentByConditionId(deId, condition, value);
        }
        public DataTable searchEmployeeDataInDeparmentByConditionElse(int deId, string condition, string value) { 
            return empService.searchEmployeeDataInDeparmentByConditionElse(deId, condition, value);
        }

        public DataTable getEmployeeNeedAssignDataInDepartment(int deId) {
            return empService.getEmployeeNeedAssignDataInDepartment(deId);
        }
        public DataTable searchEmployeeNeedAssignDataInDepartment(string condition, int value, int deId) { 
            return empService.searchEmployeeNeedAssignDataInDepartment(condition, value, deId);
        }
        //search
        public DataTable findById(int id, string condition) { 
            return empService.findById(id, condition);
        }
        public DataTable findByCondition(string value, string condition) { 
            return empService.findByCondition(value, condition);
        }
    }
}
