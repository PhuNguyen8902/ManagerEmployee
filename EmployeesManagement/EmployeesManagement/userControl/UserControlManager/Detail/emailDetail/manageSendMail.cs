using EmployeesManagement.Control;
using EmployeesManagement.userControl.Admin.Detail.emailDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.UserControlManager.Detail.emailDetail
{
    public partial class manageSendMail : Form
    {
        int deId;
        private employeeController employeeController;

        public manageSendMail()
        {
            InitializeComponent();
        }
        public manageSendMail(int deId)
        {
            InitializeComponent();
            employeeController = new employeeController();
            this.deId = deId;
        }

        private void manageSendMail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = employeeController.GetEmployeeDataInDeparment(deId);

            dgvEmployee.DataSource = dataTable;
            loadCbSearch();
            btnSearch.Enabled = false;
            dgvEmployee.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "ChooseButton",
                Text = "Choose",
                UseColumnTextForButtonValue = true
            });
        }
        private void loadCbSearch()
        {
            cbSearch.Items.Add("Employee Id");
            cbSearch.Items.Add("Employee Name");
            cbSearch.Items.Add("Employee Phone");
            cbSearch.Items.Add("Employee Gender");
            cbSearch.Items.Add("Employee HomeTown");
            cbSearch.Items.Add("Salary");
            cbSearchGender.Items.Add("Male");
            cbSearchGender.Items.Add("Female");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "Employee Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = employeeController.findById(id, "e.department_id = " + deId + " and e.id");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Phone")
            {
                long phone;
                if (!long.TryParse(tbSearch.Text, out phone))
                {
                    MessageBox.Show("Please enter a number for the Phone!");
                    return;
                }
                else
                {
                    string strPhone = phone.ToString();
                    DataTable dataTable = employeeController.findByCondition(strPhone, "e.department_id = " + deId + " and e.phone");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(name, "e.department_id = " + deId + " and e.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee HomeTown")
            {
                string homeTown = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(homeTown, "e.department_id = " + deId + " and e.home_town");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Gender")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    int gender = cbSearchGender.SelectedIndex;
                    DataTable dataTable = employeeController.findById(gender, "e.department_id = " + deId + " and e.gender");
                    dgvEmployee.DataSource = dataTable;
                }
            }

            else if (selectedValue == "Salary")
            {
                long salary;
                if (!long.TryParse(tbSearch.Text, out salary))
                {
                    MessageBox.Show("Please enter a number for the Salary!");
                    return;
                }
                else
                {
                    string strSalary = salary.ToString();
                    DataTable dataTable = employeeController.findByCondition(strSalary, "e.department_id = " + deId + " and s.net_salary");
                    dgvEmployee.DataSource = dataTable;
                }
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == -1)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
                if (cbSearch.SelectedItem.ToString() == "Employee Gender")
                {
                    tbSearch.Visible = false;
                    cbSearchGender.Visible = true;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchGender.Visible = false;
                }
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = employeeController.GetEmployeeDataInDeparment(deId);

            dgvEmployee.DataSource = dataTable;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "ChooseButton")
            {
                int emId = (int)dgvEmployee.Rows[e.RowIndex].Cells["EmployeeId"].Value;
                long emPhone = Convert.ToInt64(dgvEmployee.Rows[e.RowIndex].Cells["Phone"].Value);

                manageChooseSend formChoose = new manageChooseSend(emId, emPhone);
                this.Close();
                formChoose.ShowDialog();
            }
        }
    }
}
