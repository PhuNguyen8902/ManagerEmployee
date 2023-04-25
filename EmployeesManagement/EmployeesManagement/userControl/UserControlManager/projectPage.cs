﻿using EmployeesManagement.Control;
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
        }

        private void btnActiveProject_Click(object sender, EventArgs e)
        {
            isActive = 0;
            connection.Open();

            DataTable dataTable = projectController.GetProjectEmployeeData(managerId, isActive);

            dgvProject.DataSource = dataTable;

            connection.Close();
        }

        private void btnEndProject_Click(object sender, EventArgs e)
        {
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
                for (int i = 1; i < dgvProject.Rows.Count ; i++)
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
