using EmployeesManagement.Control;
using EmployeesManagement.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using system.windows.controls;
using System.Windows.Forms;

namespace EmployeesManagement
{
    public partial class primary : Form
    {
        navigationController navigationControl;

        public primary()
        {
            InitializeComponent();
            initializeNavigationController();
        }
        private void initializeNavigationController()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new employeesPage(), new projectsPage()};

            navigationControl = new navigationController(userControls, mainPanel); // create an instance of navigationControl
            navigationControl.display(0);
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(0);
        }
        private void projectsBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(1);

        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            login loginPage = new login();
            loginPage.Show();
            this.Hide();
        }

      
    }
}
