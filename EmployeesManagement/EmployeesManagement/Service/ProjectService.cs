using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeesManagement.Service.SalaryService;

namespace EmployeesManagement.Service
{
    internal class ProjectService
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        // Lấy thông tin project để truyền vào datagridview
        public DataTable GetProjectData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id,name,description,start_date,end_date, CASE WHEN is_active = 0 THEN 'Đang hoạt động' ELSE 'Đã kết thúc' END AS Tình_Trạng FROM employeeDB.dbo.project";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Xử lý thêm project vào database
        public bool addProject(Project project)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.project(name, description,start_date,end_date,is_active) VALUES('{0}', '{1}', '{2}','{3}','0')", project.Name, project.Description, project.StartDate,project.EndDate);
                SqlCommand cmd = new SqlCommand(SQL, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        //Xử lý thay đổi project
        public bool updateProject(Project project)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.project set name = '{0}', description = '{1}', start_date = '{2}',end_date ='{3}',is_active = '{4}' where id = {5}", project.Name, project.Description, project.StartDate, project.EndDate, project.IsActive, project.Id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        //Xử lý xóa project
        public bool deleteProject(int id)
        {
            try
            {
                connection.Open();
                string sql = string.Format("DELETE FROM employeeDB.dbo.project WHERE id = {0};", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
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
