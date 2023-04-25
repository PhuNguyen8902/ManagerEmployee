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
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    public partial class chooseSend : Form
    {
        int testId;
        private static int accId;
        int deId;
        string deName;
        int emId;
        long emPhone;
        string from;
        List<string> toList = new List<string>();
        private accountController accController = new accountController();
        private employeeController empController = new employeeController();
        public chooseSend()
        {
            InitializeComponent();
        }
        public chooseSend(int id)
        {
            InitializeComponent();
            this.testId = id;
            accId = testId;
        }
        public chooseSend(int emId, long emPhone)
        {
            InitializeComponent();
            this.emId = emId;
            this.emPhone = emPhone;
            Account acc = accController.getAccountOfEmployee(emId);
            if (acc != null)
            {
                tbResult.Text = emId.ToString();
                btnConfirm.Enabled = true;
                string emEmail = acc.Email;
                toList.Add(emEmail);
            }
            else
            {
                MessageBox.Show("This employee don't have account");
            }
        }
        public chooseSend(int deId, string deName)
        {
            InitializeComponent();
            string emEmail;
            Boolean rs = false;
            this.deId = deId;
            this.deName = deName;
        
            List<int> empList = new List<int>();
            empList = empController.getEmployeesInDepartment(deId);
            foreach (int emp in empList)
            {
                Account acc = accController.getAccountOfEmployee(emp);
                if (acc != null)
                {
                    emEmail = acc.Email;
                    toList.Add(emEmail);
                    rs = true;
                }
            }
            if (rs)
            {
                tbResult.Text = deId.ToString();
                btnConfirm.Enabled = true;
            }
        }

        private void chooseSend_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("All");
            cbType.Items.Add("Department");
            cbType.Items.Add("Employee");
            btnSearch.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
          
            Account acc = accController.findById("id",accId.ToString());
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
            //    MessageBox.Show("from ne: "+ from + " list ne: " + str);
            //}
            sendEmailDetail formEmail = new sendEmailDetail(from,toList,accId);
            formEmail.ShowDialog();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex != -1)
            {
                string value = cbType.SelectedItem.ToString();
                if (value == "All")
                {
                    toList = accController.getEmailsHaveEmployeeId();
                    btnConfirm.Enabled = true;
                    btnSearch.Enabled = false;
                }
                else if (value == "Department")
                {
                    btnSearch.Enabled = true;
                    btnConfirm.Enabled = false;
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
            if (cbType.SelectedIndex != -1)
            {
                string value = cbType.SelectedItem.ToString();
                if (value == "Department")
                {
                    sendMailDepartmentDetail formDepartment = new sendMailDepartmentDetail();
                    this.Close();
                    formDepartment.ShowDialog();
                }
                else if (value == "Employee")
                {
                    sendMailEmployeeDetail formEmployee = new sendMailEmployeeDetail();
                    this.Close();
                    formEmployee.ShowDialog();
                }
            }
        }
    }
}
