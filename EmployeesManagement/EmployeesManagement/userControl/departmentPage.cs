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
            departmentController.Search(cbSearch, tbSearch, dgvDepartment);
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == -1)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = departmentController.GetDepartmentData();

            dgvDepartment.DataSource = dataTable;
        }
    }
}
