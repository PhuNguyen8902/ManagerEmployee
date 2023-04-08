using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Interop;
using System.Windows.Markup;

namespace EmployeesManagement.Connection
{
    class Connection
    {
        //Connection cua Phu
        //private static String conn = @"Data Source=MSI;User ID=sa;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //private static String conn = @"Data Source=MSI;User ID=sa;Password = 123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        //Connection cua Phan
        //private static String conn = @"Data Source=MSI;User ID=sa;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private static String conn = "Server = DESKTOP-V6TTSBE; Database = employeeDB; Integrated Security = true;";
        //Data Source = MSI; Initial Catalog = employeeDB; User ID = sa
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }

    }
}
