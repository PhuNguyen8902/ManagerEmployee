using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagement.Control
{
    internal class navigationController
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public navigationController(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            addUserControl();
        }
        private void addUserControl()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                // set every userControl's dock style to fill 
                userControlList[i].Dock = DockStyle.Fill;
                // add all the userControls inside the panel
                panel.Controls.Add(userControlList[i]);
            }
        }
        public void display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].BringToFront(); // display only the selected userControl using index
            }
        }
    }
}
