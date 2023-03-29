using EmployeesManagement.Models;
using EmployeesManagement.Service;
using Google.Protobuf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl
{
    public partial class employeesPage : UserControl
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        private Employee employeeModel;
        private EmployeeService employeeService;

        public employeesPage()
        {
            InitializeComponent();
            employeeModel = new Employee();
            employeeService = new EmployeeService();
        }

        private void employeesPage_Load(object sender, EventArgs e)
        {
            employeeService.OpenConnection();

            DataTable dataTable = employeeService.GetEmployeeData();

            dgvEmployee.DataSource = dataTable;
            // Tạo một cột mới chứa nút Xóa
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột mới vào DataGridView
            dgvEmployee.Columns.Add(deleteButtonColumn);


            employeeService.CloseConnection();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeService.OpenConnection();

            // Kiểm tra xem nút Xóa đã được nhấp vào chưa
            if (e.ColumnIndex == dgvEmployee.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Lấy ID của nhân viên được chọn để xóa
                int employeeId = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["id"].Value);

                // Thực hiện hành động xóa trong cơ sở dữ liệu
                employeeService.DeleteEmployee(employeeId);

                // Cập nhật lại DataGridView để hiển thị dữ liệu mới nhất
                MessageBox.Show("Xóa thành công");
                dgvEmployee.DataSource = employeeService.GetEmployeeData();
            }
            employeeService.CloseConnection();

        }
        /*
        private void addEmployee(object sender, DataGridViewRowsAddedEventArgs e)
        {
            employeeService.OpenConnection();

            try
            {
                //employeeService.OpenConnection();

                // Kết nối cơ sở dữ liệu
                // Lấy giá trị từ DataGridView
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                string? value1 = row.Cells[1].Value?.ToString();
                string? value2 = row.Cells[2].Value?.ToString();
                string? value3 = row.Cells[3].Value?.ToString();
                string? value4 = row.Cells[4].Value?.ToString();
                string? value5 = row.Cells[5].Value?.ToString();

                // Thực hiện truy vấn SQL để chèn dữ liệu vào cơ sở dữ liệu
                string sql = "INSERT INTO employeeDB.dbo.employee (name, phone, birth_day,gender,home_town) VALUES (@Value1, @Value2, @Value3,@Value4,@Value5)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Value1", value1);
                    command.Parameters.AddWithValue("@Value2", value2);
                    command.Parameters.AddWithValue("@Value3", value3);
                    command.Parameters.AddWithValue("@Value4", value4);
                    command.Parameters.AddWithValue("@Value5", value5);
                    command.ExecuteNonQuery();
                }
                //employeeService.CloseConnection();

            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
            }
            employeeService.CloseConnection();
        }
        */

        private void addBtn_Click(object sender, EventArgs e)
        {
            //employeeService.OpenConnection();
            SqlConnection connection = Connection.Connection.GetConnection();
            connection.Open();
            try
            {
                //employeeService.OpenConnection();

                // Kết nối cơ sở dữ liệu
                // Lấy giá trị từ DataGridView
                DataGridViewRow row = dgvEmployee.CurrentRow;
                string? value1 = row.Cells[2].Value?.ToString();
                //int? value2 = int.Parse((string)row.Cells[2].Value);
                string? value2 = row.Cells[3].Value?.ToString();
                //int? value4 = int.Parse((string)row.Cells[4].Value);
                string? value3 = row.Cells[4].Value?.ToString();
                string? value4 = row.Cells[5].Value?.ToString();

                // Thực hiện truy vấn SQL để chèn dữ liệu vào cơ sở dữ liệu
                string sql = "INSERT INTO employeeDB.dbo.employee (name, phone,gender,home_town) VALUES (@Value1, @Value2, @Value3,@Value4)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Value1", value1);
                    command.Parameters.AddWithValue("@Value2", value2);
                    command.Parameters.AddWithValue("@Value3", value3);
                    command.Parameters.AddWithValue("@Value4", value4);
                    command.ExecuteNonQuery();
                }
                //employeeService.CloseConnection();
                // Cập nhật lại DataGridView để hiển thị dữ liệu mới nhất
                MessageBox.Show("Chỉnh sửa thành công");
                dgvEmployee.DataSource = employeeService.GetEmployeeData();

            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
            }
            //employeeService.CloseConnection();
            connection.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.Connection.GetConnection();
            connection.Open();
            try
            {
                //employeeService.OpenConnection();

                // Kết nối cơ sở dữ liệu
                // Lấy giá trị từ DataGridView
                DataGridViewRow row = dgvEmployee.CurrentRow;
                string? value0 = row.Cells[1].Value?.ToString();
                string? value1 = row.Cells[2].Value?.ToString();
                //int? value2 = int.Parse((string)row.Cells[2].Value);
                string? value2 = row.Cells[3].Value?.ToString();
                //int? value4 = int.Parse((string)row.Cells[4].Value);
                string? value3 = row.Cells[4].Value?.ToString();
                string? value4 = row.Cells[5].Value?.ToString();

                // Thực hiện truy vấn SQL để chèn dữ liệu vào cơ sở dữ liệu
                //string sql = "INSERT INTO employeeDB.dbo.employee (name, phone,gender,home_town) VALUES (@Value1, @Value2, @Value3,@Value4)";
                string sql = "UPDATE employeeDB.dbo.employee SET name = @Value1, phone = @Value2 , gender = @Value3 , home_town = @Value4 WHERE id = @Value0";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Value0", value0);
                    command.Parameters.AddWithValue("@Value1", value1);
                    command.Parameters.AddWithValue("@Value2", value2);
                    command.Parameters.AddWithValue("@Value3", value3);
                    command.Parameters.AddWithValue("@Value4", value4);
                    command.ExecuteNonQuery();
                }
                //employeeService.CloseConnection();
                // Cập nhật lại DataGridView để hiển thị dữ liệu mới nhất
                MessageBox.Show("Chỉnh sửa thành công");
                dgvEmployee.DataSource = employeeService.GetEmployeeData();

            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
            }
            //employeeService.CloseConnection();
            connection.Close();
        }
    }
}
