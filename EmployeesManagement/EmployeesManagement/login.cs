using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using EmployeesManagement.Connection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace EmployeesManagement
{
    public partial class login : Form
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        public login()
        {
            InitializeComponent();
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
                string selectQuery = "SELECT * FROM employeeDB.dbo.account WHERE user_name = @user_name AND password = @password";
                SqlCommand sqlCommand = new(selectQuery, connection);
                sqlCommand.Parameters.AddWithValue("@user_name", txtUsername.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataReader mdr = sqlCommand.ExecuteReader();
                if (mdr.Read())
                {
                    int employeeId = -1;
                    if (mdr.IsDBNull(mdr.GetOrdinal("employee_id")))
                    {
                        MessageBox.Show("You need to assign employee to this account");
                    }
                    else { employeeId = mdr.GetInt32(mdr.GetOrdinal("employee_id")); }
                    string type = mdr.GetString(mdr.GetOrdinal("type"));
                    
                    if (type == "Admin" && employeeId != -1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        primary primaryPage = new primary();
                        primaryPage.Show();
                    }
                    else if (type == "Employee" && employeeId != -1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        FormEmployee primaryPage = new FormEmployee(employeeId, type);
                        //FormEmployee primaryPage = new FormEmployee();
                        primaryPage.Show();
                    }
                    else if (type == "Manage" && employeeId != -1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        FormManager primaryPage = new FormManager();
                        primaryPage.Show();
                    }
                    else {
                        MessageBox.Show("Login Fail");
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