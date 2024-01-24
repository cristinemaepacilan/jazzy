using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class MV_RSalesReport : Form
    {
        public MV_RSalesReport()
        {
            InitializeComponent();
        }

        private void btnSalesPrintReview_Click_1(object sender, EventArgs e)
        {
            MV_RSalesPrintReview frm = new MV_RSalesPrintReview();
            frm.Show();
        }

        private void MV_RSalesReport_Load(object sender, EventArgs e)
        {
            //GetSalesRecord();
        }

        //private void GetSalesRecord()
        //{
        //        var query = "Select trans_ID, trans_No, trans_CustName, trans_Service, trans_StaffID, st.staff_FName, " +
        //        "trans_Discount, trans_Date, trans_AmountTendered, trans_AmountDue, trans_VATSales, trans_VATAmount, trans_Time from  reports r " +
        //        "INNER JOIN  staffs st ON r.StaffID = st.staff_ID";


        //        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
        //        SqlCommand cmd = new SqlCommand(query, con);


        //        con.Open();
        //        SqlDataReader sdr = cmd.ExecuteReader();
        //        DataTable dt = new DataTable("reports");
        //        dt.Load(sdr);
        //        var tname = dt.TableName;
        //        con.Close();

        //        dtgSalesReport.DataSource = dt;
        //}
    }
}
