using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.userControl.Admin.Detail.assignAccountDeatil;
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

namespace EmployeesManagement.userControl.Admin
{
    public partial class accountPage : UserControl
    {
        private accountController accController;
        SqlConnection connection = Connection.Connection.GetConnection();

        public accountPage()
        {
            InitializeComponent();
            accController = new accountController();
        }

        private void accountPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();

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

        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            dgvAccount.Columns.Clear();

            connection.Open();

            DataTable dataTable = accController.GetAccountData();

            dgvAccount.DataSource = dataTable;

            connection.Close();
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
        }
    }
}
