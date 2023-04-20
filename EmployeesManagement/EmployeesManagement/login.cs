using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using EmployeesManagement.Connection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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
                    string type = mdr.GetString(mdr.GetOrdinal("type"));
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    if (type == "Admin")
                    {
                        primary primaryPage = new primary();
                        primaryPage.Show();
                    }
                    else if (type == "Employee")
                    {
                        FormEmployee primaryPage = new FormEmployee();
                        primaryPage.Show();
                    }
                    else if (type == "Manage")
                    {
                        FormManager primaryPage = new FormManager();
                        primaryPage.Show();
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