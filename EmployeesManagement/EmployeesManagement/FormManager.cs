using EmployeesManagement.Control;
using EmployeesManagement.Models;
using EmployeesManagement.Service;
using EmployeesManagement.userControl;
using EmployeesManagement.userControl.UserControlManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement
{
    public partial class FormManager : Form
    {
        navigationController navigationControl;
        employeeController empController = new employeeController();
        private int managerId;
        private string type;
        private string name;
        public FormManager()
        {
            InitializeComponent();
            initializeNavigationController(0);
        }
        public FormManager(int display, int managerId, string type)
        {
            InitializeComponent();
            this.managerId = managerId;
            this.type = type;
            initializeNavigationController(display);
        }
        private void initializeNavigationController(int display)
        {
            List<UserControl> userControls = new List<UserControl>()
            { new informationManagerPage(managerId), new userControl.UserControlManager.employeePage(managerId, type)
            , new departmentInformationPage(managerId), new  userControl.UserControlManager.projectPage(managerId, type),new userControl.UserControlManager.accountPage(managerId),new userControl.UserControlEmployee.notifyEmployeePage(managerId)};

            navigationControl = new navigationController(userControls, mainPanel); // create an instance of navigationControl
            navigationControl.display(display);

        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(0);
        }
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(1);
        }
        private void departmentBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(2);
        }
        private void projectsBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(3);
        }
        private void returnBtn_Click_1(object sender, EventArgs e)
        {
            login loginPage = new login();
            loginPage.Show();
            this.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Employee manager = empController.getInforEmployee(managerId);
            //int deId = (int)manager.DepartmentId;
            createAccount createAccountPage = new createAccount(managerId);
            createAccountPage.Show();
            this.Close();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(4);
        }

        private void notifyBtn_Click(object sender, EventArgs e)
        {
            navigationControl.display(5);

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            Employee emp = empController.getInforEmployee(managerId);
            string name = emp.Name;
            lbName.Text = name;
        }
    }
}
