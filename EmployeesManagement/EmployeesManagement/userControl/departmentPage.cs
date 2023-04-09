using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl.Detail.departmentDetail;
using EmployeesManagement.userControl.Detail.employeeDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl
{
    public partial class DepartmentPage : UserControl
    {
        private departmentController departmentController;
        private salaryController salaryController;



        SqlConnection connection = Connection.Connection.GetConnection();

        public DepartmentPage()
        {
            departmentController = new departmentController();
            salaryController = new salaryController();
            InitializeComponent();
        }

        private void DepartmentPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = departmentController.GetDepartmentData();

            dgvDepartment.DataSource = dataTable;

            int countRow = dgvDepartment.RowCount;
            for (int i = 0; i < countRow - 1; i++)
            {


            }
            connection.Close();
            List<String> strList = new List<String>();
            strList.Add("id");
            strList.Add("name");
            strList.Add("phone");
            strList.Add("address");
            salaryController.loadComboBoxSearch(cbSearch, strList);
            btnSearch.Enabled = false;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addDepartmentDetail formAddDepartment = new addDepartmentDetail();
            formAddDepartment.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDepartment.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string phone = row.Cells[2].Value.ToString();
                string address = row.Cells[3].Value.ToString();

                updateDepartmentDetail formUpdateDepartment = new updateDepartmentDetail(id, name, phone, address);
                formUpdateDepartment.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose department to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDepartment.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (departmentController.deleteDepartment(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDepartment.DataSource = departmentController.GetDepartmentData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = "employeeDB.dbo.department";
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "id")
            {
                //int id = Convert.ToInt32(tbSearch.Text);
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho ID!");
                    return;
                }

                DataTable dataTable = departmentController.findById(id, str);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = departmentController.findByName(name, str);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "phone")
            {
                int phone;
                if (!int.TryParse(tbSearch.Text, out phone))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho phone!");
                    return;
                }
                DataTable dataTable = departmentController.findByPhone(phone, str);
                dgvDepartment.DataSource = dataTable;
            }
            else if (selectedValue == "address")
            {
                string address = tbSearch.Text;
                DataTable dataTable = departmentController.findByAddress(address, str);
                dgvDepartment.DataSource = dataTable;
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == -1)
            {
                // Không có mục nào được chọn
                btnSearch.Enabled = false;
            }
            else
            {
                // Có mục được chọn
                btnSearch.Enabled = true;
            }
        }
    }
}
