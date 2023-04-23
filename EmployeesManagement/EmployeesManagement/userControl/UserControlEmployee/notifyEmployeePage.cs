using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class notifyEmployeePage : UserControl
    {
        private static string savedMessage = "";
        public notifyEmployeePage()
        {
            InitializeComponent();
            label1.Text = savedMessage;
        }
        public void SendMessage(string message)
        {
            label1.Text = message;
            label1.Refresh();
            savedMessage = message;
        }
    }

}

