using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Service
{
    internal class DepartmentService
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        public bool loadDepartmentNameToComboBox()
        {
            try
            {
                connection.Open();
                string sql = "select name from department";
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                connection.Close();
            }
            return false;
        }
    }
}
