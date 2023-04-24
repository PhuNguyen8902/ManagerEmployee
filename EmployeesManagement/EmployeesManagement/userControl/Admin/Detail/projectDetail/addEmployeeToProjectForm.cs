using EmployeesManagement.Control;
using EmployeesManagement.Models;
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

namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    public partial class addEmployeeToProjectForm : Form
    {
        employeeController employeeController = new employeeController();
        SqlConnection connection = Connection.Connection.GetConnection();
        projectController projectController = new projectController();
        notifyController notify = new notifyController();


        DataGridView dgvProjectDetail;

        private int projectId { get; set; }

        public string endDate { get; set; }

        

        
        public addEmployeeToProjectForm(int projectId, String endDate, DataGridView dgb)
        {
            InitializeComponent();
            this.projectId= projectId;
            this.endDate = endDate;
            this.dgvProjectDetail = dgb;
        }

        private void addEmployeeToProjectForm_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = employeeController.getEmployee();

            dgvAllEmployees.DataSource = dataTable;

            connection.Close();
            
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (dgvAllEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAllEmployees.SelectedRows[0];
                int employyId = Int32.Parse(row.Cells[0].Value.ToString());

                String today = DateTime.Today.ToString("yyyy-MM-dd");

                EmployeeProject ep = new EmployeeProject(employyId, projectId, today, endDate);

                if (projectController.addEmployeeToProject(ep))
                {
                    this.Close();

                    DataTable dataTable = projectController.getEmployeeWorkInSpecificProject(projectId);
                    dgvProjectDetail.DataSource = dataTable;

                    MessageBox.Show("Add Success");
                    Project pro = projectController.getProject(projectId);
                    string proName = pro.Name;
                    DateTime now = DateTime.Now;
                    string message = string.Format("Admin added you to {1} at ({0})", now.ToString(),proName);
                    notify.addNotify(employyId, message);
                    return;
                }

                MessageBox.Show("Can't add employee to project");
            }
            else
            {
                MessageBox.Show("Choose employee to add");
            }
        }
    }
}
