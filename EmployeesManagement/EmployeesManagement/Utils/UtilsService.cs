using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeesManagement.Service.SalaryService;

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
    }
}
