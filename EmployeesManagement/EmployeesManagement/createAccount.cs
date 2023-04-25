using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using EmployeesManagement.Connection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using EmployeesManagement.Models;
using EmployeesManagement.Control;
using EmployeesManagement.userControl.Detail.departmentDetail;
using Microsoft.Office.Interop.Excel;
using EmployeesManagement.userControl.Admin.Detail.emailDetail;

namespace EmployeesManagement
{
    public partial class createAccount : Form
    {
        int manageId = -1;
        private accountController accController;
        SqlConnection connection = Connection.Connection.GetConnection();
        public createAccount()
        {
            InitializeComponent();
            accController = new accountController();
            createAccountBtn.Visible = true;
            createAccountBtn2.Visible = false;
            backBtn.Visible = true;
            backBtn2.Visible = false;
        }

        public createAccount(int manageId)
        {
            InitializeComponent();
            accController = new accountController();
            this.manageId = manageId;
            panel6.Visible = false;
            createAccountBtn2.Visible = true;
            createAccountBtn.Visible = false;
            backBtn2.Visible = true;
            backBtn.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("Manager");
            cbType.Items.Add("Employee");
            txtUsername.Text = "Please enter user_name";
            txtPassword.Text = "Please enter password";
            txtFullName.Text = "Please enter fullname";
            txtEmail.Text = "Please enter email";

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            primary primary = new primary();
            primary.Show();
            this.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtFullName.Text == "" || cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            Account account = new Account();
            string userName = txtUsername.Text;
            string email = txtEmail.Text;
            Boolean rsUserName = accController.checkUserNameDuplicate(userName, -1);
            Boolean rsEmail = accController.checkEmailDuplicate(email, -1);
            if (rsUserName)
            {
                account.UserName = userName;
            }
            else
            {
                MessageBox.Show("UserName has been duplicated");
                txtUsername.Text = "";
            }
            if (rsEmail)
            {
                account.Email = email;
            }
            else
            {
                MessageBox.Show("Email has been duplicated");
                txtEmail.Text = "";
            }
            string password = txtPassword.Text;
            string passwordAfterHash = accController.hashPassword(password);
            account.Password = passwordAfterHash;
            account.FullName = txtFullName.Text;
            if (cbType.SelectedIndex == 0)
            {
                account.Type = "Manage";
            }
            else
            {
                account.Type = "Employee";
            }
            Boolean rsCreateAccount = accController.createAccount(account);
            if (rsCreateAccount)
            {
                if (cbType.SelectedIndex == 0) {
                    passAppDetail formPassApp = new passAppDetail(account.Email);
                    formPassApp.ShowDialog();
                }
                MessageBox.Show("Account successfully created");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtFullName.Text = "";
                txtEmail.Text = "";
                cbType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Account creation failed");
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Please enter user_name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Please enter user_name";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Please enter password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Please enter password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Please enter fullname")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.Black;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Please enter fullname";
                txtFullName.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Please enter email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Please enter email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void createAccountBtn2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtFullName.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            Account account = new Account();
            string userName = txtUsername.Text;
            string email = txtEmail.Text;
            Boolean rsUserName = accController.checkUserNameDuplicate(userName, -1);
            Boolean rsEmail = accController.checkEmailDuplicate(email, -1);
            if (rsUserName)
            {
                account.UserName = userName;
            }
            else
            {
                MessageBox.Show("UserName has been duplicated");
                txtUsername.Text = "";
            }
            if (rsEmail)
            {
                account.Email = email;
            }
            else
            {
                MessageBox.Show("Email has been duplicated");
                txtEmail.Text = "";
            }
            string password = txtPassword.Text;
            string passwordAfterHash = accController.hashPassword(password);
            account.Password = passwordAfterHash;
            account.FullName = txtFullName.Text;
            account.Type = "Employee";
            Boolean rsCreateAccount = accController.createAccount(account);
            if (rsCreateAccount)
            {
                MessageBox.Show("Account successfully created");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtFullName.Text = "";
                txtEmail.Text = "";
                cbType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Account creation failed");
            }
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            FormManager manage = new FormManager(0, manageId, "Manage");
            manage.Show();
            this.Close();
        }
    }
}