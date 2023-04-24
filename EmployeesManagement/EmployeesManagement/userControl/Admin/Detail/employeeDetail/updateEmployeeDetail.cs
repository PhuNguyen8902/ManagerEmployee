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
using static EmployeesManagement.Service.SalaryService;
using static Mysqlx.Notice.Warning.Types;

namespace EmployeesManagement.userControl.Detail.employeeDetail
{
    public partial class updateEmployeeDetail : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public byte gender { get; set; }
        public string hometown { get; set; }

        public int departmentId { get; set; }
        public int salaryId { get; set; }
        public int positionId { get; set; }

        employeeController updateEmployee = new employeeController();
        UtilsController utilsController = new UtilsController();
        notifyController notify = new notifyController();


        public updateEmployeeDetail()
        {
            InitializeComponent();
        }
        public updateEmployeeDetail(int id, string name, string phone, byte gender, string homwtown, int departmentId, int salaryId, int positionId)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.gender = gender;
            this.hometown = homwtown; 
            this.departmentId = departmentId;
            this.salaryId= salaryId;
            this.positionId = positionId;
        }

        private void updateEmployeeDetail_Load(object sender, EventArgs e)
        {
            utilsController.loadSpecificColumnToComboBoxByItsId(cbDepartment, "name", "department");
            utilsController.loadSpecificColumnToComboBoxByItsId(cbSalary, "net_salary", "salary");
            utilsController.loadSpecificColumnToComboBoxByItsId(cbPosition, "name", "position");
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
            fillToComboBox(departmentId, salaryId, positionId);
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            byte gender = 0;
            if (rbFemale.Checked)
            {
                gender = 1;
            }

            

            if (txtName.Text != "" && txtPhone.Text != "" && txtHometown.Text != "" && cbDepartment.SelectedIndex != -1 && cbSalary.SelectedIndex != -1 && cbPosition.SelectedIndex != -1)
            {
                bool isPhone = utilsController.isPhoneNumber(txtPhone.Text);
                if (!isPhone)
                {
                    MessageBox.Show("Phone number has to start with 0 and has 11 numbers");
                    return;
                }

                int departmentId = utilsController.getIdFromValueOfComboBox(cbDepartment);
                int salaryId = utilsController.getIdFromValueOfComboBox(cbSalary);
                int positionId = utilsController.getIdFromValueOfComboBox(cbPosition);


                Employee emp = new Employee(id, txtName.Text, txtPhone.Text, gender, txtHometown.Text, departmentId, salaryId, positionId);
                if (updateEmployee.updateEmployee(emp))
                {
                    MessageBox.Show("Update successfully");
                    DateTime now = DateTime.Now;
                    string message = string.Format("Admin has changed your information ({0})", now.ToString());
                    notify.addNotify(id, message);
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
        private void fillToComboBox(int departmentId, int salaryId, int positionId)
        {
            foreach (MyComboBoxItem item in cbDepartment.Items)
            {
                if (int.Parse(item.Tag.ToString()) == departmentId)
                {
                    cbDepartment.SelectedItem = item;
                    break;
                }
            }
            foreach (MyComboBoxItem item in cbSalary.Items)
            {
                if (int.Parse(item.Tag.ToString()) == salaryId)
                {
                    cbSalary.SelectedItem = item;
                    break;
                }
            }
            foreach (MyComboBoxItem item in cbPosition.Items)
            {
                if (int.Parse(item.Tag.ToString()) == positionId)
                {
                    cbPosition.SelectedItem = item;
                    break;
                }
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
