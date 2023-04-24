using EmployeesManagement.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.UserControlManager
{
    public partial class projectPage : UserControl
    {
        private int managerId;
        private string type;
        int isActive = 0;
        private projectController projectController;
        private salaryController salaryController;
        private departmentController departmentController;
        private employeeController empController;
        private notifyController notify;
        SqlConnection connection = Connection.Connection.GetConnection();
        public projectPage()
        {
            InitializeComponent();
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
            empController = new employeeController();
            notify = new notifyController();
        }
        public projectPage(int managerId, string type)
        {
            InitializeComponent();
            projectController = new projectController();
            salaryController = new salaryController();
            departmentController = new departmentController();
            empController = new employeeController();
            notify = new notifyController();
            this.managerId = managerId;
            this.type = type;
        }

        private void projectPage_Load(object sender, EventArgs e)
        {

        }

        private void btnActiveProject_Click(object sender, EventArgs e)
        {

        }

        private void btnEndProject_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
