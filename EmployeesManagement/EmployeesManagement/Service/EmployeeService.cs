using EmployeesManagement.Models;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Datatypes;
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
            string query = "SELECT e.id, e.name, FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.net_salary as salary, p.name as position " +
                "FROM employeeDB.dbo.employee e left join employeeDB.dbo.department d on e.department_id = d.id " +
                "left join employeeDB.dbo.salary s on e.salary_id = s.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // lay nhan vien trong department cua manager cu the
        public DataTable GetEmployeeDataByItsManagerId(int managerId)
        {
            int departmentId = 0;
            DataTable table = new DataTable();

            connection.Open();
            string sql = String.Format("select department_id FROM employeeDB.dbo.employee where id={0} ", managerId);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                departmentId = int.Parse(reader["department_id"].ToString());
            }
            connection.Close();

            if(departmentId == 0)
            {
                MessageBox.Show("ERROR: Can't get department id");
                return table;
            }

            connection.Open();
            string query = String.Format("SELECT e.id, e.name, FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.net_salary as salary, p.name as position " +
                "FROM employeeDB.dbo.employee e left join employeeDB.dbo.department d on e.department_id = d.id " +
                "left join employeeDB.dbo.salary s on e.salary_id = s.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id " +
                "where e.department_id = {0} and e.position_id={1}", departmentId, 1);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
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
                List<int> listAccountId = new List<int>();
                string sql = string.Format("select * from employeeDB.dbo.account where employee_id={0}", employeeId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listAccountId.Add(rdr.GetInt32(0));
                }
                connection.Close();

                connection.Open();
                foreach (int accountId in listAccountId)
                {
                    sql = string.Format("update employeeDB.dbo.account set employee_id = NULL where id={0}", accountId);
                    SqlCommand cmd1 = new SqlCommand(sql, connection);
                    cmd1.ExecuteReader();
                }
                connection.Close();

                connection.Open();
                sql = string.Format("delete from employeeDB.dbo.employee_project where employee_id = {0}", employeeId);
                SqlCommand cmd3 = new SqlCommand(sql, connection);
                cmd3.ExecuteReader();
                connection.Close();

                connection.Open();
                sql = string.Format("DELETE FROM employeeDB.dbo.employee WHERE id = {0};", employeeId);
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


        public bool addEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from employeeDB.dbo.employee where department_id = {0}", employee.DepartmentId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["position_id"].Equals(3) && employee.PositionId.Equals(3))
                    {
                        MessageBox.Show("This department already has manager");
                        return false;
                    }
                }
                connection.Close();


                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.employee(name, phone,gender,home_town, department_id, salary_id, position_id) VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})"
                   , employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.DepartmentId, employee.SalaryId, employee.PositionId);
                SqlCommand cmd1 = new SqlCommand(SQL, connection);
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

        public bool addEmployeeByManager(Employee employee)
        {
            try
            {
                connection.Open();
                string SQL = string.Format("insert into employeeDB.dbo.employee(name, phone,gender,home_town, department_id, salary_id, position_id) VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})"
                   , employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.DepartmentId, employee.SalaryId, employee.PositionId);
                SqlCommand cmd1 = new SqlCommand(SQL, connection);
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
        public int getDepartmentIdByManagerId(int managerId)
        {
            int departmentId = 0;

            connection.Open();
            string sql = String.Format("select department_id FROM employeeDB.dbo.employee where id={0} ", managerId);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                departmentId = int.Parse(reader["department_id"].ToString());
            }
            connection.Close();
            return departmentId;
        }
        public Department GetDepartmentDataByManagerId(int managerid)
        {

            Department department = new Department();
            int departmentId = getDepartmentIdByManagerId(managerid);

            connection.Open();
            string sql = string.Format("select * FROM employeeDB.dbo.department where id={0}", departmentId);
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string name = reader["name"].ToString();
                string phone = reader["phone"].ToString();
                string address = reader["address"].ToString();
                department = new Department(departmentId, name, phone, address);
            }
            connection.Close();

            return department;
        }
        public bool updateEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from employeeDB.dbo.employee where department_id = {0}", employee.DepartmentId);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["position_id"].Equals(3) && employee.PositionId.Equals(3))
                    {
                        if (!reader["id"].Equals(employee.Id))
                        {
                            MessageBox.Show("This department already has manager");
                            return false;
                        }
                        
                    }
                }
                connection.Close();

                connection.Open();
                sql = string.Format("update employeeDB.dbo.employee set name = '{0}', phone = '{1}', gender = '{2}', home_town = '{3}'," +
                    " department_id = '{4}', salary_id = '{5}', position_id = '{6}'  where id = {7}"
                    , employee.Name, employee.Phone, employee.Gender, employee.HomeTown, employee.DepartmentId, employee.SalaryId, employee.PositionId, employee.Id);
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



        //Chỉnh sửa thông tin nhân viên
        public Boolean updateInforEmployee(Employee e)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update employeeDB.dbo.employee set name ='{0}',phone={1},gender={2},home_town='{3}' where id={4}", e.Name, e.Phone, e.Gender, e.HomeTown, e.Id);
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

        // Lấy thông tin employee chưa có account
        public DataTable getEmployeeNeedAssignData()
        {
            DataTable table = new DataTable();
            string query = "SELECT e.id, e.name,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id WHERE e.id NOT IN (SELECT employee_id FROM employeeDB.dbo.account WHERE employee_id IS NOT NULL)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Lấy thông tin employee chưa có account mà trong department đó
        public DataTable getEmployeeNeedAssignDataInDepartment(int deId)
        {
            DataTable table = new DataTable();
            string query =string.Format("SELECT e.id, e.name,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 " +
                "then 'Male' else 'Female' end as gender, e.home_town, d.name as department, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id WHERE e.department_id ={0} and e.id NOT IN (SELECT employee_id " +
                "FROM employeeDB.dbo.account WHERE employee_id IS NOT NULL)",deId);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Xử lý search thông tin employee chưa có account
        public DataTable searchEmployeeNeedAssignData(string condition,int value)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT e.id, e.name,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id WHERE e.{0}={1} and e.id NOT IN (SELECT employee_id FROM employeeDB.dbo.account WHERE employee_id IS NOT NULL)", condition,value);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Xử lý search thông tin employee chưa có account trong department
        public DataTable searchEmployeeNeedAssignDataInDepartment(string condition, int value,int deId)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT e.id, e.name,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 " +
                "then 'Male' else 'Female' end as gender, e.home_town, d.name as department, p.name as position " +
                "FROM employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id WHERE e.department_id={2} and e.{0}={1} and e.id NOT IN (SELECT employee_id " +
                "FROM employeeDB.dbo.account WHERE employee_id IS NOT NULL)", condition, value,deId);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        //Lấy Position bang id
        public Position getPositionValue(int id) {
            Position p = null;

            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.position WHERE id = {0}", id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    p = new Position();
                    p.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    p.Name = reader.GetString(reader.GetOrdinal("name"));
                    p.Description = reader.GetString(reader.GetOrdinal("description"));
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

        //Lấy Position bằng name
        public Position getPositionValueByName(string name)
        {
            Position p = null;

            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.position WHERE name = '{0}'", name);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    p = new Position();
                    p.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    p.Name = reader.GetString(reader.GetOrdinal("name"));
                    p.Description = reader.GetString(reader.GetOrdinal("description"));
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

        //Lấy danh sách các employee bên trong deparment
        public List<int> getEmployeesInDepartment(int deid)
        {
            List<int> list= new List<int>();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.employee WHERE department_id = '{0}'", deid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int empId = reader.GetInt32(reader.GetOrdinal("id"));
                    list.Add(empId);
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

        //Lấy danh sách các employee bên trong employeeproject
        public List<int> getEmployeesInEmployeeProject(int proid)
        {
            List<int> list = new List<int>();
            try
            {
                connection.Open();
                string sql = string.Format("SELECT * FROM employeeDB.dbo.employee_project WHERE project_id = '{0}'", proid);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int empId = reader.GetInt32(reader.GetOrdinal("employee_id"));
                    list.Add(empId);
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

        // Lấy tất cả các employee làm việc trong department
        public DataTable GetEmployeeDataInDeparment(int deId)
        {
            DataTable table = new DataTable();
            string query =string.Format("select e.id as EmployeeId,e.name as EmployeeName,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS Phone " +
               ",case when e.gender = 0 then 'Male' else 'Female' end as Gender,e.home_town as HomeTown,d.name as DepartmentName" +
               ",p.name as Position from employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
               "inner join employeeDB.dbo.position p on p.id=e.position_id where e.department_id={0} ORDER BY CASE p.name WHEN 'Admin' THEN 1 WHEN 'Manage' " +
               "THEN 2 WHEN 'Employee' THEN 3 ELSE 4 END", deId);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Search các employee làm việc trong department bằng các condition chính xác
        public DataTable searchEmployeeDataInDeparmentByConditionId(int deId,string condition,string value)
        {
            DataTable table = new DataTable();
            string query = string.Format("select e.id as EmployeeId,e.name as EmployeeName,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS Phone " +
               ",case when e.gender = 0 then 'Male' else 'Female' end as Gender,e.home_town as HomeTown,d.name as DepartmentName,p.name as Position " +
               "from employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
               "inner join employeeDB.dbo.position p on p.id=e.position_id where e.department_id={0} and {1}='{2}' ORDER BY CASE p.name WHEN 'Admin' " +
               "THEN 1 WHEN 'Manage' THEN 2 WHEN 'Employee' THEN 3 ELSE 4 END", deId, condition, value);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        // Search các employee làm việc trong department bằng các condition mơ hồ
        public DataTable searchEmployeeDataInDeparmentByConditionElse(int deId, string condition, string value)
        {
            DataTable table = new DataTable();
            string query = string.Format("select e.id as EmployeeId,e.name as EmployeeName,FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS Phone " +
               ",case when e.gender = 0 then 'Male' else 'Female' end as Gender,e.home_town as HomeTown,d.name as DepartmentName,p.name as Position " +
                "from employeeDB.dbo.employee e inner join employeeDB.dbo.department d on e.department_id = d.id " +
                "inner join employeeDB.dbo.position p on p.id=e.position_id where e.department_id={0} and {1} like '%{2}%' ORDER BY CASE p.name " +
                "WHEN 'Admin' THEN 1 WHEN 'Manage' THEN 2 WHEN 'Employee' THEN 3 ELSE 4 END", deId, condition, value);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        //find by id
        public DataTable findById(int id,string condition)
        {
            DataTable table = new DataTable();
            string query =string.Format("SELECT e.id, e.name, FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.net_salary as salary, p.name as position " +
                "FROM employeeDB.dbo.employee e left join employeeDB.dbo.department d on e.department_id = d.id " +
                "left join employeeDB.dbo.salary s on e.salary_id = s.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id where {0}={1}",condition,id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        //find by condition
        public DataTable findByCondition(string value, string condition)
        {
            DataTable table = new DataTable();
            string query = string.Format("SELECT e.id, e.name, FORMAT(CAST(e.phone AS BIGINT), '00000000000') AS phone, case when e.gender = 0 then 'Male' else 'Female' end as gender, e.home_town, d.name as department, s.net_salary as salary, p.name as position " +
                "FROM employeeDB.dbo.employee e left join employeeDB.dbo.department d on e.department_id = d.id " +
                "left join employeeDB.dbo.salary s on e.salary_id = s.id " +
                "inner join employeeDB.dbo.position p on e.position_id = p.id where {0} like '%{1}%'", condition, value);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
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
