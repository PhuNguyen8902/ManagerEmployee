using EmployeesManagement.Control;
using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    public partial class updateEmployeeInProject : Form
    {
        public int employeeId { get; set; } 
        public int projectId { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        public DataGridView dgvEmployee;
        
        projectController projectController = new projectController();
        public updateEmployeeInProject(int employeeId, int projectId, string startDate, string endDate, DataGridView dgv)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.projectId = projectId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.dgvEmployee = dgv;

            DateTime start = DateTime.Parse(startDate);
            DTPStart.Value = start;
            DateTime end = DateTime.Parse(endDate);
            DTPEnd.Value = end;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            DTPStart.CustomFormat = "yyyy-MM-dd";
            DTPEnd.CustomFormat = "yyyy-MM-dd";
            string startDate = DTPStart.Value.ToString("yyyy-MM-dd");
            string endDate = DTPEnd.Value.ToString("yyyy-MM-dd");

            EmployeeProject ep = new EmployeeProject(employeeId, projectId, startDate, endDate);
            if (projectController.updateEmployeeInProject(ep))
            {
                MessageBox.Show("Update successfully");

                DataTable dataTable = projectController.getEmployeeWorkInSpecificProject(projectId);

                dgvEmployee.DataSource = dataTable;

                this.Close();
                return;
            }
            MessageBox.Show("Update fail");
        }
    }
}
