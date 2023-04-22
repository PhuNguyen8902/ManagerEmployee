using EmployeesManagement.Control;
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

namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    public partial class addEmployeeToProjectForm : Form
    {
        employeeController employeeController = new employeeController();
        SqlConnection connection = Connection.Connection.GetConnection();

        private int projectId { get; set; }

        public string? EndDate { get; set; }

        
        public addEmployeeToProjectForm(int projectId, String endDate)
        {
            InitializeComponent();
            this.projectId= projectId;
            this.EndDate = endDate;
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
                int id = Int32.Parse(row.Cells[0].Value.ToString());

               
            }
            else
            {
                MessageBox.Show("Choose employee to add");
            }
        }
    }
}
