using EmployeesManagement.Control;
using EmployeesManagement.Models;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.assignAccountDeatil
{
    public partial class assignAccountDetail : Form
    {
        string accountType = "";
        int accountId = -1;
        private employeeController empController;
        private accountController accController;
        SqlConnection connection = Connection.Connection.GetConnection();
        public assignAccountDetail()
        {
            InitializeComponent();
        }

        public assignAccountDetail(int accountId, string accountType)
        {
            InitializeComponent();
            empController = new employeeController();
            accController = new accountController();
            this.accountType = accountType;
            this.accountId = accountId;
        }

        private void assignAccountDetail_Load(object sender, EventArgs e)
        {
            dgvAssignAccount.Columns.Clear();
            connection.Open();

            DataTable dataTable = empController.getEmployeeNeedAssignData();

            dgvAssignAccount.DataSource = dataTable;

            connection.Close();
            dgvAssignAccount.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AssignButton",
                Text = "Assign",
                UseColumnTextForButtonValue = true
            });
            cbSearch.Items.Add("Employee Id");
            cbSearch.Items.Add("Employee Position");
            cbSearchPosition.Items.Add("Manage");
            cbSearchPosition.Items.Add("Employee");
            btnSearch.Enabled = false;

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
            dgvAssignAccount.Columns.Clear();
            connection.Open();

            DataTable dataTable = empController.getEmployeeNeedAssignData();

            dgvAssignAccount.DataSource = dataTable;

            connection.Close();
            dgvAssignAccount.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AssignButton",
                Text = "Assign",
                UseColumnTextForButtonValue = true
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAssignAccount.Columns.Clear();
            string condition = cbSearch.SelectedItem.ToString();
            if (condition == "Employee Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = empController.searchEmployeeNeedAssignData("id", id);

                    dgvAssignAccount.DataSource = dataTable;
                }
            }
            else
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string position = cbSearchPosition.SelectedItem.ToString();
                    Position pos = new Position();
                    pos = empController.getPositionValueByName(position);
                    int posId = pos.Id;
                    DataTable dataTable = empController.searchEmployeeNeedAssignData("position_id", posId);

                    dgvAssignAccount.DataSource = dataTable;
                }
            }
            dgvAssignAccount.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AssignButton",
                Text = "Assign",
                UseColumnTextForButtonValue = true
            });
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
                if (value == "Employee Id")
                {
                    tbSearch.Visible = true;
                    cbSearchPosition.Visible = false;
                }
                else
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = true;
                }
            }
        }
    }
}
