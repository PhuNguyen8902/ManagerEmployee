using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeesManagement.Service
{
    public class AccountService
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        //Chỉnh sửa email nhân viên
        public Boolean updateEmailEmployee(int id, string email)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.account set email ='{0}' where employee_id={1}", email, id);
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
        public Boolean checkEmailDuplicate(string email)
        {
            try
            {
                connection.Open();
                string sql = string.Format("SELECT COUNT(*) FROM [employeeDB].[dbo].[account] WHERE email = '{0}'", email);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0) { return true; }
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

        //Kiểm tra trong database có bị trùng user_name hay không
        public Boolean checkUserNameDuplicate(string user_name)
        {
            try
            {
                connection.Open();
                string sql = string.Format("SELECT COUNT(*) FROM [employeeDB].[dbo].[account] WHERE user_name = '{0}'", user_name);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0) { return true; }
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

        //Lấy thông tin account của nhân viên đó
        public Account getAccountOfEmployee(int emid)
        {
            Account a = null;
            bool recordFound = false;
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.account WHERE employee_id = {0};", emid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a = new Account();
                    a.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    a.UserName = reader.GetString(reader.GetOrdinal("user_name"));
                    a.Password = reader.GetString(reader.GetOrdinal("password"));
                    a.FullName = reader.GetString(reader.GetOrdinal("full_name"));
                    a.Type = reader.GetString(reader.GetOrdinal("type"));
                    a.Email = reader.GetString(reader.GetOrdinal("email"));
                    a.EmployeeId = reader.GetInt32(reader.GetOrdinal("employee_id"));
                    recordFound = true;
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
            if (!recordFound)
            {
                a = null;
            }
            return a;
        }


        //Hash password
        public string hashPassword(string password)
        {
            // Tạo một salt ngẫu nhiên
            byte[] saltBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            // Chuyển đổi mật khẩu và salt thành một mảng byte
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPasswordBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passwordBytes, 0, saltedPasswordBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, saltedPasswordBytes, passwordBytes.Length, saltBytes.Length);

            // Khởi tạo đối tượng SHA256 để thực hiện thuật toán băm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Thực hiện thuật toán băm trên mật khẩu và salt
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Chuyển đổi mảng byte thành chuỗi hexa để lưu trữ
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                // Thêm salt vào đầu chuỗi hexa
                sb.Insert(0, BitConverter.ToString(saltBytes).Replace("-", ""));

                return sb.ToString();
            }
        }

        //So sánh mật khẩu để login
        public bool verifyPassword(string password, string storedHash)
        {
            // Lấy salt từ chuỗi hexa đầu tiên
            byte[] saltBytes = Enumerable.Range(0, 64)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(storedHash.Substring(x, 2), 16))
                                 .ToArray();

            // Tạo một mảng byte để chứa salt và password
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltedPasswordBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passwordBytes, 0, saltedPasswordBytes, 0, passwordBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, saltedPasswordBytes, passwordBytes.Length, saltBytes.Length);

            // Khởi tạo đối tượng SHA256 để thực hiện thuật toán băm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Thực hiện thuật toán băm trên mật khẩu và salt
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Chuyển đổi mảng byte thành chuỗi hexa để lưu trữ
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                // Thêm salt vào đầu chuỗi hexa
                sb.Insert(0, BitConverter.ToString(saltBytes).Replace("-", ""));

                // So sánh với hash lưu trữ
                return storedHash.Equals(sb.ToString(), StringComparison.OrdinalIgnoreCase);
            }
        }

        //Tạo tài khoản
        public Boolean createAccount(Account a)
        {
            connection.Open();
            try
            {
                // Thực hiện thêm bản ghi vào bảng salary
                SqlCommand cmdAddSalary = new SqlCommand("INSERT INTO employeeDB.dbo.account (user_name, password, full_name, email,type) VALUES (@user_name, @password, @full_name, @email,@type)", connection);
                cmdAddSalary.Parameters.AddWithValue("@user_name", a.UserName);
                cmdAddSalary.Parameters.AddWithValue("@password", a.Password);
                cmdAddSalary.Parameters.AddWithValue("@full_name", a.FullName);
                cmdAddSalary.Parameters.AddWithValue("@email", a.Email);
                cmdAddSalary.Parameters.AddWithValue("@type", a.Type);

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

        // Lấy thông tin account để truyền vào datagridview
        public DataTable GetAccountData()
        {
            DataTable table = new DataTable();
            string query = "SELECT a.id, a.user_name, a.email, a.type, e.id AS EmployeeId, e.name AS EmployeeName FROM employeeDB.dbo.account a LEFT JOIN employeeDB.dbo.employee e ON a.employee_id = e.id";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Lấy thông tin account cần gán employee_id để truyền vào datagridview
        public DataTable GetAccountNeedAssignData()
        {
            DataTable table = new DataTable();
            string query = "SELECT id, user_name, email, type FROM employeeDB.dbo.account Where employee_id IS NULL";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }


        //Gán nhân viên cho account
        public Boolean updateEmployeeIdForAccount(int accountId, int emId)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.account set employee_id ='{0}' where id={1}", emId, accountId);
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

        //Gỡ nhân viên của account
        public Boolean removeEmployeeIdOutAccount(int accountId)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.account set employee_id = NULL where id={0}", accountId);
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

        // Search thông tin account để truyền vào datagridview bằng các condition chính xác như id
        public DataTable searchAccountDataByConditionId(string condition,int id)
        {
            DataTable table = new DataTable();
            string query =string.Format("SELECT a.id, a.user_name, a.email, a.type, e.id AS EmployeeId, e.name AS EmployeeName FROM employeeDB.dbo.account a LEFT JOIN employeeDB.dbo.employee e ON a.employee_id = e.id WHERE a.{0}={1}",condition,id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Search thông tin account để truyền vào datagridview bằng các condition khác
        public DataTable searchAccountDataByCondition(string condition, string id)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT a.id, a.user_name, a.email, a.type, e.id AS EmployeeId, e.name AS EmployeeName FROM employeeDB.dbo.account a LEFT JOIN employeeDB.dbo.employee e ON a.employee_id = e.id WHERE a.{0} like '%{1}%'", condition, id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Search thông tin account cần gán employee_id để truyền vào datagridview bằng các condition khác
        public DataTable searchAccountNeedAssignDataByConditionId(string condition,int id)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT id, user_name, email, type FROM employeeDB.dbo.account Where employee_id IS NULL and {0} ={1}", condition, id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Search thông tin account cần gán employee_id để truyền vào datagridview bằng các condition khác
        public DataTable searchAccountNeedAssignDataByCondition(string condition, string value)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT id, user_name, email, type FROM employeeDB.dbo.account Where employee_id IS NULL and {0} like '%{1}%'",condition,value);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

    }
}
