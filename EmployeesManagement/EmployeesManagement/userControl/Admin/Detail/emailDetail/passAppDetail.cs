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
    public partial class passAppDetail : Form
    {
        accountController accController = new accountController();
        private string email = "";
        public passAppDetail()
        {
            InitializeComponent();
        }
        public passAppDetail(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string passApp = tbPassApp.Text;
            Account acc = accController.findById("email", email);
            int accId = acc.Id;
            Boolean rs = accController.insertPassApp(passApp, accId);
            if (rs)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void tbPassApp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
