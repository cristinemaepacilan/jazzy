using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzydiorBeautyLounge_SMSwCR.Forms
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True";
            return con;
        }
    }
}
