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

namespace EmployeesManagement.userControl.UserControlManager.Detail.projectPage
{
    public partial class projectEmployeeDetail : Form
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        SqlConnection connection = Connection.Connection.GetConnection();
        projectController projectController = new projectController();
        notifyController notify = new notifyController();
        public projectEmployeeDetail()
        {
            InitializeComponent();
        }
        public projectEmployeeDetail(int Id, string Name, string Description, string StartDate, string EndDate, bool IsActive)
        {
            InitializeComponent();
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsActive = IsActive;
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

        private void projectEmployeeDetail_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = projectController.getEmployeeWorkInSpecificProject(Id);

            dgvEmployee.DataSource = dataTable;

            connection.Close();

            lbId.Text += "\t" + Id.ToString();
            lbName.Text += "\t" + Name;
            lbDescription.Text += "\t" + Description;
            lbStartDate.Text += "\t" + StartDate;
            lbEndDate.Text += "\t" + EndDate;
            if (IsActive)
            {
                lbCondition.Text += "\t" + "end";
            }
            else
            {
                lbCondition.Text += "\t" + "active";
            }
        }
    }
}
