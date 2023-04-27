﻿using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.userControl.Admin.Detail.projectDetail;
using EmployeesManagement.userControl.UserControlManager.Detail.projectPage;
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

namespace EmployeesManagement.userControl.UserControlManager
{
    public partial class projectPage : UserControl
    {
        private int managerId;
        private string type;
        int isActive = 0;
        private projectController projectController;
        private salaryController salaryController;
        private departmentController departmentController;
        private employeeController empController;
        private notifyController notify;
        SqlConnection connection = Connection.Connection.GetConnection();
        public projectPage()
        {
            InitializeComponent();
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
            empController = new employeeController();
            notify = new notifyController();
        }
        public projectPage(int managerId, string type)
        {

            InitializeComponent();
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
            empController = new employeeController();
            notify = new notifyController();
            this.managerId = managerId;
            this.type = type;
        }

        private void projectPage_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = projectController.GetProjectEmployeeData(managerId, isActive);

            dgvProject.DataSource = dataTable;
            connection.Close();
            dgvProject.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "NotifyButton",
                Text = "Notify",
                UseColumnTextForButtonValue = true
            });

            loadComboBoxSearch();
            btnSearch.Enabled = false;

        }
        private void loadComboBoxSearch()
        {
            List<String> strList = new List<String>();
            strList.Add("Project Id");
            strList.Add("Project Name");
            strList.Add("Project Description");
            strList.Add("Start_date");
            strList.Add("End_date");
            //strList.Add("is_active");
            salaryController.loadComboBoxSearch(cbSearch, strList);
        }

        private void btnActiveProject_Click(object sender, EventArgs e)
        {
            dgvProject.Columns.Clear();
            isActive = 0;
            connection.Open();

            DataTable dataTable = projectController.GetProjectEmployeeData(managerId, isActive);

            dgvProject.DataSource = dataTable;
            dgvProject.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "NotifyButton",
                Text = "Notify",
                UseColumnTextForButtonValue = true
            });

            connection.Close();
        }

        private void btnEndProject_Click(object sender, EventArgs e)
        {
            dgvProject.Columns.Clear();
            isActive = 1;
            connection.Open();

            DataTable dataTable = projectController.GetProjectEmployeeData(managerId, isActive);

            dgvProject.DataSource = dataTable;

            connection.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProject.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string desciption = row.Cells[2].Value.ToString();
                string startDate = row.Cells[3].Value.ToString();
                string endDate = row.Cells[4].Value.ToString();

                bool active = true;

                if (isActive == 0)
                    active = false;

                projectEmployeeDetail formDetail = new projectEmployeeDetail(id, name, desciption, startDate, endDate, active);
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

        private void cbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    DTPSearch.Visible = true;
                }
                {
                    txtSearch.Visible = true;
                    DTPSearch.Visible = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvProject.Columns.Clear();

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
                    DataTable dataTable = projectController.findEmployeeProjectByProjectId(projectId, managerId, isActive);
                    dgvProject.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Project Name")
            {
                string strName = txtSearch.Text;
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strName, managerId, "p.name", isActive);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "Project Description")
            {
                string strDescription = txtSearch.Text;
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strDescription, managerId, "ep.description", isActive);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "Start_date")
            {
                string strStartDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strStartDate, managerId, "ep.start_date", isActive);
                dgvProject.DataSource = dataTable;
            }
            else if (selectedValue == "End_date")
            {
                string strEndDate = DTPSearch.Value.ToString("yyyy-MM-dd");
                DataTable dataTable = projectController.findEmployeeProjectByCodition(strEndDate, managerId, "ep.end_date", isActive);
                dgvProject.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("ERR...");
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = projectController.GetProjectEmployeeData(managerId, isActive);

            dgvProject.DataSource = dataTable;
        }

        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProject.Columns[e.ColumnIndex].Name == "NotifyButton")
            {
                int proId = (int)dgvProject.Rows[e.RowIndex].Cells["id"].Value;
                DateTime now = DateTime.Now;
                string message = string.Format("Employee with Id of {1} wants to change the Project status with Id of {2} to End at ({0})", now.ToString(), managerId, proId);
                notify.addNotify(1, message);
                MessageBox.Show("Success");
            }
        }
    }
}
