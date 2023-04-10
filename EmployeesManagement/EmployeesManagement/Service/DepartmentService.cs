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
            string query = "SELECT id,name,phone,address FROM employeeDB.dbo.department";
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
                string sql = string.Format("DELETE FROM employeeDB.dbo.department WHERE id = {0};", id);
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
        public DataTable findById(int id,string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM {1} WHERE id = {0};", id,str);
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
                string sql = string.Format("SELECT * FROM {1} WHERE {2} like '%{0}%';", address, str,codition);
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
    }
}
