using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Mysqlx.Notice.Warning.Types;
using ComboBox = System.Windows.Forms.ComboBox;

namespace EmployeesManagement.Service
{
    internal class SalaryService
    {
        SqlConnection connection = Connection.Connection.GetConnection();


        // Lấy thông tin salary để truyền vào datagridview
        public DataTable GetSalaryData()
        {
            DataTable table = new DataTable();
            string query = "SELECT s.id, s.coefficient, l.level, a.allowance, s.net_salary FROM employeeDB.dbo.salary s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public class MyComboBoxItem : ComboBoxItem
        {
            public override string ToString()
            {
                return Content.ToString();
            }
        }

        //Xử lý combo box Search
        public void loadComboBoxSearch(ComboBox cbSearch, List<string> strList)
        {
            foreach (string str in strList)
            {
                cbSearch.Items.Add(str);
            }
        }



        //Load Combo box level
        public void LoadLevelData(ComboBox cbLevel)
        {
            // Xóa các item trong ComboBox trước khi load dữ liệu mới
            cbLevel.Items.Clear();
            connection.Open();

            // Truy vấn để lấy dữ liệu từ bảng levelSalary_Detail
            string query = "SELECT id,level FROM employeeDB.dbo.levelSalary_Detail";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string name = reader["level"].ToString();
                        // Tạo đối tượng Item có Text là tên level, Tag là ID của level
                        MyComboBoxItem item = new MyComboBoxItem();
                        item.Content = name;
                        item.Tag = id;

                        // Thêm item vào ComboBox
                        cbLevel.Items.Add(item);
                    }
                }
            }
            connection.Close();
        }

        //Tìm leverid theo lever
        public int FindIdByLever(string level)
        {
            connection.Open();
            int id = -1;

            string query = string.Format("SELECT id FROM employeeDB.dbo.levelSalary_Detail WHERE level like '%{0}%'", level);

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

        //Load Combo box allowance
        public void LoadAllowanceData(ComboBox cbAllowance)
        {
            // Xóa các item trong ComboBox trước khi load dữ liệu mới
            cbAllowance.Items.Clear();
            connection.Open();

            // Truy vấn để lấy dữ liệu từ bảng allowanceSalary_Detail
            string query = "SELECT id,allowance FROM employeeDB.dbo.allowanceSalary_Detail";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Thêm giá trị của cột allowance vào ComboBox
                        string id = reader["id"].ToString();
                        string name = reader["allowance"].ToString();
                        // Tạo đối tượng Item có Text là tên level, Tag là ID của level
                        MyComboBoxItem item = new MyComboBoxItem();
                        item.Content = name;
                        item.Tag = id;

                        // Thêm item vào ComboBox
                        cbAllowance.Items.Add(item);
                    }
                }
            }
            connection.Close();
        }

        public int getCoefficientFromLevelSalary_Detail(int level) {
            SqlCommand cmdGetLevel = new SqlCommand("SELECT coefficient FROM employeeDB.dbo.levelSalary_Detail WHERE id = @level", connection);
            cmdGetLevel.Parameters.AddWithValue("@level", level);
            return (int)cmdGetLevel.ExecuteScalar();
        }

        public int getAllowanceFromAllowanceSalary_Detail(int allowance)
        {
            SqlCommand cmdGetAllowance = new SqlCommand("SELECT allowance FROM employeeDB.dbo.allowanceSalary_Detail WHERE id = @allowance", connection);
            cmdGetAllowance.Parameters.AddWithValue("@allowance", allowance);
            return (int)cmdGetAllowance.ExecuteScalar();
        }
        public bool addSalary(int level, int allowance)
        {
            connection.Open();

            try
            {
                int coefficient = getCoefficientFromLevelSalary_Detail(level);
                int allowances = getAllowanceFromAllowanceSalary_Detail(allowance);
                double netSalary = coefficient + allowances;

                // Thực hiện thêm bản ghi vào bảng salary
                SqlCommand cmdAddSalary = new SqlCommand("INSERT INTO employeeDB.dbo.salary (coefficient, level, allowance, net_salary) VALUES (@coefficient, @level, @allowance, @netSalary)", connection);
                cmdAddSalary.Parameters.AddWithValue("@coefficient", coefficient);
                cmdAddSalary.Parameters.AddWithValue("@level", level);
                cmdAddSalary.Parameters.AddWithValue("@allowance", allowance);
                cmdAddSalary.Parameters.AddWithValue("@netSalary", netSalary);

                if (cmdAddSalary.ExecuteNonQuery() > 0)
                {
                    return true;
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
            return false;
        }



        //Xử lý thay đổi salary
        public bool updateSalary(int level, int allowance,Salary salary)
        {
            connection.Open();
            try
            {
                int coefficient = getCoefficientFromLevelSalary_Detail(level);
                int allowances = getAllowanceFromAllowanceSalary_Detail(allowance);
                double netSalary = coefficient + allowances;
                string sql = string.Format("update employeeDB.dbo.salary set coefficient = '{0}', level = '{1}', allowance = '{2}',net_salary = '{3}' where id = {4}", coefficient, level, allowance, netSalary, salary.Id);
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

        //Xử lý xóa Salary
        public bool deleteSalary (int id)
        {
            try
            {
                connection.Open();
                List<int> listEmployeeId = new List<int>();
                string sql = string.Format("select * from employeeDB.dbo.employee where salary_id={0}", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listEmployeeId.Add(rdr.GetInt32(0));
                }
                connection.Close();

                connection.Open();
                foreach (int employeeId in listEmployeeId)
                {
                    sql = string.Format("update employeeDB.dbo.employee set salary_id = NULL where id={0}", employeeId);
                    SqlCommand cmd1 = new SqlCommand(sql, connection);
                    cmd1.ExecuteReader();
                }
                connection.Close();

                connection.Open();
                sql = string.Format("DELETE FROM employeeDB.dbo.salary WHERE id = {0};", id);
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

        //Tìm kiếm bằng id
        public DataTable findById(int id, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT s.id,s.coefficient,l.level,a.allowance,s.net_salary FROM {1} s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id  WHERE s.id = {0} ;", id, str);
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

        //Tìm kiếm bằng coefficient
        public DataTable findByCoefficient(int coefficient, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT s.id,s.coefficient,l.level,a.allowance,s.net_salary FROM {1} s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id  WHERE s.coefficient like '%{0}%';", coefficient, str);
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
        //Tìm kiếm bằng level
        public DataTable findByLevel(string level, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT s.id,s.coefficient,l.level,a.allowance,s.net_salary FROM {1} s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id WHERE l.level LIKE '%{0}%';", level, str);
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
        //Tìm kiếm bằng allowance
        public DataTable findByAllowance(int allowance, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT s.id,s.coefficient,l.level,a.allowance,s.net_salary FROM {1} s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id WHERE a.allowance LIKE '%{0}%';", allowance, str);
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
        //Tìm kiếm bằng net_salary
        public DataTable findByNetSalary(int net_salary, string str)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT s.id,s.coefficient,l.level,a.allowance,s.net_salary FROM {1} s INNER JOIN employeeDB.dbo.allowanceSalary_Detail a ON s.allowance = a.id INNER JOIN employeeDB.dbo.levelSalary_Detail l ON s.level = l.id WHERE s.net_salary LIKE '%{0}%';", net_salary, str);
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

