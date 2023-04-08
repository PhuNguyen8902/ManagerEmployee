using EmployeesManagement.Detail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl
{
    public partial class projectsPage : UserControl
    {
        public projectsPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addProjectDetail formAddDetail = new addProjectDetail();
            formAddDetail.ShowDialog();
        }
    }
}
