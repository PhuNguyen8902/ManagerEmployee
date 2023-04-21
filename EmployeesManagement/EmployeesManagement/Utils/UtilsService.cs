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

        //Kiểm tra phone hợp lệ
        public Boolean checkPhone(string phone)
        {
            if (!phone.StartsWith("0") || phone.Length != 11 || !phone.All(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
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
            if (!phone.StartsWith("0") || phone.Length >= 11 || !phone.All(char.IsDigit))
                return false;

            return true;
        }

      
    }
}
