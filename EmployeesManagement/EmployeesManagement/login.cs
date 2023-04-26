using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using EmployeesManagement.Connection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using EmployeesManagement.Control;

namespace EmployeesManagement
{
    public partial class login : Form
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        private accountController accController;
        public login()
        {
            InitializeComponent();
            accController = new accountController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM employeeDB.dbo.account WHERE user_name = @user_name";
                SqlCommand sqlCommand = new(selectQuery, connection);
                sqlCommand.Parameters.AddWithValue("@user_name", txtUsername.Text);
                SqlDataReader mdr = sqlCommand.ExecuteReader();
                if (mdr.Read())
                {
                    string storedHash = mdr.GetString(mdr.GetOrdinal("password"));
                    if (accController.verifyPassword(txtPassword.Text, storedHash))
                    {
                        int employeeId = -1;
                        if (mdr.IsDBNull(mdr.GetOrdinal("employee_id")))
                        {
                            MessageBox.Show("You need to assign employee to this account");
                        }
                        else
                        {
                            employeeId = mdr.GetInt32(mdr.GetOrdinal("employee_id"));
                        }
                        string type = mdr.GetString(mdr.GetOrdinal("type"));
                        int accId = mdr.GetInt32(mdr.GetOrdinal("id"));

                        if (type == "Admin" && employeeId != -1)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            primary primaryPage = new primary(0, accId, type);
                            primaryPage.Show();
                        }
                        else if (type == "Employee" && employeeId != -1)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            FormEmployee primaryPage = new FormEmployee(employeeId, type);
                            primaryPage.Show();
                        }
                        else if (type == "Manage" && employeeId != -1)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            FormManager primaryPage = new FormManager(0, employeeId, type);
                            primaryPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Fail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password! Try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }
                connection.Close();
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}