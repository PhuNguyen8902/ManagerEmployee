using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl.Admin.Detail.employeeDetail;
using EmployeesManagement.userControl.Detail.employeeDetail;
using EmployeesManagement.userControl.UserControlManager.Detail.emailDetail;
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
        private accountController accController = new accountController();
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
            loadCbSearch();
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
            if (dgvEmployee.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvEmployee.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dgvEmployee.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dgvEmployee.Rows.Count - 1; i++)
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

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc = accController.getAccountOfEmployee(managerId);
            int accId = acc.Id;
            manageChooseSend formChoose = new manageChooseSend(accId);
            formChoose.ShowDialog();
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            employeeService.OpenConnection();

            DataTable dataTable = employeeController.GetEmployeeDataByItsManagerId(managerId);

            dgvEmployee.DataSource = dataTable;


            employeeService.CloseConnection();
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
                    cbSearchGender.Visible = true;
                }
                else if (cbSearch.SelectedItem.ToString() == "Position")
                {
                    tbSearch.Visible = false;
                    cbSearchGender.Visible = false;
                }
                else
                {
                    tbSearch.Visible = true;
                    cbSearchGender.Visible = false;
                }
            }
        }
        private void loadCbSearch()
        {
            cbSearch.Items.Add("Employee Id");
            cbSearch.Items.Add("Employee Name");
            cbSearch.Items.Add("Employee Phone");
            cbSearch.Items.Add("Employee Gender");
            cbSearch.Items.Add("Employee HomeTown");
            cbSearch.Items.Add("Salary");
            cbSearchGender.Items.Add("Male");
            cbSearchGender.Items.Add("Female");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Employee mana = new Employee();
            mana = employeeController.getInforEmployee(managerId);
            int deId = (int)mana.DepartmentId;
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
                    DataTable dataTable = employeeController.findById(id, "e.department_id = " + deId +" and e.id");
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
                    DataTable dataTable = employeeController.findByCondition(strPhone, "e.department_id = " + deId + " and e.phone");
                    dgvEmployee.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee Name")
            {
                string name = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(name, "e.department_id = " + deId + " and e.name");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee HomeTown")
            {
                string homeTown = tbSearch.Text;
                DataTable dataTable = employeeController.findByCondition(homeTown, "e.department_id = " + deId + " and e.home_town");
                dgvEmployee.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Gender")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    int gender = cbSearchGender.SelectedIndex;
                    DataTable dataTable = employeeController.findById(gender, "e.department_id = " + deId + " and e.gender");
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
                    DataTable dataTable = employeeController.findByCondition(strSalary, "e.department_id = " + deId + " and s.net_salary");
                    dgvEmployee.DataSource = dataTable;
                }
            }
        }
    }
}
