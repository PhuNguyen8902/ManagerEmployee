﻿using EmployeesManagement.Control;
using EmployeesManagement.Models;

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class managerEmployeePage : UserControl
    {
        private int id;
        private employeeController empController;
        private departmentController departmentController;

        public managerEmployeePage()
        {
            InitializeComponent();
        }

        public managerEmployeePage(int id)
        {
            InitializeComponent();
            empController = new employeeController();
            departmentController = new departmentController();
            this.id = id;
            loadManagerInfor();
        }

        private void loadManagerInfor()
        {
            Employee employee = new Employee();
            employee = empController.getInforEmployee(id);
            int departmentId = (int)employee.DepartmentId;
            Department department = new Department();
            Employee manager = new Employee();
            department = departmentController.getDepartmentOfEmployee(departmentId);
            manager = empController.getInforManagerOfEmployee(departmentId);
            if (manager != null)
            {
                if (manager.PositionId == 3)
                {
                    tbManagerPosition.Text = "Manager";
                }
                tbManagerName.Text = manager.Name;
                tbManagerPhone.Text = "0" + manager.Phone;
                if (manager.Gender == 0)
                {
                    tbManagerGender.Text = "Male";
                }
                else
                {
                    tbManagerGender.Text = "Female";
                }
            }
            else
            {
                lbNotifyManager.Visible = true;
            }
            tbDepartmentName.Text = department.Name;
            tbDepartmentPhone.Text = "0" + department.Phone;
            tbDepartmentAddress.Text = department.Address;
        }
    }
}
