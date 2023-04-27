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

        List<int> listYear = new List<int>();
        List<int> numberOfProject = new List<int>();

        public chartPage()
        {
            InitializeComponent();
        }

        private void chartPage_Load(object sender, EventArgs e)
        {
            lbEmployees.Text = utilsController.numberOfEmployees().ToString();
            lbProjects.Text = utilsController.numberOfProjects().ToString();
            lbDepartments.Text = utilsController.numberOfDepartment().ToString();
            listYear = utilsController.numberOfYear();
            numberOfProject = new List<int>();
            foreach (int year in listYear)
            {
                numberOfProject.Add(utilsController.numberOfPorjectOfYear(year));
                //Console.WriteLine(year);
            }
            //foreach (int numProjects in numberOfProject)
            //{
            //    Console.WriteLine(numProjects);
            //}

        }

        private void paintChart_Paint(object sender, PaintEventArgs e)
        {
            int maxLenthUnderLine = 700;
            int maxLenthBesideLine = 400;
            int eachProject = 20; // height

            int eachDivided = maxLenthUnderLine / listYear.Count;

            // Tool to draw line
            Graphics obj = paintChart.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 1);

            Brush green = new SolidBrush(Color.DarkGreen);
            Pen greenPen = new Pen(green, 2);




            // Tool to draw string
            SolidBrush s = new SolidBrush(Color.Black);
            Graphics g = paintChart.CreateGraphics();
            FontFamily fontFamily = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(fontFamily, 10);
            g.DrawString("2", font, s, new PointF(70, 390));
            g.DrawString("4", font, s, new PointF(70, 340));
            g.DrawString("6", font, s, new PointF(70, 290));
            g.DrawString("8", font, s, new PointF(70, 240));
            g.DrawString("10", font, s, new PointF(70, 190));
            g.DrawString("12", font, s, new PointF(70, 140));
            g.DrawString("14", font, s, new PointF(70, 90));

            int x = 100 + eachDivided;

            foreach (int year in listYear)
            {
                g.DrawString(string.Format("{0}", year), font, s, new PointF(x-20, 470));
                x += eachDivided;
            }

            x = 100 + eachDivided;
            //Point
            Point[] points = new Point[2];
            points[0] = new Point(100, 450);
            foreach (int num in numberOfProject)
            {
                points[1] = new Point(x, 450 - (num * eachProject));

                obj.DrawLine(greenPen, points[0], points[1]);
                points[0] = points[1];

                x += eachDivided;
            }

            // The chart
            obj.DrawLine(blackPen, 100, 60, 100, 450);
            obj.DrawLine(blackPen, 100, 450, 850, 450);

            // Amount of projects
            obj.DrawLine(blackPen, 97, 400, 103, 400);
            obj.DrawLine(blackPen, 97, 350, 103, 350);
            obj.DrawLine(blackPen, 97, 300, 103, 300);
            obj.DrawLine(blackPen, 97, 250, 103, 250);
            obj.DrawLine(blackPen, 97, 200, 103, 200);
            obj.DrawLine(blackPen, 97, 150, 103, 150);
            obj.DrawLine(blackPen, 97, 100, 103, 100);

            // Note
            obj.DrawLine(greenPen, 670, 21, 740, 21);



        }
    }
}
