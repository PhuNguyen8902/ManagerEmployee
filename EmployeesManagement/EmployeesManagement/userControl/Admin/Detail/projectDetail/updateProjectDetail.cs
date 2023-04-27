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

namespace EmployeesManagement.userControl.Detail.projectDetail
{
    public partial class updateProjectDetail : Form
    {
        projectController projectController = new projectController();
        employeeController empController = new employeeController();
        notifyController notify = new notifyController();


        public updateProjectDetail()
        {
            InitializeComponent();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        public updateProjectDetail(int Id, string Name, string Description, string StartDate, string EndDate, bool IsActive)
        {
            InitializeComponent();
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsActive = IsActive;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "")
            {
                if (DTPStart.Value.Date >= DTPEnd.Value.Date)
                {
                    MessageBox.Show("Start date can't higher or equal end date");
                    return;
                }
                DTPStart.CustomFormat = "yyyy-MM-dd";
                DTPEnd.CustomFormat = "yyyy-MM-dd";
                string startDate = DTPStart.Value.ToString("yyyy-MM-dd");
                string endDate = DTPEnd.Value.ToString("yyyy-MM-dd");
                string active = cbActive.SelectedItem.ToString();
                if (active == "Active")
                    IsActive = false;
                else
                    IsActive = true;

                Project project = new Project(Id, txtName.Text, txtDescription.Text, startDate, endDate, IsActive);
                if (projectController.updateProject(project))
                {
                    MessageBox.Show("Update successfully");
                    List<int> empList = empController.getEmployeesInEmployeeProject(Id);
                    foreach (int empId in empList)
                    {
                        DateTime now = DateTime.Now;
                        string message = string.Format("Admin has changed the information of the Project you are working with ({0})", now.ToString());
                        notify.addNotify(empId, message);
                    }

                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary(1);
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Update project fail");
                }
            }
            else
            {
                MessageBox.Show("Please enter in full");
            }
        }

        private void updateProjectDetail_Load(object sender, EventArgs e)
        {
            cbActive.Items.Add("Active");
            cbActive.Items.Add("End");
            fillTextBox(Name, Description, StartDate, EndDate, IsActive);
        }
        private void fillTextBox(string name, string description, string startDate, string endDate, bool isActive)
        {
            txtName.Text = name;
            txtDescription.Text = description;
            DateTime start = DateTime.Parse(startDate);
            DTPStart.Value = start;
            DateTime end = DateTime.Parse(endDate);
            DTPEnd.Value = end;
            if (!isActive)
            {
                cbActive.SelectedIndex = 1;
            }
            else
            {
                cbActive.SelectedIndex = 0;
            }
        }
    }
}
