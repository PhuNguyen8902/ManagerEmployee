using EmployeesManagement.Control;
using EmployeesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.Detail
{
    public partial class addProjectDetail : Form
    {
        projectController projectController = new projectController();

        public addProjectDetail()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "")
            {
                DTPStart.CustomFormat= "yyyy-MM-dd";
                DTPEnd.CustomFormat = "yyyy-MM-dd";
                string startDate = DTPStart.Value.ToString("yyyy-MM-dd");
                string endDate = DTPEnd.Value.ToString("yyyy-MM-dd");
                Project project = new Project(txtName.Text, txtDescription.Text, startDate, endDate);
                if (projectController.addProject(project))
                {
                    MessageBox.Show("Thêm thành công");


                    // kiem tra xem form primary co dang mo hay khong
                    FormCollection allOpenedForm = Application.OpenForms;
                    foreach (Form form in allOpenedForm)
                    {
                        if (form.Name == "primary")
                        {
                            this.Close();
                            form.Close();
                            primary primaryPage = new primary();
                            primaryPage.Show();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }


    }
}
