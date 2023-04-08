using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.Detail
{
    public partial class addProjectDetail : Form
    {
        public addProjectDetail()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
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
    }
}
