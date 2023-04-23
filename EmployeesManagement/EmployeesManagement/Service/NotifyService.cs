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
    internal class NotifyService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        // Xử lý thêm thông báo bằng employee id
        public void addNotify(int emid, string value)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.notify(value,employee_id) VALUES('{0}',{1})", value, emid);
                SqlCommand cmd = new SqlCommand(SQL, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //Đếm số lượng notify của một nhân viên
        public int countNotify(int emid)
        {
            int count = 0;
            try
            {
                connection.Open();
                string sql = string.Format("SELECT COUNT(id) FROM employeeDB.dbo.notify WHERE employee_id = {0};", emid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        //Lấy các notify ra
        public List<Notify> getNotify(int emid)
        {
            List<Notify> list = new List<Notify>();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.notify WHERE employee_id = {0};", emid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Notify notify = new Notify();
                    notify.Id = (int)reader["id"];
                    notify.EmployeeId = (int)reader["employee_id"];
                    notify.Value = (string)reader["value"];
                    list.Add(notify);
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
            return list;
        }
        //Xóa notify
        public bool deleteNotify(int emid)
        {
            try
            {
                connection.Open();
                string sql = string.Format("DELETE FROM employeeDB.dbo.notify WHERE employee_id = {0} AND id IN " +
                    "(SELECT TOP 1 id FROM employeeDB.dbo.notify WHERE employee_id = {0} ORDER BY id ASC);", emid);
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

        //Đếm số lượng notify của một nhân viên và xóa notify nếu count > 10
        public void checkAndDeleteNotify(int emid)
        {
            int count = countNotify(emid);
            while (count > 10)
            {
                deleteNotify(emid);
                count--;
            }
        }


    }
}
