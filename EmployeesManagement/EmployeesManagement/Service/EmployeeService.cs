using EmployeesManagement.Models;
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
            string query = "SELECT e.id, e.name, e.phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.coefficient, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.id = d.id " +
                "inner join employeeDB.dbo.salary s on e.id = s.id " +
                "inner join employeeDB.dbo.position p on e.id = p.id";
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
            SqlConnection connection = Connection.Connection.GetConnection();
            connection.Open();
        }
    }
}
