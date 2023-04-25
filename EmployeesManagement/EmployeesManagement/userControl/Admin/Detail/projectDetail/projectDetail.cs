using EmployeesManagement.Control;
using EmployeesManagement.Models;
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
    public partial class projectDetail : Form
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        SqlConnection connection = Connection.Connection.GetConnection();
        projectController projectController = new projectController();
        notifyController notify =new notifyController();



        public projectDetail(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        public projectDetail(int Id, string Name, string Description, string StartDate, string EndDate, bool IsActive)
        {

            InitializeComponent();
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsActive = IsActive;
        }

        private void projectDetail_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = projectController.getEmployeeWorkInSpecificProject(Id);

            dgvEmployee.DataSource = dataTable;

            connection.Close();

            lbId.Text += "   " + Id.ToString();
            lbName.Text += "  " + Name;
            lbDescription.Text += "  " + Description;
            lbStartDate.Text += "  " + StartDate;
            lbEndDate.Text += "  " + EndDate;
            if(IsActive)
            {
                lbCondition.Text += "  " + "end";
                btnAddEmployee.Visible = false;
                btnDeleteEmploye.Visible = false;
                btnUpdateEmployee.Visible = false;
            }
            else
            {
                lbCondition.Text += "  " + "active";
                btnAddEmployee.Visible = true;
                btnDeleteEmploye.Visible = true;
                btnUpdateEmployee.Visible = true;
            }
        }

        private  void addEmployee_Click(object sender, EventArgs e)
        {
            addEmployeeToProjectForm form = new addEmployeeToProjectForm(Id, EndDate, dgvEmployee);

            form.ShowDialog();

        }

        private void btnDeleteEmploye_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int employyId = Int32.Parse(row.Cells[0].Value.ToString());

                if(projectController.deleteEmployeeInProject(employyId, Id))
                {
                    MessageBox.Show("Delete Success");
                    DateTime now = DateTime.Now;
                    string message = string.Format("Admin has removed you from the {1} at ({0})", now.ToString(),Name);
                    notify.addNotify(employyId, message);
                    DataTable dataTable = projectController.getEmployeeWorkInSpecificProject(Id);
                    dgvEmployee.DataSource = dataTable;
                    return;
                }
                MessageBox.Show("Can't delete employee");
            }
            else
            {
                MessageBox.Show("You must choose employee to delete");
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int employeeId = Int32.Parse(row.Cells[0].Value.ToString());
                string startDate = row.Cells[3].Value.ToString();
                string endDate = row.Cells[4].Value.ToString();

                updateEmployeeInProject form = new updateEmployeeInProject(employeeId, Id, startDate, endDate, dgvEmployee);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose employee to update");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvEmployee.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dgvEmployee.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dgvEmployee.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvEmployee.Columns.Count + 1; j++)
                    {
                        excel.Cells[i + 1, j] = dgvEmployee.Rows[i - 1].Cells[j - 1].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }
    }
}
