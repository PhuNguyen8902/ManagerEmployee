using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.UserControlManager.Detail.employeePage
{
    public partial class addEmployeeByManager : Form
    {
        private int managerId;
        private string type;

        employeeController empController = new employeeController();
        UtilsController utilsController = new UtilsController();
        public addEmployeeByManager()
        {
            InitializeComponent();
            utilsController.loadSpecificColumnToComboBoxByItsId(cbSalary, "net_salary", "salary");
        }

        public addEmployeeByManager(int managerId, string type)
        {
            InitializeComponent();
            this.managerId = managerId;
            utilsController.loadSpecificColumnToComboBoxByItsId(cbSalary, "net_salary", "salary");
            this.type = type;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            // 0 la male, con 1 la female
            byte gender = 0;
            if (rbFemale.Checked)
            {
                gender = 1;
            }



            if (txtName.Text != "" && txtPhone.Text != "" && txtHometown.Text != "" && cbSalary.SelectedIndex != -1 )
            {
                bool isPhone = utilsController.isPhoneNumber(txtPhone.Text);

                if (!isPhone)
                {
                    MessageBox.Show("Phone number has to start with 0");
                    return;
                }

                int salaryId = utilsController.getIdFromValueOfComboBox(cbSalary);
                int departmentId = empController.getDepartmentIdByManagerId(managerId);
                int positionId = 1; // 1 la employee


                Employee emp = new Employee(txtName.Text, txtPhone.Text, gender, txtHometown.Text, departmentId, salaryId, positionId);
                if (empController.addEmployeeByManager(emp))
                {
                    MessageBox.Show("add successfully");


                    // kiem tra xem form primary co dang mo hay khong
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "FormManager")
                        {
                            this.Close();
                            form.Close();
                            FormManager primaryPage = new FormManager(1, managerId, type);
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("add fail");
                }
            }
            else
            {
                MessageBox.Show("Please enter all the informations");
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 11)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 11);
                MessageBox.Show("Can't enter more than 11 numbers");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
