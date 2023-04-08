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
    public class EmployeeService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        public bool addEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.employee(name, phone,gender,home_town) VALUES('{0}', '{1}', '{2}', '{3}')", employee.Name, employee.Phone, employee.Gender, employee.HomeTown);
                SqlCommand cmd = new SqlCommand(SQL, connection);
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
        public DataTable GetEmployeeData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id,name,phone,gender,home_town FROM employeeDB.dbo.employee";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
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
        public bool updateEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employee set name = '{0}', phone = '{1}', gender = '{2}', home_town = '{3}' where id = {4}", employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.Id);
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
