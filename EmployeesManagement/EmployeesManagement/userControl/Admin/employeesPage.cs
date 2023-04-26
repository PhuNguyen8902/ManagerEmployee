using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl.Admin.Detail.emailDetail;
using EmployeesManagement.userControl.Admin.Detail.employeeDetail;
using EmployeesManagement.userControl.Admin.Detail.projectDetail;
using EmployeesManagement.userControl.Detail.employeeDetail;
using EmployeesManagement.Utils;
using Google.Protobuf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Xml.Linq;

namespace EmployeesManagement.userControl
{
    public partial class employeesPage : UserControl
    {
        int accId = -1;
        SqlConnection connection = Connection.Connection.GetConnection();

        private Employee employeeModel;
        private EmployeeService employeeService;
        private employeeController employeeController;
        private UtilsController utilsController;
        public employeesPage()
        {
            InitializeComponent();
            employeeModel = new Employee();
            employeeService = new EmployeeService();
            employeeController = new employeeController();
            employeesPage_Load();
        }
        public employeesPage(int accId)
        {
            InitializeComponent();
            employeeModel = new Employee();
            employeeService = new EmployeeService();
            employeeController = new employeeController();
            employeesPage_Load();
            this.accId = accId;
        }

        private void employeesPage_Load()
        {
            DataTable dataTable = employeeController.getEmployee();

            dgvEmployee.DataSource = dataTable;
            loadCbSearch();
            btnSearch.Enabled = false;
        }
        private void loadCbSearch()
        {
            cbSearch.Items.Add("Employee Id");
            cbSearch.Items.Add("Employee Name");
            cbSearch.Items.Add("Employee Phone");
            cbSearch.Items.Add("Employee Gender");
            cbSearch.Items.Add("Employee HomeTown");
            cbSearch.Items.Add("Department");
            cbSearch.Items.Add("Salary");
            cbSearch.Items.Add("Position");
            cbSearchGender.Items.Add("Male");
            cbSearchGender.Items.Add("Female");
            cbSearchPosition.Items.Add("Employee");
            cbSearchPosition.Items.Add("Admin");
            cbSearchPosition.Items.Add("Manage");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addEmployeeDetail formAddEmployee = new addEmployeeDetail();
            formAddEmployee.ShowDialog();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];

                int id = Int32.Parse(row.Cells[0].Value.ToString());

                if (employeeController.deleteEmployee(id))
                {
                    MessageBox.Show("Xóa thành công");
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            form.Close();
                            primary primaryPage = new primary(0);
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
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


                updateEmployeeDetail formUpdateEmployee = new updateEmployeeDetail(id, name, phone, gender, hometown, departmentId, salaryId, positionId);
                formUpdateEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose employee to update");
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
                for (int i = 1; i < dgvEmployee.Rows.Count+1; i++)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "Employee Id")
            {
                int id;
                if (!int.TryParse(tbSearch.Text, out id))
                {
                    MessageBox.Show("Please enter a number for the ID!");
                }
                else
                {
                    DataTable dataTable = employeeController.findById(id, "e.id");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Phone")
            {
                long phone;
                if (!long.TryParse(tbSearch.Text, out phone))
                {
                    MessageBox.Show("Please enter a number for the Phone!");
                    return;
                }
                else
                {
                    string strPhone = phone.ToString();
                    DataTable dataTable = employeeController.findByCondition(strPhone, "e.phone");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(name, "e.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee HomeTown")
            {
                string homeTown = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(homeTown, "e.home_town");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Gender")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    int gender = cbSearchGender.SelectedIndex;
                    DataTable dataTable = employeeController.findById(gender, "e.gender");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Department")
            {
                string department = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(department, "d.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Position")
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string position = cbSearchPosition.SelectedItem.ToString();
                    DataTable dataTable = employeeController.findByCondition(position, "p.name");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Salary")
            {
                long salary;
                if (!long.TryParse(tbSearch.Text, out salary))
                {
                    MessageBox.Show("Please enter a number for the Salary!");
                    return;
                }
                else
                {
                    string strSalary = salary.ToString();
                    DataTable dataTable = employeeController.findByCondition(strSalary, "s.net_salary");
                    dgvEmployee.DataSource = dataTable;
                }
            }
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
                if (cbSearch.SelectedItem.ToString() == "Employee Gender")
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = false;
                    cbSearchGender.Visible = true;
                }
                else if (cbSearch.SelectedItem.ToString() == "Position")
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = true;
                    cbSearchGender.Visible = false;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchPosition.Visible = false;
                    cbSearchGender.Visible = false;
                }
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = employeeController.getEmployee();

            dgvEmployee.DataSource = dataTable;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            chooseSend formChoose = new chooseSend(accId);
            formChoose.ShowDialog();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEmployee.SelectedRows[0];
                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string phone = row.Cells[2].Value.ToString();
                string gender = row.Cells[3].Value.ToString();
                string homeTown = row.Cells[4].Value.ToString();
                string department = row.Cells[5].Value.ToString();
                string salary = row.Cells[6].Value.ToString();
                string position = row.Cells[7].Value.ToString();


                employeeDetail formDetail = new employeeDetail(id, name, phone, gender, homeTown, department, salary, position);
                formDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose project to continue this action");
            }
        }
    }
}
