using EmployeesManagement.Control;
using EmployeesManagement.Models;
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

namespace EmployeesManagement.userControl.UserControlManager.Detail.assignAccountDetail
{
    public partial class assignAccountDetail : Form
    {
        string accountType = "";
        int accountId = -1;
        int deId = -1;
        private employeeController empController;
        private accountController accController;
        SqlConnection connection = Connection.Connection.GetConnection();
        public assignAccountDetail()
        {
            InitializeComponent();
        }
        public assignAccountDetail(int accountId, string accountType, int deId)
        {
            InitializeComponent();
            empController = new employeeController();
            accController = new accountController();
            this.accountType = accountType;
            this.accountId = accountId;
            this.deId = deId;
        }

        private void assignAccountDetail_Load(object sender, EventArgs e)
        {
            tbSearch.Text = "Please enter Employee Id";
            findAll();
            dgvAssignAccount.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AssignButton",
                Text = "Assign",
                UseColumnTextForButtonValue = true
            });
        }
        private void findAll()
        {
            dgvAssignAccount.Columns.Clear();
            connection.Open();

            DataTable dataTable = empController.getEmployeeNeedAssignDataInDepartment(deId);

            dgvAssignAccount.DataSource = dataTable;

            connection.Close();
        }

        private void dgvAssignAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssignAccount.Columns[e.ColumnIndex].Name == "AssignButton")
            {
                int employeeId = (int)dgvAssignAccount.Rows[e.RowIndex].Cells["id"].Value;
                string employeeType = dgvAssignAccount.Rows[e.RowIndex].Cells["position"].Value.ToString();
                if (accountType == employeeType)
                {
                    Boolean rs = accController.updateEmployeeIdForAccount(accountId, employeeId);
                    if (rs)
                    {
                        MessageBox.Show("Update Successful");
                        connection.Open();

                        DataTable dataTable = empController.getEmployeeNeedAssignData();

                        dgvAssignAccount.DataSource = dataTable;

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Fail");
                    }
                }
                else
                {
                    MessageBox.Show("Account and Employee are not functional");
                }
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            findAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tbSearch.Text, out id))
            {
                MessageBox.Show("Please enter a number for the ID!");
            }
            else
            {
                DataTable dataTable = empController.searchEmployeeNeedAssignDataInDepartment("id", id, deId);

                dgvAssignAccount.DataSource = dataTable;
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Please enter Employee Id")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.Black;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Please enter Employee Id";
                tbSearch.ForeColor = Color.Gray;
            }
        }
    }
}
