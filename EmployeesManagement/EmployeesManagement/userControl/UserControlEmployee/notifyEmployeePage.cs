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

namespace EmployeesManagement.userControl.UserControlEmployee
{
    public partial class notifyEmployeePage : UserControl
    {
        private int emid = -1;
        private notifyController notify;
        public notifyEmployeePage()
        {
            InitializeComponent();
        }
        public notifyEmployeePage(int emid)
        {
            InitializeComponent();
            notify = new notifyController();
            this.emid = emid;
            notify.checkAndDeleteNotify(emid);
            createPanelToNotify();
        }
        public void createPanelToNotify()
        {
            int count = notify.countNotify(emid);
            if (count > 0)
            {
                this.Controls.Clear();
                int padding = 10;
                int panelHeight = 50;
                int labelFontSize = 10;
                string labelFontName = "Segoe UI";
                List<Notify> notifyList = notify.getNotify(emid);
                notifyList.Reverse();   

                for (int i = 0; i < count; i++)
                {
                    Panel panel = new Panel();
                    panel.Top = i * (panelHeight + padding);
                    panel.Left = 0;
                    panel.Width = this.Width;
                    panel.Height = panelHeight;
                    panel.BackColor = Color.White;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Padding = new Padding(padding);

                    Label label = new Label();
                    label.Text = notifyList[i].Value; 
                    label.AutoSize = true;
                    label.Font = new Font(labelFontName, labelFontSize, FontStyle.Regular);

                    panel.Controls.Add(label);
                    this.Controls.Add(panel);
                }
            }
        }

    }

}

