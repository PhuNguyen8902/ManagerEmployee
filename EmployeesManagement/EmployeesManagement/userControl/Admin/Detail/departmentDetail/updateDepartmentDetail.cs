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

namespace EmployeesManagement.userControl.Detail.departmentDetail
{
    public partial class updateDepartmentDetail : Form
    {
        departmentController departmentController = new departmentController();
        UtilsController utilsController = new UtilsController();

        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public updateDepartmentDetail()
        {
            InitializeComponent();
        }
        public updateDepartmentDetail(int id, string name, string phone, string address)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
            {
                Boolean phone = utilsController.isPhoneNumber(txtPhone.Text);
                if (!phone)
                {
                    MessageBox.Show("Phone numbers that start with 0 and receive 11 numbers");
                    return;
                }
                Department department = new Department(id, txtName.Text, txtPhone.Text, txtAddress.Text);
                if (departmentController.updateDepartment(department))
                {
                    MessageBox.Show("Update successfully");
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary(2);
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Update department fail");
                }
            }
            else
            {
                MessageBox.Show("Please enter in full");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //if (txtPhone.Text.Length > 11)
            //{
            //    txtPhone.Text = txtPhone.Text.Substring(0, 11);
            //    MessageBox.Show("Do not enter more than 11 numbers");
            //}
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fillTextBox(string name, string phone, string address)
        {
            txtName.Text = name;
            txtPhone.Text = phone;
            txtAddress.Text = address;
        }

        private void updateDepartmentDetail_Load(object sender, EventArgs e)
        {
            txtPhone.TextChanged -= txtPhone_TextChanged;

            fillTextBox(name, phone, address);

            txtPhone.TextChanged += txtPhone_TextChanged;
        }
    }
}
