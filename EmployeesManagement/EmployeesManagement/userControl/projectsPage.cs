using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.userControl.Detail.departmentDetail;
using EmployeesManagement.userControl.Detail.projectDetail;
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
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("Windows-1252");
            connection.Open();

            DataTable dataTable = projectController.GetProjectData();

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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProject.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string desciption = row.Cells[2].Value.ToString();
                string startDate = row.Cells[3].Value.ToString();
                string endDate = row.Cells[4].Value.ToString();
                bool isActive = false;
                string Active = row.Cells[5].Value.ToString();

                if (Active == "Đang ho?t đ?ng")
                    isActive = true;
                else isActive = false;
                updateProjectDetail formUpdateProject = new updateProjectDetail(id, name, desciption, startDate, endDate, isActive);
                formUpdateProject.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose project to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProject.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (projectController.deleteProject(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvProject.DataSource = projectController.GetProjectData();
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
    }
}
