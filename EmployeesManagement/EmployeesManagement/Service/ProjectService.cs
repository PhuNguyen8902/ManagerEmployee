using EmployeesManagement.Models;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmployeesManagement.Service.SalaryService;

namespace EmployeesManagement.Service
{
    internal class ProjectService
    {
        SqlConnection connection = Connection.Connection.GetConnection();
        // Lấy thông tin project để truyền vào datagridview
        public DataTable GetProjectData(int isActive)
        {
            DataTable table = new DataTable();
            string query = String.Format("SELECT id,name,description,start_date,end_date FROM employeeDB.dbo.project where is_active={0}", isActive);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }



        // Lấy thông tin project của employee cụ thể để truyền vào datagridview
        public DataTable GetProjectEmployeeData(int employeeId, int isActive)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT p.id,p.name, p.description,ep.start_date,ep.end_date FROM employeeDB.dbo.project p " +
                "INNER JOIN employeeDB.dbo.employee_project ep ON ep.project_id=p.id " +
                "where ep.employee_id = {0} and p.is_active = {1}", employeeId, isActive);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // lay ra cac employee lam viec trong project do
        public DataTable getEmployeeWorkInSpecificProject(int projectId)
        {
            DataTable table = new DataTable();
            string query = string.Format("select e.id, e.name, FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, ep.start_date, ep.end_date, d.name as department from employeeDB.dbo.employee e " +
                "inner join employeeDB.dbo.employee_project ep on e.id = ep.employee_id " +
                "inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "where ep.project_id={0}", projectId);
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
                string SQL = string.Format("insert into employeeDB.dbo.project(name, description,start_date,end_date,is_active) VALUES('{0}', '{1}', '{2}','{3}','0')", project.Name, project.Description, project.StartDate, project.EndDate);
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


        // Tìm kiếm bằng id
        public DataTable findById(int id, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT id, name, description, start_date, end_date, IIF(is_active=1, 'End', 'Active') AS Active FROM {1} WHERE id = {0};", id, str);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        // Tìm kiếm project của employee bằng project id
        public DataTable findEmployeeProjectByProjectId(int id, int emid)
        {

            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT ep.employee_id,p.id,p.name,ep.description,ep.start_date,ep.end_date, CASE WHEN p.is_active = 0 THEN 'Active' ELSE 'End' END AS Active FROM employeeDB.dbo.project p INNER JOIN employeeDB.dbo.employee_project ep ON ep.project_id=p.id where ep.project_id = {0} and ep.employee_id = {1}", id, emid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        //Tìm kiếm bằng codition
        public DataTable findByCodition(string address, string str, string codition)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT id, name, description, start_date, end_date, IIF(is_active=1, 'End', 'Active') AS Active FROM {1} WHERE {2} like '%{0}%';", address, str, codition);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        //Tìm kiếm project của employee bằng codition
        public DataTable findEmployeeProjectByCodition(string value, int emid, string codition)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT ep.employee_id, p.id, p.name, ep.description, ep.start_date, ep.end_date, CASE WHEN p.is_active = 0 THEN 'Active' ELSE 'End' END AS Active FROM employeeDB.dbo.project p INNER JOIN employeeDB.dbo.employee_project ep ON ep.project_id = p.id where ep.employee_id = {1} and {2} like '%{0}%';", value, emid, codition);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public bool addEmployeeToProject(EmployeeProject ep)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select employee_id from employeeDB.dbo.employee_project where project_id={0}", ep.ProjectId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["employee_id"].Equals(ep.EmployeeId))
                    {
                        MessageBox.Show("This employee already in this project");
                        return false;
                    }
                }
                connection.Close();

                connection.Open();
                sql = string.Format("insert into employeeDB.dbo.employee_project(employee_id, project_id, start_date, end_date) " +
                    "VALUES('{0}', '{1}' , '{2}', '{3}')", ep.EmployeeId, ep.ProjectId, ep.StartDate, ep.EndDate);
                SqlCommand cmd1 = new SqlCommand(sql, connection);
                if (cmd1.ExecuteNonQuery() > 0)
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

        public bool deleteEmployeeInProject(int employeeId, int projectId)
        {
            try
            {
                connection.Open();
                string sql = string.Format("DELETE FROM employeeDB.dbo.employee_project WHERE employee_id = {0} and project_id={1};", employeeId, projectId);
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
        public bool updateEmployeeInProject(EmployeeProject ep)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.employee_project set start_date = '{0}',end_date ='{1}' where employee_id = {2} and project_id = {3}"
                    , ep.StartDate, ep.EndDate, ep.EmployeeId, ep.ProjectId);
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

        // Lấy thông tin project
        public Project getProject(int proId)
        {
            Project p = new Project();
            try
            {
                connection.Open();
                string sql = string.Format("select * from employeeDB.dbo.project where id= {0} ", proId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    p.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    p.Name = reader.GetString(reader.GetOrdinal("name"));
                    p.Description = reader.GetString(reader.GetOrdinal("description"));
                    p.IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"));
                    p.StartDate = reader.GetString(reader.GetOrdinal("start_date"));
                    p.EndDate = reader.GetString(reader.GetOrdinal("end_date"));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return p;
        }
    }
}
