using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior.DBClass
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            return con;
        }

    }
}
