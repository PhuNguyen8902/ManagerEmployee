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

namespace EmployeesManagement.userControl.Admin.Detail.employeeDetail
{
    public partial class employeeDetail : Form
    {

        private int id;
        private string name;
        private string phone;
        private string gender;
        private string hometown;
        private string department;
        private string salary;
        private string position;

        bool isParticipateNow = true;

        SqlConnection connection = Connection.Connection.GetConnection();
        employeeController employeeController = new employeeController();
        public employeeDetail()
        {
            InitializeComponent();
        }
        public employeeDetail(int id, string name, string phone, string gender, string hometown, string department, string salary, string position)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.gender = gender;
            this.hometown = hometown;
            this.department = department;
            this.salary = salary;
            this.position = position;
        }
        private void employeeDetail_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataTable dataTable = employeeController.getProjectDataByEmployeeId(id, isParticipateNow);

            dgvProject.DataSource = dataTable;

            connection.Close();

            lbId.Text += "   " + id.ToString();
            lbName.Text += "  " + name;
            lbPhone.Text += "  " + phone;
            lbGender.Text += "  " + gender;
            lbHomeTown.Text += "  " + hometown;
            lbDepartment.Text += "  " + department;
            lbSalary.Text += "   " + salary;
            lbPosition.Text += "  " + position;

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

        private void btnNow_Click(object sender, EventArgs e)
        {
            isParticipateNow = true;
            connection.Open();

            DataTable dataTable = employeeController.getProjectDataByEmployeeId(id, isParticipateNow);

            dgvProject.DataSource = dataTable;

            connection.Close();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            isParticipateNow = false;

            connection.Open();

            DataTable dataTable = employeeController.getProjectDataByEmployeeId(id, isParticipateNow);

            dgvProject.DataSource = dataTable;

            connection.Close();
        }
    }
}
