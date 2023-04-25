using EmployeesManagement.Control;
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

namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    public partial class sendMailDepartmentDetail : Form
    {
        private departmentController departmentController;
        private salaryController salaryController;
        SqlConnection connection = Connection.Connection.GetConnection();

        public sendMailDepartmentDetail()
        {
            InitializeComponent();
            departmentController = new departmentController();
            salaryController = new salaryController();

        }

        private void sendMailDepartmentDetail_Load(object sender, EventArgs e)
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
            dgvDepartment.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "ChooseButton",
                Text = "Choose",
                UseColumnTextForButtonValue = true
            });
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = "employeeDB.dbo.department";
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = departmentController.findById(id, str);
                    dgvDepartment.DataSource = dataTable;
                }
            }
            else if (selectedValue == "phone")
            {
                long phone;
                if (!long.TryParse(tbSearch.Text, out phone))
                {
                    MessageBox.Show("Please enter a number for the Phone!");
                    return;
                }
                else
                {
                    string strPhone = phone.ToString();
                    DataTable dataTable = departmentController.findByCodition(strPhone, str, selectedValue);
                    dgvDepartment.DataSource = dataTable;
                }
            }
            else
            {
                string strValue = tbSearch.Text;
                DataTable dataTable = departmentController.findByCodition(strValue, str, selectedValue);
                dgvDepartment.DataSource = dataTable;
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = departmentController.GetDepartmentData();

            dgvDepartment.DataSource = dataTable;
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartment.Columns[e.ColumnIndex].Name == "ChooseButton")
            {
                int deId = (int)dgvDepartment.Rows[e.RowIndex].Cells["id"].Value;
                string deName = dgvDepartment.Rows[e.RowIndex].Cells["name"].Value.ToString();

                chooseSend formChoose = new chooseSend(deId, deName);
                this.Close();
                formChoose.ShowDialog();
            }
        }
    }
}
