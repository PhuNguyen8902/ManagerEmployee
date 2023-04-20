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
using static EmployeesManagement.Service.SalaryService;

namespace EmployeesManagement.userControl.Detail.salaryDetail
{
    public partial class updateSalaryDetail : Form
    {
        salaryController salaryController = new salaryController();


        public int Id { get; set; }
        public int Level { get; set; }
        public int AllowanceSalaryId { get; set; }
        public updateSalaryDetail(int id,int Level, int AllowanceSalaryId)
        {
            InitializeComponent();
            this.Id = id;   
            this.Level = Level;
            this.AllowanceSalaryId = AllowanceSalaryId;
        }
        
        public updateSalaryDetail()
        {
            InitializeComponent();
        }

        private void updateSalaryDetail_Load(object sender, EventArgs e)
        {
            salaryController.LoadLevelData(cbLevel);
            salaryController.LoadAllowanceData(cbAllowance);
            fillTextBox(Level, AllowanceSalaryId);
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
                Salary salary = new Salary(Id, levelNum, allowanceNum);
                if (salaryController.updateSalary(levelNum,allowanceNum,salary))
                {
                    MessageBox.Show("Update successfully");
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
                    MessageBox.Show("Update department fail");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        private void fillTextBox(int l, int a)
        {
            foreach (MyComboBoxItem item in cbLevel.Items)
            {
                if (int.Parse(item.Tag.ToString()) == l)
                {
                    cbLevel.SelectedItem = item;
                    break;
                }
            }
            foreach (MyComboBoxItem item in cbAllowance.Items)
            {
                if (int.Parse(item.Content.ToString()) == a)
                {
                    cbAllowance.SelectedItem = item;
                    break;
                }
            }

        }
    }
}
