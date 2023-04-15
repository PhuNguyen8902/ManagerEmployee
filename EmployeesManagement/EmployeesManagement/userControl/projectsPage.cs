using EmployeesManagement.Control;
using EmployeesManagement.Detail;
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
    public partial class projectsPage : UserControl
    {
        private projectController projectController;
        SqlConnection connection = Connection.Connection.GetConnection();

        public projectsPage()
        {
            projectController = new projectController();
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addProjectDetail formAddDetail = new addProjectDetail();
            formAddDetail.ShowDialog();
        }

        private void projectsPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = projectController.GetDepartmentData();

            dgvProject.DataSource = dataTable;

            connection.Close();
            List<String> strList = new List<String>();
            strList.Add("id");
            strList.Add("name");
            strList.Add("description");
            strList.Add("start_date");
            strList.Add("end_date");
            strList.Add("is_active");
            if (dgvProject.Columns.Contains("is_active"))
            {
                for (int i = 0; i < dgvProject.Rows.Count; i++)
                {
                    if (dgvProject.Rows[i].Cells["is_active"].Value != null && dgvProject.Rows[i].Cells["is_active"].Value is bool)
                    {
                        bool isActive = (bool)dgvProject.Rows[i].Cells["is_active"].Value;
                        dgvProject.Rows[i].Cells["is_active"].Value = isActive ? "Đang hoạt động" : "Đã kết thúc";
                    }
                }
            }

            //salaryController.loadComboBoxSearch(cbSearch, strList);
            //btnSearch.Enabled = false;
        }
    }
}
