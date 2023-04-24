﻿using EmployeesManagement.Control;
using EmployeesManagement.Detail;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
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

        private void employeesPage_Load()
        {
            DataTable dataTable = employeeController.getEmployee();

            dgvEmployee.DataSource = dataTable;

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
            dgvEmployee.SelectAll();
            DataObject copydata = dgvEmployee.GetClipboardContent();
            if (copydata != null) { Clipboard.SetDataObject(copydata); }
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = excel.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,  true);



        }
    }
}
