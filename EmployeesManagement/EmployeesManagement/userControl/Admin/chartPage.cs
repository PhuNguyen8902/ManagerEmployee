using EmployeesManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin
{
    public partial class chartPage : UserControl
    {
        UtilsController utilsController = new UtilsController();
        public chartPage()
        {
            InitializeComponent();
           
        }

        private void chartPage_Load(object sender, EventArgs e)
        {
            lbEmployees.Text = utilsController.numberOfEmployees().ToString();
            lbProjects.Text = utilsController.numberOfProjects().ToString();
            lbDepartments.Text = utilsController.numberOfDepartment().ToString();
        }
    }
}
