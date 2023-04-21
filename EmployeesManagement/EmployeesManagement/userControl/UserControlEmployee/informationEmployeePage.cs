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

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class informationEmployeePage : UserControl
    {
        private int id;
        private employeeController empController;
        private departmentController departmentController;


        public informationEmployeePage()
        {
            InitializeComponent();
        }

        public informationEmployeePage(int id)
        {
            InitializeComponent();
            this.id = id;
            empController = new employeeController();
            departmentController = new departmentController();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadInforEmployee()
        {
            Employee e = new Employee();
            Account a = new Account();
            Department d = new Department();
            String gender = "";
            e = empController.getInforEmployee(id);
            a = empController.getAccountOfEmployee(id);
            int departmentId = (int)e.DepartmentId;
            d = departmentController.getDepartmentOfEmployee(departmentId);
            tbInforId.Text = e.Id.ToString();
            tbInforName.Text = e.Name;
            tbInforPhone.Text = "0" +e.Phone;
            if (e.Gender == 0)
            {
                cbInforGender.SelectedIndex = 0;
            }
            else
            {
                cbInforGender.SelectedIndex = 1;
            }
            tbInforHomeTown.Text = e.HomeTown;
            tbInforDepartment.Text = d.Name;
            tbInforPosition.Text = a.Type;
            tbInforEmail.Text = a.Email;
        }

        private void informationEmployeePage_Load(object sender, EventArgs e)
        {
            cbInforGender.Items.Add("Male");
            cbInforGender.Items.Add("Female");
            loadInforEmployee();
        }
    }
}
