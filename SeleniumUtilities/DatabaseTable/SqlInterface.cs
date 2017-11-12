using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUtilities.DatabaseTable
{
    public class SqlInterface
    {
        private static string sServerName = @"VMDEVTEST01\SQLEXPRESS";
        private static string sDatabaseName = @"QAAutomationTest";
        private static string sUserName = @"qaautomationtest";
        private static string sPasswordName = @"qaautomationtest1234";

        public static string ServerName
        {
            set { sServerName = value; }
        }

        public static string DatabaseName
        {
            set { sDatabaseName = value; }
        }

        public static string UserName
        {
            set { sUserName = value; }
        }

        public static string Password
        {
            set { sPasswordName = value; }
        }

        private static string ConnectionString = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password=qaautomationtest1234", sServerName, sDatabaseName, sUserName, sPasswordName);

        public static bool ExecuteQuery(string QueryString)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand(QueryString, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }
        }
    }
}
