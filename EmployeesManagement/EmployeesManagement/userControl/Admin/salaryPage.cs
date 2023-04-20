using EmployeesManagement.Control;
using EmployeesManagement.userControl.Detail.departmentDetail;
using EmployeesManagement.userControl.Detail.salaryDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl
{
    public partial class salaryPage : UserControl
    {
        private salaryController salaryController;
        private departmentController departmentController;


        SqlConnection connection = Connection.Connection.GetConnection();
        public salaryPage()
        {
            salaryController = new salaryController();
            departmentController = new departmentController();

            InitializeComponent();
        }

        private void salaryPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = salaryController.GetSalaryData();

            dgvSalary.DataSource = dataTable;

            connection.Close();
            List<String> strList = new List<String>();
            strList.Add("id");
            strList.Add("coefficient");
            strList.Add("level");
            strList.Add("allowance");
            strList.Add("net_salary");
            salaryController.loadComboBoxSearch(cbSearch, strList);
            salaryController.LoadLevelData(cbSearchLevel);
            btnSearch.Enabled = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addSalaryDetail formAddSalary = new addSalaryDetail();
            formAddSalary.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSalary.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string s = row.Cells[2].Value.ToString();
                int level = salaryController.FindIdByLever(s);
                int allow = Int32.Parse(row.Cells[3].Value.ToString());
                updateSalaryDetail formUpdateSalary = new updateSalaryDetail(id, level, allow);
                formUpdateSalary.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose salary to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSalary.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (salaryController.deleteSalary(id))
                {
                    MessageBox.Show("Delete Success");
                    dgvSalary.DataSource = salaryController.GetSalaryData();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }

            }
            else
            {
                MessageBox.Show("Choose salary want to delete");
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
                 string value = cbSearch.SelectedItem.ToString();
                if (value == "level")
                {
                    tbSearch.Visible = false;
                    cbSearchLevel.Visible = true;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchLevel.Visible = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string str = "employeeDB.dbo.salary";
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                    return;
                }

                DataTable dataTable = salaryController.findById(id, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "coefficient")
            {
                int coefficient;
                if (!int.TryParse(tbSearch.Text, out coefficient))
                {
                    MessageBox.Show("Please enter a number for the Coefficient!");
                    return;
                }
                DataTable dataTable = salaryController.findByCoefficient(coefficient, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "level")
            {
                string level = cbSearchLevel.SelectedItem.ToString();
                DataTable dataTable = salaryController.findByLevel(level, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "allowance")
            {
                int allowance;
                if (!int.TryParse(tbSearch.Text, out allowance))
                {
                    MessageBox.Show("Please enter a number for the Allowance!");
                    return;
                }
                DataTable dataTable = salaryController.findByAllowance(allowance, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "net_salary")
            {
                int net_salary;
                if (!int.TryParse(tbSearch.Text, out net_salary))
                {
                    MessageBox.Show("Please enter a number for the Net_salary!");
                    return;
                }
                DataTable dataTable = salaryController.findByNetSalary(net_salary, str);
                dgvSalary.DataSource = dataTable;
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = salaryController.GetSalaryData();

            dgvSalary.DataSource = dataTable;
        }
    }
}
