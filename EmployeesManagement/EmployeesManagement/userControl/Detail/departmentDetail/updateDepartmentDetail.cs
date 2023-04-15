using EmployeesManagement.Control;
using EmployeesManagement.Models;
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
                            primary primaryPage = new primary();
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
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 11)
            {
                txtPhone.Text = txtPhone.Text.Substring(0, 11);
                MessageBox.Show("Không được nhập quá 11 kí tự");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
