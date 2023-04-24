using EmployeesManagement.Control;
using EmployeesManagement.Models;
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

namespace EmployeesManagement.userControl.UserControlManager
{
    public partial class departmentInformationPage : UserControl
    {
        private int manageId;
        private employeeController empController = new employeeController();
        private departmentController departmentController = new departmentController();
        private accountController accController = new accountController();
        UtilsController utilsController = new UtilsController();
        public departmentInformationPage()
        {
            InitializeComponent();
        }
        public departmentInformationPage(int manageId)
        {
            InitializeComponent();
            this.manageId = manageId;
        }

        private void departmentInformationPage_Load(object sender, EventArgs e)
        {
            Department department = empController.GetDepartmentDataByManagerId(manageId);
            tbInforId.Text = department.Id.ToString();
            tbInforName.Text = department.Name;
            tbInforPhone.Text = department.Phone;
            tbInforAddress.Text = department.Address;
        }
    }
}
