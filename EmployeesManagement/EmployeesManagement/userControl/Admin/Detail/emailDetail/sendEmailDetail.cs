using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesManagement.Control;
using EmployeesManagement.Models;
using System.Security.Cryptography;
using System.Security.Principal;
using Microsoft.Office.Interop.Excel;

namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    public partial class sendEmailDetail : Form
    {
        int accId;
        string from;
        string selectedPath = "";
        List<string> toList = new List<string>();
        accountController accController = new accountController();
        public sendEmailDetail()
        {
            InitializeComponent();
        }
        public sendEmailDetail(string from, List<string> toList, int accId)
        {
            InitializeComponent();
            this.from = from;
            this.toList = toList;
            this.accId = accId;
        }
        public sendEmailDetail(int accId)
        {
            InitializeComponent();
            this.accId = accId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mailList = toList.ToArray();
            string strBody = tbBody.Text;
            string strSubject = tbSubject.Text;
            Boolean rs = false;
            if (tbResultFile.Text == "")
            {
                while (!rs)
                {
                    PassApp passApp = accController.getPassApp(accId);
                    string pass = passApp.Value;
                    if (!accController.sendEmails(from, mailList, pass, strBody, strSubject))
                    {
                        MessageBox.Show("Send email Fail");
                        passAppDetail formPassApp = new passAppDetail(from);
                        formPassApp.ShowDialog();
                        DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            rs = false;
                        }
                        else
                        {
                            rs = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Send Email Success");
                        rs = true;
                    }
                }
            }
            else
            {
                while (!rs)
                {
                    PassApp passApp = accController.getPassApp(accId);
                    string pass = passApp.Value;
                    if (!accController.SendEmailWithAttachment(from, mailList, pass, strBody, strSubject, tbResultFile.Text))
                    {
                        MessageBox.Show("Send email Fail");
                        passAppDetail formPassApp = new passAppDetail(from);
                        formPassApp.ShowDialog();
                        DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            rs = false;
                        }
                        else
                        {
                            rs = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Send Email Success");
                        rs = true;
                    }
                }
            }
        }

        private void tbSubject_Enter(object sender, EventArgs e)
        {
            if (tbSubject.Text == "Please enter subject")
            {
                tbSubject.Text = "";
                tbSubject.ForeColor = Color.Black;
            }
        }

        private void tbSubject_Leave(object sender, EventArgs e)
        {
            if (tbSubject.Text == "")
            {
                tbSubject.Text = "Please enter subject";
                tbSubject.ForeColor = Color.Gray;
            }
        }

        private void tbBody_Enter(object sender, EventArgs e)
        {
            if (tbBody.Text == "Please enter body")
            {
                tbBody.Text = "";
                tbBody.ForeColor = Color.Black;
            }
        }

        private void tbBody_Leave(object sender, EventArgs e)
        {
            if (tbBody.Text == "")
            {
                tbBody.Text = "Please enter body";
                tbBody.ForeColor = Color.Gray;
            }
        }

        private void sendEmailDetail_Load(object sender, EventArgs e)
        {
            tbSubject.Text = "Please enter subject";
            tbBody.Text = "Please enter body";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|Word Documents|*.docx|Excel Files|*.xlsx";
            openFileDialog.Title = "Select a file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = openFileDialog.FileName;
                tbResultFile.Text = selectedPath;
            }
        }
    }
}
