using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Service
{
    internal class ProjectService
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        // Lấy thông tin deparment để truyền vào datagridview
        public DataTable GetDepartmentData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id,name,description,start_date,end_date, CASE WHEN is_active = 1 THEN 'Đang hoạt động' ELSE 'Đã kết thúc' END AS is_active_string FROM employeeDB.dbo.project";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
