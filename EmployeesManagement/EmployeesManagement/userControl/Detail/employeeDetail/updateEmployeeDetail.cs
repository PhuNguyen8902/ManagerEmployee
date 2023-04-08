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

namespace EmployeesManagement.userControl.Detail.employeeDetail
{
    public partial class updateEmployeeDetail : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public byte gender { get; set; }
        public string hometown { get; set; }

        employeeController updateEmployee = new employeeController();
        public updateEmployeeDetail()
        {
            InitializeComponent();
        }
        public updateEmployeeDetail(int id, string name, string phone, byte gender, string homwtown)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.gender = gender;
            this.hometown = homwtown;
        }

        private void updateEmployeeDetail_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtPhone.Text = phone;
            if(gender == 0)
            {
                rbMale.Checked = true;
            }
            else if(gender == 1)
            {
                rbFemale.Checked = true;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            txtHometown.Text = hometown;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            byte gender = 0;
            if (rbFemale.Checked)
            {
                gender = 1;
            }
     
            if (txtName.Text != "" && txtPhone.Text != "" && txtHometown.Text != "")
            {
                Employee employee= new Employee(id, txtName.Text, txtPhone.Text, gender, txtHometown.Text);
                if (updateEmployee.updateEmployee(employee))
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
                    MessageBox.Show("Update employee fail");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
    }
}
