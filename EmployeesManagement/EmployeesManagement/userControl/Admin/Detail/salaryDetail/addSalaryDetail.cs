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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeesManagement.userControl.Detail.salaryDetail
{
    public partial class addSalaryDetail : Form
    {
        salaryController salaryController = new salaryController();

        public addSalaryDetail()
        {
            InitializeComponent();
        }

        private void addSalaryDetail_Load(object sender, EventArgs e)
        {
            salaryController.LoadLevelData(cbLevel);
            salaryController.LoadAllowanceData(cbAllowance);
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex != -1 && cbAllowance.SelectedIndex != -1)
            {
                string level = cbLevel.SelectedItem.ToString();
                ComboBoxItem levelItem = (ComboBoxItem)cbLevel.SelectedItem;
                string idLevel = levelItem.Tag.ToString();
                int levelNum = Int32.Parse(idLevel);

                string allowance = cbAllowance.SelectedItem.ToString();
                ComboBoxItem allowanceItem = (ComboBoxItem)cbAllowance.SelectedItem;
                string idAllowance = allowanceItem.Tag.ToString();
                int allowanceNum = Int32.Parse(idAllowance);


                Salary salary = new Salary(levelNum, allowanceNum);
                if (salaryController.addSalary(levelNum, allowanceNum))
                {
                    MessageBox.Show("Insert Success");


                    // kiem tra xem form primary co dang mo hay khong
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary();
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }
            else
            {
                MessageBox.Show("Please enter in full");
            }
        }
    }
}
