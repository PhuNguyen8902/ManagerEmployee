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

namespace EmployeesManagement.userControl.UserControlManager
{
    public partial class informationManagerPage : UserControl
    {
        private int id;
        private employeeController empController = new employeeController();
        private departmentController departmentController = new departmentController();
        private accountController accController = new accountController();
        UtilsController utilsController = new UtilsController();
        public informationManagerPage()
        {
            InitializeComponent();
        }
        public informationManagerPage(int managerId)
        {
            InitializeComponent();
            this.id = managerId;
        }
        public void loadInfoManager()
        {
            Employee e = new Employee();
            Account a = new Account();
            Department d = new Department();
            String gender = "";
            e = empController.getInforEmployee(id);
            a = accController.getAccountOfEmployee(id);
            if (e.DepartmentId != null)
            {
                int departmentId = (int)e.DepartmentId;
                d = departmentController.getDepartmentOfEmployee(departmentId);
                tbInforDepartment.Text = d.Name;
            }
            tbInforId.Text = e.Id.ToString();
            tbInforName.Text = e.Name;
            tbInforPhone.Text = "0" + e.Phone;
            if (e.Gender == 0)
            {
                cbInforGender.SelectedIndex = 0;
            }
            else
            {
                cbInforGender.SelectedIndex = 1;
            }
            tbInforHomeTown.Text = e.HomeTown;
            tbInforPosition.Text = a.Type;
            tbInforEmail.Text = a.Email;

        }
        private void informationManagerPage_Load(object sender, EventArgs e)
        {
            cbInforGender.Items.Add("Male");
            cbInforGender.Items.Add("Female");
            cbInforGender.KeyDown += (s, e) => e.SuppressKeyPress = true;
            loadInfoManager();
        }

        private void btnInforUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Id = int.Parse(tbInforId.Text);
            emp.Name = tbInforName.Text;
            String strPhone = tbInforPhone.Text.Trim();
            Boolean phoneRs = utilsController.isPhoneNumber(strPhone);
            emp.Gender = (byte)cbInforGender.SelectedIndex;
            emp.HomeTown = tbInforHomeTown.Text;
            string email = tbInforEmail.Text;
            Boolean rsEmailDuplicate = accController.checkEmailDuplicate(email, emp.Id);
            if (phoneRs && rsEmailDuplicate)
            {
                emp.Phone = strPhone;
                Boolean rs = empController.updateInforEmployee(emp);
                Boolean rsUpdateEmail = accController.updateEmailEmployee(emp.Id, email);
                if (rs && rsUpdateEmail)
                {
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("Update fail");
                }
            }
            else
            {
                if (!phoneRs)
                {
                    MessageBox.Show("Phone numbers that start with 0 and receive 11 numbers");
                    tbInforPhone.Text = "";
                }
                if (!rsEmailDuplicate)
                {
                    MessageBox.Show("Email is duplicated");
                    tbInforEmail.Text = "";
                }
            }

        }
    }
}
