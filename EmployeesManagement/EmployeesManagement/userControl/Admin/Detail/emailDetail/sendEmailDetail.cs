using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    public partial class sendEmailDetail : Form
    {
        public sendEmailDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string fromAddress = "phunguyen8902@gmail.com";
            //string toAddress = "anhphu892002@gmail.com";
            //string pass = "qhxexlsxrwmncjdd";
            //string body = "Hello";
            //MailMessage mail = new MailMessage();
            //mail.To.Add(toAddress);
            //mail.From = new MailAddress(fromAddress);
            //mail.Subject = "test thu";
            //mail.Body = body;
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential(fromAddress, pass);
            //smtp.Timeout = 20000; 
            //smtp.DeliveryFormat = SmtpDeliveryFormat.International; 

            //try
            //{
            //    smtp.Send(mail);
            //    MessageBox.Show("thanh cong roi");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
