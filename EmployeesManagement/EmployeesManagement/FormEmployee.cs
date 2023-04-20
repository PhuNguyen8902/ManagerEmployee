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
    public partial class FormEmployee : Form
    {
        navigationController navigationControl;
        public FormEmployee()
        {
            InitializeComponent();
            initializeNavigationController(0);
        }
        public FormEmployee(int display)
        {
            InitializeComponent();
            initializeNavigationController(display);
        }
        private void initializeNavigationController(int display)
        {
            List<UserControl> userControls = new List<UserControl>()
            { new employeesPage(), new projectsPage(), new DepartmentPage(),new salaryPage()};

            navigationControl = new navigationController(userControls, mainPanel); // create an instance of navigationControl
            navigationControl.display(display);
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
            this.Close();
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(2);
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(3);
        }
    }
}
