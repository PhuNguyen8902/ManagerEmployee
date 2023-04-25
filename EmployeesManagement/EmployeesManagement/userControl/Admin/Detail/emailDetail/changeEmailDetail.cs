using EmployeesManagement.Control;
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
    public partial class changeEmailDetail : Form
    {
        int accId;
        private accountController accController = new accountController();
        public changeEmailDetail()
        {
            InitializeComponent();
        }
        public changeEmailDetail(int accId)
        {
            InitializeComponent();
            this.accId = accId;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newEmail = tbNewEmail.Text;
            Boolean rsCheck = accController.checkEmailDuplicate(newEmail, -1);
            if (rsCheck)
            {
                Boolean rs = accController.updateEmailEmployeeById(accId, newEmail);
                if (rs)
                {
                    MessageBox.Show("Update Success");
                }
                else
                {
                    MessageBox.Show("Update Fail");
                }
            }
            else
            {
                MessageBox.Show("Email is duplicate");
            }
        }
    }
}
