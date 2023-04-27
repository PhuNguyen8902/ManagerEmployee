using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.userControl.Admin.Detail.projectDetail;
using EmployeesManagement.userControl.Detail.departmentDetail;
using EmployeesManagement.userControl.Detail.projectDetail;
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
    public partial class projectsPage : UserControl
    {
        int isActive = 0;
        private projectController projectController;
        private salaryController salaryController;
        private departmentController departmentController;
        private employeeController empController;
        private notifyController notify;
        SqlConnection connection = Connection.Connection.GetConnection();

        public projectsPage()
        {
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
            empController = new employeeController();
            notify = new notifyController();
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

            DataTable dataTable = projectController.GetProjectData(isActive);

            dgvProject.DataSource = dataTable;

            connection.Close();
            loadComboBoxSearch();
            loadComboBoxSearchActive();
            btnSearch.Enabled = false;

            if (dgvProject.Columns.Contains("is_active"))
            {
                for (int i = 0; i < dgvProject.Rows.Count; i++)
                {
                    if (dgvProject.Rows[i].Cells["is_active"].Value != null && dgvProject.Rows[i].Cells["is_active"].Value is bool)
                    {
                        bool isActive = (bool)dgvProject.Rows[i].Cells["is_active"].Value;
                        dgvProject.Rows[i].Cells["is_active"].Value = isActive ? "Active" : "End";
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

                bool isBoolActive = true;
                if (isActive == 1)
                    isBoolActive = false;

                updateProjectDetail formUpdateProject = new updateProjectDetail(id, name, desciption, startDate, endDate, isBoolActive);
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
                List<int> empList = empController.getEmployeesInEmployeeProject(id);


                if (projectController.deleteProject(id))
                {
                    MessageBox.Show("Delete Success");
                    foreach (int empId in empList)
                    {
                        DateTime now = DateTime.Now;
                        string message = string.Format("Admin has delete the Project you are working with ({0})", now.ToString());
                        notify.addNotify(empId, message);

                    }
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            form.Close();
                            primary primaryPage = new primary(1);
                            primaryPage.Show();
                            return;
                        }
                    }

                    dgvProject.DataSource = projectController.GetProjectData(isActive);

                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }

            }
            else
            {
                MessageBox.Show("Choose project want to delete");
            }
        }

        private void loadComboBoxSearch()
        {
            List<String> strList = new List<String>();
            strList.Add("id");
            strList.Add("name");
            strList.Add("description");
            strList.Add("start_date");
            strList.Add("end_date");
            //strList.Add("is_active");
            salaryController.loadComboBoxSearch(cbSearch, strList);
        }
        private void loadComboBoxSearchActive()
        {
            cbSearchActive.Items.Add("Active");
            cbSearchActive.Items.Add("End");
            cbSearchActive.SelectedIndex = 0;
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
                string value = cbSearch.SelectedItem.ToString();
                if (value == "start_date" || value == "end_date")
                {
                    txtSearch.Visible = false;
                    cbSearchActive.Visible = false;
                    DTPSearch.Visible = true;
                }
                else if (value == "is_active")
                {
                    txtSearch.Visible = false;
                    cbSearchActive.Visible = true;
                    DTPSearch.Visible = false;
                }
                else
                {
                    txtSearch.Visible = true;
                    cbSearchActive.Visible = false;
                    DTPSearch.Visible = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = "employeeDB.dbo.project";
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "id")
            {
                int id;
                if (!int.TryParse(txtSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = projectController.findById(id, str);
                    dgvProject.DataSource = dataTable;
                }
            }
            else if (selectedValue == "name")
            {
                string strName = txtSearch.Text;
                DataTable dataTable = projectController.findByCodition(strName, str, selectedValue);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "description")
            {
                string strDescription = txtSearch.Text;
                DataTable dataTable = projectController.findByCodition(strDescription, str, selectedValue);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "start_date")
            {
                string strStartDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findByCodition(strStartDate, str, selectedValue);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "end_date")
            {
                string strEndDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findByCodition(strEndDate, str, selectedValue);
                dgvProject.DataSource = dataTable;
            }
            else
            {
                if (cbSearchActive.SelectedIndex != -1)
                {
                    string strActive = cbSearchActive.SelectedItem.ToString();
                    string Active = "0";
                    if (strActive == "Active")
                        Active = "0";
                    else
                        Active = "1";
                    DataTable dataTable = projectController.findByCodition(Active, str, selectedValue);
                    dgvProject.DataSource = dataTable;
                }
            }

        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = projectController.GetProjectData(isActive);

            dgvProject.DataSource = dataTable;
        }

        private void btnActiveProject_Click(object sender, EventArgs e)
        {
            isActive = 0;
            DataTable dataTable = projectController.GetProjectData(isActive);

            dgvProject.DataSource = dataTable;
        }
        private void btnEndProject_Click(object sender, EventArgs e)
        {
            isActive = 1;
            DataTable dataTable = projectController.GetProjectData(isActive);

            dgvProject.DataSource = dataTable;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProject.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string desciption = row.Cells[2].Value.ToString();
                string startDate = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("yyyy-MM-dd");
                string endDate = DateTime.Parse(row.Cells[4].Value.ToString()).ToString("yyyy-MM-dd");

                bool active = true;
                if (isActive == 0)
                    active = false;

                projectDetail formDetail = new projectDetail(id, name, desciption, startDate, endDate, active);
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose project to continue this action");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvProject.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvProject.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dgvProject.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dgvProject.Rows.Count + 1; i++)
                {
                    for (int j = 1; j < dgvProject.Columns.Count + 1; j++)
                    {
                        excel.Cells[i + 1, j] = dgvProject.Rows[i - 1].Cells[j - 1].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }
    }
}
