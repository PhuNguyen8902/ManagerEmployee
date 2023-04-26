using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeesManagement.Service.SalaryService;
using static Mysqlx.Notice.Warning.Types;

namespace EmployeesManagement.Utils
{
    internal class UtilsService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        // load 1 cot du lieu vao combo box dua vao id cua table 
        public void loadSpecificColumnToComboBoxByItsId(ComboBox cbDepartmnet, String specificColumn, String table)
        {
            cbDepartmnet.Items.Clear();
            connection.Open();

            String sql = String.Format("select id,{0} from employeeDB.dbo.{1}", specificColumn, table);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string Column = reader[String.Format("{0}", specificColumn)].ToString();

                        MyComboBoxItem item = new MyComboBoxItem();
                        item.Content = Column;
                        item.Tag = id;

                        // Thêm item vào ComboBox
                        cbDepartmnet.Items.Add(item);
                    }
                }
            }
            connection.Close();
        }

        // lay id tu value trong combo box
        public int getIdFromValueOfComboBox(ComboBox comboBox)
        {
            string value = comboBox.SelectedItem.ToString();
            System.Windows.Controls.ComboBoxItem levelItem = (System.Windows.Controls.ComboBoxItem)comboBox.SelectedItem;
            string idString = levelItem.Tag.ToString();
            int id = Int32.Parse(idString);

            return id;
        }

        // kiem tra so dien thoai
        public Boolean isPhoneNumber(string phone)
        {
            if (!phone.StartsWith("0") || phone.Length !=11 || !phone.All(char.IsDigit))
                return false;

            return true;
        }

        public int numberOfEmployees()
        {
            int sumEmployees = 0;
            connection.Open();

            string sql = "select id from employeeDB.dbo.employee";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sumEmployees++;
            }
            connection.Close();

            return sumEmployees;
        }
        
        public int numberOfProjects()
        {
            int sumProjects = 0;
            connection.Open();

            string sql = "select id from employeeDB.dbo.project";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sumProjects++;
            }
            connection.Close();

            return sumProjects;
        }

        public int numberOfDepartments()
        {
            int sumDepartment = 0;
            connection.Open();

            string sql = "select id from employeeDB.dbo.department";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sumDepartment++;
            }
            connection.Close();

            return sumDepartment;
        }
    }
}
