using EmployeesManagement.Control;
using EmployeesManagement.userControl.Detail.departmentDetail;
using EmployeesManagement.userControl.Detail.salaryDetail;
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
    public partial class salaryPage : UserControl
    {
        private salaryController salaryController;
        private departmentController departmentController;


        SqlConnection connection = Connection.Connection.GetConnection();
        public salaryPage()
        {
            salaryController = new salaryController();
            departmentController = new departmentController();

            InitializeComponent();
        }

        private void salaryPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = salaryController.GetSalaryData();

            dgvSalary.DataSource = dataTable;

            int countRow = dgvSalary.RowCount;
            for (int i = 0; i < countRow - 1; i++)
            {


            }
            connection.Close();
            List<String> strList = new List<String>();
            strList.Add("id");
            strList.Add("coefficient");
            strList.Add("level");
            strList.Add("allowance");
            strList.Add("net_salary");
            salaryController.loadComboBoxSearch(cbSearch, strList);
            btnSearch.Enabled = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addSalaryDetail formAddSalary = new addSalaryDetail();
            formAddSalary.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSalary.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                int level = Int32.Parse(row.Cells[2].Value.ToString());
                int allow = Int32.Parse(row.Cells[3].Value.ToString());
                updateSalaryDetail formUpdateSalary = new updateSalaryDetail(id, level, allow);
                formUpdateSalary.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose department to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSalary.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (salaryController.deleteSalary(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvSalary.DataSource = salaryController.GetSalaryData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string str = "employeeDB.dbo.salary";
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

                DataTable dataTable = salaryController.findById(id, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "coefficient")
            {
                int coefficient;
                if (!int.TryParse(tbSearch.Text, out coefficient))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho Coefficient!");
                    return;
                }
                DataTable dataTable = salaryController.findByCoefficient(coefficient, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "level")
            {
                string level = tbSearch.Text;
                DataTable dataTable = salaryController.findByLevel(level, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "allowance")
            {
                int allowance;
                if (!int.TryParse(tbSearch.Text, out allowance))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho Allowance!");
                    return;
                }
                DataTable dataTable = salaryController.findByAllowance(allowance, str);
                dgvSalary.DataSource = dataTable;
            }
            else if (selectedValue == "net_salary")
            {
                int net_salary;
                if (!int.TryParse(tbSearch.Text, out net_salary))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên cho Net_salary!");
                    return;
                }
                DataTable dataTable = salaryController.findByNetSalary(net_salary, str);
                dgvSalary.DataSource = dataTable;
            }
        }
    }
}
