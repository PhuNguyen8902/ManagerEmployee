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

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class projectEmployeePage : UserControl
    {
        private int id;
        private projectController projectController;
        private salaryController salaryController;
        SqlConnection connection = Connection.Connection.GetConnection();
        public projectEmployeePage()
        {
            InitializeComponent();
        }

        public projectEmployeePage(int id)
        {
            projectController = new projectController();
            salaryController = new salaryController();
            InitializeComponent();
            this.id = id;
        }

        private void projectEmployeePage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = projectController.GetProjectEmployeeData(id);

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

        private void loadComboBoxSearch()
        {
            List<String> strList = new List<String>();
            strList.Add("Project Id");
            strList.Add("Project Name");
            strList.Add("Project Description");
            strList.Add("Start_date");
            strList.Add("End_date");
            strList.Add("Active");
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
                if (value == "Start_date" || value == "End_date")
                {
                    txtSearch.Visible = false;
                    cbSearchActive.Visible = false;
                    DTPSearch.Visible = true;
                }
                else if (value == "Active")
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
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "Project Id")
            {
                int projectId;
                if (!int.TryParse(txtSearch.Text, out projectId))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = projectController.findEmployeeProjectByProjectId(projectId, id);
                    dgvProject.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Project Name")
            {
                string strName = txtSearch.Text;
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strName, id, "p.name");
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "Project Description")
            {
                string strDescription = txtSearch.Text;
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strDescription, id, "ep.description");
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "Start_date")
            {
                string strStartDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strStartDate, id, "ep.start_date");
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "End_date")
            {
                string strEndDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strEndDate, id, "ep.end_date");
                dgvProject.DataSource = dataTable;
            }
            else
            {
                string strActive = cbSearchActive.SelectedItem.ToString();
                string Active = "0";
                if (strActive == "Active")
                    Active = "0";
                else
                    Active = "1";
                DataTable dataTable = projectController.findEmployeeProjectByCodition(Active, id, "p.is_active");
                dgvProject.DataSource = dataTable;
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {

            DataTable dataTable = projectController.GetProjectEmployeeData(id);

            dgvProject.DataSource = dataTable;
        }
    }
}
