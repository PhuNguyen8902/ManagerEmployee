using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.userControl.Admin.Detail.emailDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.UserControlManager.Detail.emailDetail
{
    public partial class manageChooseSend : Form
    {
        int empId;
        private static int accId;
        string from;
        List<string> toList = new List<string>();
        private employeeController empController = new employeeController();
        private accountController accController = new accountController();
        public manageChooseSend()
        {
            InitializeComponent();
        }

        public manageChooseSend(int testId)
        {
            InitializeComponent();
            accId = testId;
        }
        public manageChooseSend(int empId, long emPhone)
        {
            InitializeComponent();
            this.empId = empId;
            Account acc = accController.getAccountOfEmployee(empId);
            if (acc != null)
            {
                tbResult.Text = empId.ToString();
                btnConfirm.Enabled = true;
                string emEmail = acc.Email;
                toList.Add(emEmail);
            }
            else
            {
                MessageBox.Show("This employee don't have account");
            }
        }

        private void manageChooseSend_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("All in department");
            cbType.Items.Add("Employee");
            btnSearch.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Account a = accController.findById("id", accId.ToString());
            Account acc = accController.getAccountOfEmployee(a.EmployeeId);
            from = acc.Email;
            List<string> toRemove = new List<string>();
            foreach (string str in toList)
            {
                if (str == from)
                {
                    toRemove.Add(str);
                }
            }
            foreach (string str in toRemove)
            {
                toList.Remove(str);
            }

            //foreach (string str in toList)
            //{
            //    MessageBox.Show("from ne: " + from + " list ne: " + str + " accId ne: " + accId );
            //}
            sendEmailDetail formEmail = new sendEmailDetail(from, toList, accId);
            formEmail.ShowDialog();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex != -1)
            {
                string value = cbType.SelectedItem.ToString();
                Account a = accController.findById("id", accId.ToString());
                Employee ma = new Employee();
                ma = empController.getInforEmployee(a.EmployeeId);
                int deId = (int)ma.DepartmentId;
                string emEmail;
                if (value == "All in department")
                {
                    List<int> empList = new List<int>();
                    empList = empController.getEmployeesInDepartment(deId);
                    foreach (int emp in empList)
                    {
                        Account acc = accController.getAccountOfEmployee(emp);
                        if (acc != null)
                        {
                            emEmail = acc.Email;
                            toList.Add(emEmail);
                        }
                    }
                    btnConfirm.Enabled = true;
                    btnSearch.Enabled = false;
                }
                else if (value == "Employee")
                {
                    btnSearch.Enabled = true;
                    btnConfirm.Enabled = false;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Account a = accController.findById("id", accId.ToString());
            Employee emp = new Employee();
            emp = empController.getInforEmployee(a.EmployeeId);
            int deId = (int)emp.DepartmentId;
            manageSendMail formSend = new manageSendMail(deId);
            this.Close();
            formSend.ShowDialog();
        }
    }
}
