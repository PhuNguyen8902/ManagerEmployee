using EmployeesManagement.Models;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeesManagement.Service.SalaryService;
using static Mysqlx.Notice.Warning.Types;

namespace EmployeesManagement.Service
{
    public class EmployeeService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        public DataTable GetEmployeeData()
        {
            DataTable table = new DataTable();
            string query = "SELECT e.id, e.name, e.phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.net_salary as salary, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.salary s on e.salary_id = s.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public int getIdByDeparementName(String name)
        {
            connection.Open();
            int id = -1;

            string query = string.Format("SELECT id FROM employeeDB.dbo.department WHERE name like '%{0}%' ", name);

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        connection.Close();
                        return id;
                    }
                }
            }
            connection.Close();
            return id;
        }
        public int getIdByNetSalary(int netSalary)
        {
            connection.Open();
            int id = -1;
            string query = string.Format("SELECT id FROM employeeDB.dbo.salary WHERE net_salary like '%{0}%' ", netSalary);

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        connection.Close();
                        return id;
                    }
                }
            }
            connection.Close();
            return id;
        }
        public int getIdByPositionName(String name)
        {
            connection.Open();
            int id = -1;

            string query = string.Format("SELECT id FROM employeeDB.dbo.position WHERE name like '%{0}%' ", name);

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        connection.Close();
                        return id;
                    }
                }
            }
            connection.Close();
            return id;
        }
        public bool deleteEmployee(int employeeId)
        {
            try
            {
                connection.Open();
                string sql = string.Format("DELETE FROM employeeDB.dbo.employee WHERE id = {0};", employeeId);
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


        public bool addEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.employee(name, phone,gender,home_town, department_id, salary_id, position_id) VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})"
                   , employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.DepartmentId, employee.SalaryId, employee.PositionId);
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

        public bool updateEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employee set name = '{0}', phone = '{1}', gender = '{2}', home_town = '{3}'," +
                    " department_id = '{4}', salary_id = '{5}', position_id = '{6}'  where id = {7}"
                    , employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.DepartmentId, employee.SalaryId, employee.PositionId, employee.Id);
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

        //Lấy thông tin nhân viên
        public Employee getInforEmployee(int id)
        {
            Employee e = new Employee();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.employee WHERE id = {0};", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    e.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    e.Name = reader.GetString(reader.GetOrdinal("name"));
                    e.Phone = reader.GetString(reader.GetOrdinal("phone"));
                    e.Gender = reader.GetByte(reader.GetOrdinal("gender"));
                    e.HomeTown = reader.GetString(reader.GetOrdinal("home_town"));
                    e.DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id"));
                    e.PositionId = reader.GetInt32(reader.GetOrdinal("position_id"));
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
            return e;
        }

        //Lấy thông tin manager của nhân viên
        public Employee getInforManagerOfEmployee(int departmentId)
        {
            Employee e = null;
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.employee WHERE department_id = {0} and position_id = 3;", departmentId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    e = new Employee();
                    e.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    e.Name = reader.GetString(reader.GetOrdinal("name"));
                    e.Phone = reader.GetString(reader.GetOrdinal("phone"));
                    e.Gender = reader.GetByte(reader.GetOrdinal("gender"));
                    e.HomeTown = reader.GetString(reader.GetOrdinal("home_town"));
                    e.DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id"));
                    e.PositionId = reader.GetInt32(reader.GetOrdinal("position_id"));
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
            return e;

        }

        //Lấy thông tin account của nhân viên đó
        public Account getAccountOfEmployee(int emid)
        {
            Account a = new Account();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.account WHERE employee_id = {0};", emid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    a.UserName = reader.GetString(reader.GetOrdinal("user_name"));
                    a.Password = reader.GetString(reader.GetOrdinal("password"));
                    a.FullName = reader.GetString(reader.GetOrdinal("full_name"));
                    a.Type = reader.GetString(reader.GetOrdinal("type"));
                    a.Email = reader.GetString(reader.GetOrdinal("email"));
                    a.EmployeeId = reader.GetInt32(reader.GetOrdinal("employee_id"));
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

        //Chỉnh sửa thông tin nhân viên
        public Boolean updateInforEmployee(Employee e)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.employee set name ='{0}',phone={1},gender={2},home_town='{3}' where id={4}",e.Name,e.Phone,e.Gender,e.HomeTown,e.Id);
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

        //Chỉnh sửa email nhân viên
        public Boolean updateEmailEmployee(int id,string email)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.account set email ='{0}' where employee_id={1}", email,id);
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

        //Kiểm tra trong database có bị trùng email hay không
        public Boolean checkEmailDuplicate(string email) {
            try
            {
                connection.Open();
                string sql = string.Format("SELECT COUNT(*) FROM [employeeDB].[dbo].[account] WHERE email = '{0}'", email);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0) { return false; }
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
            return true;
        }


        public void CloseConnection()
        {
            connection.Close();
        }
        public void OpenConnection()
        {
            SqlConnection connection = Connection.Connection.GetConnection();
            connection.Open();
        }
    }
}
