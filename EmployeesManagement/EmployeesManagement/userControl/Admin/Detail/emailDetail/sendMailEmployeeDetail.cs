using EmployeesManagement.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    public partial class sendMailEmployeeDetail : Form
    {
        private employeeController employeeController;

        public sendMailEmployeeDetail()
        {
            InitializeComponent();
            employeeController = new employeeController();

        }

        private void sendMailEmployeeDetail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = employeeController.getEmployee();

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
            cbSearch.Items.Add("Department");
            cbSearch.Items.Add("Salary");
            cbSearch.Items.Add("Position");
            cbSearchGender.Items.Add("Male");
            cbSearchGender.Items.Add("Female");
            cbSearchPosition.Items.Add("Employee");
            cbSearchPosition.Items.Add("Admin");
            cbSearchPosition.Items.Add("Manage");

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
                    DataTable dataTable = employeeController.findById(id, "e.id");
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
                    DataTable dataTable = employeeController.findByCondition(strPhone, "e.phone");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(name, "e.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee HomeTown")
            {
                string homeTown = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(homeTown, "e.home_town");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Gender")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    int gender = cbSearchGender.SelectedIndex;
                    DataTable dataTable = employeeController.findById(gender, "e.gender");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Department")
            {
                string department = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(department, "d.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Position")
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string position = cbSearchPosition.SelectedItem.ToString();
                    DataTable dataTable = employeeController.findByCondition(position, "p.name");
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
                    DataTable dataTable = employeeController.findByCondition(strSalary, "s.net_salary");
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
                    cbSearchPosition.Visible = false;
                    cbSearchGender.Visible = true;
                }
                else if (cbSearch.SelectedItem.ToString() == "Position")
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = true;
                    cbSearchGender.Visible = false;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchPosition.Visible = false;
                    cbSearchGender.Visible = false;
                }
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = employeeController.getEmployee();

            dgvEmployee.DataSource = dataTable;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "ChooseButton")
            {
                int emId = (int)dgvEmployee.Rows[e.RowIndex].Cells["id"].Value;
                long emPhone = Convert.ToInt64(dgvEmployee.Rows[e.RowIndex].Cells["phone"].Value);

                chooseSend formChoose = new chooseSend(emId, emPhone);
                this.Close();
                formChoose.ShowDialog();
            }
        }
    }
}
