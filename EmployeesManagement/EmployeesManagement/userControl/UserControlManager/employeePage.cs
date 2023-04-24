using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl.Detail.employeeDetail;
using EmployeesManagement.userControl.UserControlManager.Detail.employeePage;
using EmployeesManagement.Utils;
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
    
    public partial class employeePage : UserControl
    {
        SqlConnection connection = Connection.Connection.GetConnection();

        private int managerId;
        private string type;

        private Employee employeeModel;
        private EmployeeService employeeService = new EmployeeService();
        private employeeController employeeController = new employeeController();
        private UtilsController utilsController = new UtilsController();
        public employeePage()
        {
            InitializeComponent();
        }
        public employeePage(int id, string type)
        {
            InitializeComponent();
            this.managerId = id;
            this.type = type;
        }
        private void employeePage_Load(object sender, EventArgs e)
        {
            employeeService.OpenConnection();

            DataTable dataTable = employeeController.GetEmployeeDataByItsManagerId(managerId);

            dgvEmployee.DataSource = dataTable;


            employeeService.CloseConnection();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployeeByManager form = new addEmployeeByManager(managerId, type);
            form.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string phone = row.Cells[2].Value.ToString();

                String genderString = row.Cells[3].Value.ToString();
                byte gender = 1;
                if (genderString == "Male")
                    gender = 0;

                string hometown = row.Cells[4].Value.ToString();
                String departmentString = row.Cells[5].Value.ToString();

                int departmentId = employeeController.getIdByDeparementName(departmentString);

                string salaryNetString = row.Cells[6].Value.ToString();
                int salaryNet = 0;
                if (salaryNetString != "")
                    salaryNet = Int32.Parse(salaryNetString);

                int salaryId = employeeController.getIdByNetSalary(salaryNet);


                String positionString = row.Cells[7].Value.ToString();
                int positionId = employeeController.getIdByPositionName(positionString);


                updateEmployeeByManager formUpdateEmployee = new updateEmployeeByManager(id, name, phone, gender, hometown, departmentId, salaryId, positionId, managerId, type);
                formUpdateEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose employee to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (employeeController.deleteEmployee(id))
                {
                    MessageBox.Show("Delete successfully");
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "FormManager")
                        {
                            form.Close();
                            FormManager primaryPage = new FormManager(1, managerId, type);
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Delete unsuccessfully");
                }

            }
            else
            {
                MessageBox.Show("Choose employee want to delete");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for(int i = 0; i < dgvEmployee.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dgvEmployee.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvEmployee.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvEmployee.Columns.Count; j++)
                    {
                        excel.Cells[i+2, j+1] = dgvEmployee.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }
    }
}
