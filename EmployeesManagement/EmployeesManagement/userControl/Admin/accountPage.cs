using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.userControl.Admin.Detail.assignAccountDeatil;
using EmployeesManagement.userControl.Admin.Detail.emailDetail;
using EmployeesManagement.userControl.UserControlEmployee;
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

namespace EmployeesManagement.userControl.Admin
{
    public partial class accountPage : System.Windows.Forms.UserControl
    {
        private accountController accController;
        private notifyController notify;
        SqlConnection connection = Connection.Connection.GetConnection();

        public accountPage()
        {
            InitializeComponent();
            accController = new accountController();
            notify = new notifyController();
        }

        private void accountPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
            loadCbSearch();
            btnSearch1.Enabled = false;
            btnSearch2.Enabled = false;
            cbSearchPosition.Items.Add("Admin");
            cbSearchPosition.Items.Add("Manage");
            cbSearchPosition.Items.Add("Employee");

        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            dgvAccount.Columns.Clear();

            connection.Open();

            DataTable dataTable = accController.GetAccountNeedAssignData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
            dgvAccount.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "AssignButton",
                Text = "Assign",
                UseColumnTextForButtonValue = true
            });
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Account Id");
            cbSearch.Items.Add("User Name");
            cbSearch.Items.Add("Email");
            cbSearch.Items.Add("Position");
            btnSearch1.Visible = false;
            btnSearch2.Visible = true;
            reset();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            dgvAccount.Columns.Clear();

            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
            loadCbSearch();
            reset();

        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "AssignButton")
            {
                int accountId = (int)dgvAccount.Rows[e.RowIndex].Cells["id"].Value;
                string type = dgvAccount.Rows[e.RowIndex].Cells["type"].Value.ToString();

                assignAccountDetail formAssign = new assignAccountDetail(accountId, type);
                formAssign.FormClosed += new FormClosedEventHandler(assignAccountDetail_FormClosed);
                formAssign.ShowDialog();
            }
        }

        private void assignAccountDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvAccount.Columns.Clear();

            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
            btnSearch1.Visible = true;
            reset();

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                string type = row.Cells[3].Value.ToString();
                if (type != "Admin")
                {
                    int id = Int32.Parse(row.Cells[0].Value.ToString());
                    Boolean rs = accController.removeeEmployeeIdOutAccount(id);
                    if (rs)
                    {
                        dgvAccount.DataSource = accController.GetAccountData();
                        MessageBox.Show("Delete Success");
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail");
                    }
                }
                else
                {
                    MessageBox.Show("You cannot change Employee Id in your own Account");
                }
            }
            else
            {
                MessageBox.Show("Choose account want to remove employee id");
            }
            reset();

        }

        private void loadCbSearch()
        {
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Account Id");
            cbSearch.Items.Add("User Name");
            cbSearch.Items.Add("Email");
            cbSearch.Items.Add("Position");
            cbSearch.Items.Add("Employee Id");
            btnSearch1.Visible = true;
            btnSearch2.Visible = false;
        }
        private void reset()
        {
            btnSearch1.Enabled = false;
            btnSearch2.Enabled = false;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string condition = cbSearch.SelectedItem.ToString();
            if (condition == "Account Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = accController.searchAccountDataByConditionId("a.id", id);

                    dgvAccount.DataSource = dataTable;
                }
            }
            else if (condition == "User Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = accController.searchAccountDataByCondition("a.user_name", name);

                dgvAccount.DataSource = dataTable;
            }
            else if (condition == "Email")
            {
                string email = tbSearch.Text;
                DataTable dataTable = accController.searchAccountDataByCondition("a.email", email);

                dgvAccount.DataSource = dataTable;
            }
            else if (condition == "Position")
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string position = cbSearchPosition.SelectedItem.ToString();
                    DataTable dataTable = accController.searchAccountDataByCondition("a.type", position);
                    dgvAccount.DataSource = dataTable;
                }
            }
            else if (condition == "Employee Id")
            {
                int emid;
                if (!int.TryParse(tbSearch.Text, out emid))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = accController.searchAccountDataByConditionId("e.id", emid);

                    dgvAccount.DataSource = dataTable;
                }
            }
        }


        private void btnSearch2_Click(object sender, EventArgs e)
        {

            string condition = cbSearch.SelectedItem.ToString();
            if (condition == "Account Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = accController.searchAccountNeedAssignDataByConditionId("id", id);

                    dgvAccount.DataSource = dataTable;
                }
            }
            else if (condition == "User Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = accController.searchAccountNeedAssignDataByCondition("user_name", name);

                dgvAccount.DataSource = dataTable;
            }
            else if (condition == "Email")
            {
                string email = tbSearch.Text;
                DataTable dataTable = accController.searchAccountNeedAssignDataByCondition("email", email);

                dgvAccount.DataSource = dataTable;
            }
            else if (condition == "Position")
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string position = cbSearchPosition.SelectedItem.ToString();
                    DataTable dataTable = accController.searchAccountNeedAssignDataByCondition("type", position);
                    dgvAccount.DataSource = dataTable;
                }
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == -1)
            {
                btnSearch1.Enabled = false;
                btnSearch2.Enabled = false;

            }
            else
            {
                btnSearch1.Enabled = true;
                btnSearch2.Enabled = true;

                string value = cbSearch.SelectedItem.ToString();
                if (value == "Position")
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = true;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchPosition.Visible = false;
                }
            }
        }

        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                int accId = Int32.Parse(row.Cells[0].Value.ToString());
                changeEmailDetail formChange = new changeEmailDetail(accId);
                formChange.FormClosed += new FormClosedEventHandler(FormChange_FormClosed);
                formChange.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose account want to change email");
            }
            reset();
        }
        private void FormChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
        }
    }
}
