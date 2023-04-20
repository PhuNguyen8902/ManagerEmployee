using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.Detail
{
    public partial class addEmployeeDetail : Form
    {
        employeeController empController = new employeeController();
        public addEmployeeDetail()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            // 0 la male, con 1 la female
            byte gender = 0;
            if(rbFemale.Checked)
            {
                gender = 1;
            }

            if(txtName.Text != "" && txtPhone.Text != "" && txtHometown.Text != "")
            {
                Employee emp = new Employee(txtName.Text,txtPhone.Text,gender,txtHometown.Text);
                if(empController.addEmployee(emp) )
                {
                    MessageBox.Show("Thêm thành công");

                    
                    // kiem tra xem form primary co dang mo hay khong
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary();
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
