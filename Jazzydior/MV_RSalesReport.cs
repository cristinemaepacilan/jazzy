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

        private void dtgSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void GetTransaction()
        {
            var query = "SELECT * FROM reports";


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);


            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("transaction");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgSalesReport.DataSource = dt;

            // Change the Column Name
            dtgSalesReport.Columns["trans_CustName"].HeaderText = "Service ID No";
            dtgSalesReport.Columns["serv_Name"].HeaderText = "Name";
            dtgSalesReport.Columns[2].Visible = false;
            dtgSalesReport.Columns["serv_CategoryID"].HeaderText = "CategoryID";
            dtgSalesReport.Columns["serv_CategoryName"].HeaderText = "Category";
            dtgSalesReport.Columns["serv_LeadTime"].HeaderText = "Lead Time";
            dtgSalesReport.Columns["serv_Price"].HeaderText = "Price";

        }
    }
}
