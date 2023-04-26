using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.userControl.UserControlManager.Detail.assignAccountDetail;
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

namespace EmployeesManagement.userControl.UserControlManager
{
    public partial class accountPage : UserControl
    {
        int maId = -1;
        private accountController accController;
        private notifyController notify;
        private employeeController empController;
        SqlConnection connection = Connection.Connection.GetConnection();
        public accountPage()
        {
            InitializeComponent();
        }
        public accountPage(int maId)
        {
            InitializeComponent();
            accController = new accountController();
            notify = new notifyController();
            empController = new employeeController();
            this.maId = maId;
        }

        private void accountPage_Load(object sender, EventArgs e)
        {
            findAll();
            loadCbSearch();
            btnSearch1.Enabled = false;
            btnSearch2.Enabled = false;
            cbSearchPosition.Items.Add("Employee");
        }
        private void findAll()
        {
            connection.Open();

            Employee manage = empController.getInforEmployee(maId);
            int deId = (int)manage.DepartmentId;

            List<int> empList = empController.getEmployeesInDepartment(deId);

            DataTable dataTable = accController.GetAccountDataOfEmpList(empList, maId);
            dgvAccount.Columns.Clear();

            dgvAccount.DataSource = dataTable;

            connection.Close();
        }
        private void loadCbSearch()
        {
            cbSearch.Items.Clear();
            cbSearch.Items.Add("Account Id");
            cbSearch.Items.Add("User Name");
            cbSearch.Items.Add("Email");
            cbSearch.Items.Add("Employee Id");
            btnSearch1.Visible = true;
            btnSearch2.Visible = false;
        }
        private void reset()
        {
            btnSearch1.Enabled = false;
            btnSearch2.Enabled = false;
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            dgvAccount.Columns.Clear();

            connection.Open();

            DataTable dataTable = accController.GetAccountNeedAssignDataInManage();

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
            cbSearchPosition.Items.Clear();
            cbSearchPosition.Items.Add("Employee");
            btnSearch1.Visible = false;
            btnSearch2.Visible = true;
            reset();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            findAll();
            loadCbSearch();
            reset();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "AssignButton")
            {
                int accountId = (int)dgvAccount.Rows[e.RowIndex].Cells["id"].Value;
                string type = dgvAccount.Rows[e.RowIndex].Cells["type"].Value.ToString();
                Employee manage = empController.getInforEmployee(maId);
                int deId = (int)manage.DepartmentId;

                assignAccountDetail formAssign = new assignAccountDetail(accountId, type, deId);
                formAssign.FormClosed += new FormClosedEventHandler(assignAccountDetail_FormClosed);
                formAssign.ShowDialog();
            }
        }
        private void assignAccountDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            findAll();
            reset();
            btnSearch1.Visible = true;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                string type = row.Cells[3].Value.ToString();
                if (type != "Manage")
                {
                    int id = Int32.Parse(row.Cells[0].Value.ToString());
                    Boolean rs = accController.removeeEmployeeIdOutAccount(id);
                    if (rs)
                    {
                        findAll();
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

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string condition = cbSearch.SelectedItem.ToString();
            Employee manage = empController.getInforEmployee(maId);
            int deId = (int)manage.DepartmentId;
            if (condition == "Account Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = accController.searchAccountDataByConditionIdInManage("a.id", id, deId);

                    dgvAccount.DataSource = dataTable;
                }
            }
            else if (condition == "User Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = accController.searchAccountDataByConditionInManage("a.user_name", name, deId);

                dgvAccount.DataSource = dataTable;
            }
            else if (condition == "Email")
            {
                string email = tbSearch.Text;
                DataTable dataTable = accController.searchAccountDataByConditionInManage("a.email", email, deId);

                dgvAccount.DataSource = dataTable;
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
                    DataTable dataTable = accController.searchAccountDataByConditionIdInManage("e.id", emid, deId);

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
        }
    }
}
