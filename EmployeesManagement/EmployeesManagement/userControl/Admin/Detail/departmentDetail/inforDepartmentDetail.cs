using EmployeesManagement.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.departmentDetail
{
    public partial class inforDepartmentDetail : Form
    {
        int deId;
        employeeController empController = new employeeController();
        public inforDepartmentDetail()
        {
            InitializeComponent();
        }
        public inforDepartmentDetail(int deId)
        {
            InitializeComponent();
            this.deId = deId;

        }

        private void inforDepartmentDetail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = empController.GetEmployeeDataInDeparment(deId);

            dgvDepartmentDetail.DataSource = dataTable;
            loadSearchEntity();
            cbSearchGender.Items.Add("Male");
            cbSearchGender.Items.Add("Female");
            cbSearchPosition.Items.Add("Admin");
            cbSearchPosition.Items.Add("Manage");
            cbSearchPosition.Items.Add("Employee");
        }
        private void loadSearchEntity()
        {
            tbSearch.Visible = true;
            cbSearchPosition.Visible = false;
            cbSearchGender.Visible = false;
            btnSearch.Enabled = false;
            cbSearch.Items.Add("Employee Id");
            cbSearch.Items.Add("Employee Name");
            cbSearch.Items.Add("Employee Phone");
            cbSearch.Items.Add("Employee Gender");
            cbSearch.Items.Add("Employee HomeTown");
            cbSearch.Items.Add("Position");
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
                string selectedValue = cbSearch.SelectedItem.ToString();
                if (selectedValue == "Employee Gender")
                {
                    tbSearch.Visible = false;
                    cbSearchPosition.Visible = false;
                    cbSearchGender.Visible = true;
                }
                else if (selectedValue == "Position")
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = cbSearch.SelectedItem.ToString();
            if (selectedValue == "Employee Id")
            {
                string value = tbSearch.Text;
                DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionId(deId, "e.id", value);

                dgvDepartmentDetail.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Name")
            {
                string value = tbSearch.Text;
                DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionElse(deId, "e.name", value);

                dgvDepartmentDetail.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Phone")
            {
                string value = tbSearch.Text;
                DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionElse(deId, "e.phone", value);

                dgvDepartmentDetail.DataSource = dataTable;
            }
            else if (selectedValue == "Employee Gender")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    string value = cbSearchGender.SelectedIndex.ToString();
                    DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionId(deId, "e.gender", value);
                    dgvDepartmentDetail.DataSource = dataTable;
                }
            }
            else if (selectedValue == "Employee HomeTown")
            {
                if (cbSearchGender.SelectedIndex != -1)
                {
                    string value = cbSearchGender.SelectedIndex.ToString();
                    DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionElse(deId, "e.home_town", value);
                    dgvDepartmentDetail.DataSource = dataTable;
                }
            }
            else
            {
                if (cbSearchPosition.SelectedIndex != -1)
                {
                    string value = cbSearchPosition.SelectedItem.ToString();
                    DataTable dataTable = empController.searchEmployeeDataInDeparmentByConditionId(deId, "p.name", value);
                    dgvDepartmentDetail.DataSource = dataTable;
                }
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            DataTable dataTable = empController.GetEmployeeDataInDeparment(deId);

            dgvDepartmentDetail.DataSource = dataTable;
        }
    }
}
