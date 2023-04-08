using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl.Detail.employeeDetail;
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
using System.Xml.Linq;

namespace EmployeesManagement.userControl
{
    public partial class employeesPage : UserControl
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        private Employee employeeModel;
        private EmployeeService employeeService;
        private employeeController employeeController;
        public employeesPage()
        {
            InitializeComponent();
            employeeModel = new Employee();
            employeeService = new EmployeeService();
            employeeController = new employeeController();
            employeesPage_Load();
        }

        private void employeesPage_Load()
        {
            employeeService.OpenConnection();

            DataTable dataTable = employeeController.getEmployee();

            dgvEmployee.DataSource = dataTable;

            int countRow = dgvEmployee.RowCount;
            for(int i = 0; i < countRow - 1; i++)
            {
                

            }
            //// Tạo một cột mới chứa nút Xóa
            //DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            //deleteButtonColumn.HeaderText = "Delete";
            //deleteButtonColumn.Name = "deleteButtonColumn";
            //deleteButtonColumn.Text = "Delete";
            //deleteButtonColumn.UseColumnTextForButtonValue = true;

            //// Thêm cột mới vào DataGridView
            //dgvEmployee.Columns.Add(deleteButtonColumn);


            employeeService.CloseConnection();
        }

        //private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    employeeService.OpenConnection();

        //    // Kiểm tra xem nút Xóa đã được nhấp vào chưa
        //    if (e.ColumnIndex == dgvEmployee.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
        //    {
        //        // Lấy ID của nhân viên được chọn để xóa
        //        int employeeId = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["id"].Value);

        //        // Thực hiện hành động xóa trong cơ sở dữ liệu
        //        employeeService.deleteEmployee(employeeId);

        //        // Cập nhật lại DataGridView để hiển thị dữ liệu mới nhất
        //        MessageBox.Show("Xóa thành công");
        //        dgvEmployee.DataSource = employeeService.GetEmployeeData();
        //    }
        //    employeeService.CloseConnection();

        //}
        
      

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployeeDetail formAddEmployee = new addEmployeeDetail();
            formAddEmployee.ShowDialog();
       
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (employeeController.deleteEmployee(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvEmployee.DataSource = employeeController.getEmployee();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string phone = row.Cells[2].Value.ToString();
                byte gender = Byte.Parse(row.Cells[3].Value.ToString());
                string hometown = row.Cells[4].Value.ToString();

                updateEmployeeDetail formUpdateEmployee = new updateEmployeeDetail(id, name, phone, gender, hometown);
                formUpdateEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose employee to update");
            }
        }
    }
}
