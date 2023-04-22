using EmployeesManagement.Control;
using EmployeesManagement.Models;

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class managerEmployeePage : UserControl
    {
        private int id;
        private employeeController empController;
        private departmentController departmentController;
        private accountController accController;


        public managerEmployeePage()
        {
            InitializeComponent();
        }

        public managerEmployeePage(int id)
        {
            InitializeComponent();
            empController = new employeeController();
            departmentController = new departmentController();
            accController = new accountController();
            this.id = id;
            loadManagerInfor();
        }

        private void loadManagerInfor()
        {
            Employee employee = new Employee();
            employee = empController.getInforEmployee(id);
            int departmentId = (int)employee.DepartmentId;
            Department department = new Department();
            Employee manager = new Employee();
            department = departmentController.getDepartmentOfEmployee(departmentId);
            manager = empController.getInforManagerOfEmployee(departmentId);
            if (manager != null)
            {
                if (manager.PositionId == 3)
                {
                    tbManagerPosition.Text = "Manager";
                }
                tbManagerName.Text = manager.Name;
                tbManagerPhone.Text = "0" + manager.Phone;
                if (manager.Gender == 0)
                {
                    tbManagerGender.Text = "Male";
                }
                else
                {
                    tbManagerGender.Text = "Female";
                }
                int managerId = manager.Id;
                Account accountManager = new Account();
                accountManager=accController.getAccountOfEmployee(managerId);
                if (accountManager != null)
                {
                    string emailManager = accountManager.Email;
                    tbManagerEmail.Text = emailManager;
                }
                else {
                    tbManagerEmail.Text = "Does not have an email";
                }
            }
            else
            {
                lbNotifyManager.Visible = true;
            }
            tbDepartmentName.Text = department.Name;
            tbDepartmentPhone.Text = "0" + department.Phone;
            tbDepartmentAddress.Text = department.Address;
        }
    }
}
