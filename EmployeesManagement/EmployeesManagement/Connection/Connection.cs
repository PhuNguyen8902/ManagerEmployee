using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeesManagement.Connection
{
    class Connection
    {
        //Connection cua Phu
        //private static String conn = @"Data Source=MSI;User ID=sa;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private static String conn = @"Data Source=MSI;User ID=sa;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        //Connection cua Phan
        //private static String conn = @"Data Source=MSI;User ID=sa;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }

    }
}
