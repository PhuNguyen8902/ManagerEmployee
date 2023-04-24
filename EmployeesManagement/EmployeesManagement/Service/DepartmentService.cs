using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        // Lấy thông tin deparment để truyền vào datagridview
        public DataTable GetDepartmentData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id, name, FORMAT(CAST(phone AS BIGINT), '00000000000') AS phone, address FROM employeeDB.dbo.department";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }



        // Xử lý thêm department vào database
        public bool addDepartment(Department department)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.department(name, phone,address) VALUES('{0}', '{1}', '{2}')", department.Name, department.Phone, department.Address);
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

        //Xử lý thay đổi department
        public bool updateDepartment(Department department)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.department set name = '{0}', phone = '{1}', address = '{2}' where id = {3}", department.Name, department.Phone, department.Address, department.Id);
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

        //Xử lý xóa Department
        public bool deleteDepartment(int id)
        {
            try
            {
                connection.Open();
                List<int> listEmployeeId = new List<int>();
                string sql = string.Format("select * from employeeDB.dbo.employee where department_id={0}", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    listEmployeeId.Add(rdr.GetInt32(0));
                }
                connection.Close();

                connection.Open();
                foreach(int employeeId in listEmployeeId)
                {
                    sql = string.Format("update employeeDB.dbo.employee set department_id = NULL where id={0}", employeeId);
                    SqlCommand cmd1 = new SqlCommand(sql, connection);
                    cmd1.ExecuteReader();
                }
                connection.Close();

                connection.Open();
                sql = string.Format("DELETE FROM employeeDB.dbo.department WHERE id = {0};", id);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                if (cmd2.ExecuteNonQuery() > 0)
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
        public DataTable findById(int id,string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT id,name,FORMAT(CAST(phone AS BIGINT), '00000000000') AS phone,address FROM {1} WHERE id = {0};", id,str);
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
        public DataTable findByCodition(string address, string str,string codition)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT id,name,FORMAT(CAST(phone AS BIGINT), '00000000000') AS phone,address FROM {1} WHERE {2} like '%{0}%';", address, str,codition);
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

        //Lấy thông tin deparment của 1 nhân viên
        public Department getDepartmentOfEmployee(int departmentId)
        {
            Department a = new Department();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.department WHERE id = {0};", departmentId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    a.Name = reader.GetString(reader.GetOrdinal("name"));
                    a.Phone = reader.GetString(reader.GetOrdinal("phone"));
                    a.Address = reader.GetString(reader.GetOrdinal("address"));
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
            return a;
        }

    }
}
