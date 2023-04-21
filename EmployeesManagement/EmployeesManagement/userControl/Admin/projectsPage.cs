﻿using EmployeesManagement.Control;
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
        SqlConnection connection = Connection.Connection.GetConnection();

        public projectsPage()
        {
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
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
                bool isActive = false;
                string Active = row.Cells[5].Value.ToString();

                if (Active == "Active")
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
                    MessageBox.Show("Delete Success");
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
            projectController.Search(cbSearch, txtSearch, cbSearchActive, DTPSearch, dgvProject);

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
                projectDetail formDetail = new projectDetail();
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose project to continue this action");
            }
        }

    }
}
