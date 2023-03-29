using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Service
{
    public class EmployeeService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        public DataTable GetEmployeeData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id,name,phone,gender,home_town FROM employeeDB.dbo.employee";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public void DeleteEmployee(int employeeId)
        {
            string sql = "DELETE FROM employeeDB.dbo.employee WHERE id = @employeeId";
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.ExecuteNonQuery();
            }
        }


        public void CloseConnection()
        {
            connection.Close();
        }
        public void OpenConnection()
        {
            connection.Open();
        }
    }
}
