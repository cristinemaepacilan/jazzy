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
            GetTransaction();
        }

        private void dtgSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void GetTransaction()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="spGetTransactionReports";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("transaction");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgSalesReport.DataSource = dt;

            // Change the Column Name
            dtgSalesReport.Columns["transact_ID"].Visible = false;
            dtgSalesReport.Columns["transact_No"].HeaderText = "Transaction No";
            dtgSalesReport.Columns["Customer Name"].HeaderText = "Customer";
            //dtgTransactionRep.Columns[2].Visible = false;
            dtgSalesReport.Columns["Staff Name"].HeaderText = "Staff";
            dtgSalesReport.Columns["Transaction Date"].HeaderText = "Date";
            dtgSalesReport.Columns["transact_AmountTendered"].HeaderText ="Amount Tendered";
            dtgSalesReport.Columns["transact_Total"].HeaderText = "Total";
            dtgSalesReport.Columns["transact_Discount"].HeaderText = "Discount";
            dtgSalesReport.Columns["transact_AmountDue"].HeaderText = "Amount Due";
            dtgSalesReport.Columns["transact_VATSales"].HeaderText = "VAT Sales";
            dtgSalesReport.Columns["transact_VATAmount"].HeaderText = "VAT Amount";


        }



        private void SearchByDate()
        {
            DateTime DateFrom = dateTimePickerArchiveServiceFrom.Value;
            DateTime DateTo = dateTimePickerArchiveServiceTo.Value;
            GetTransaction();

            var df = DateFrom.Date;
            var t = DateTo.Date;
            Console.WriteLine(df);
            Console.WriteLine(t);

            if (DateFrom == DateTime.Today && DateTo == DateTime.Today)
            {
                return;
            }




            DataTable dt = (DataTable)dtgSalesReport.DataSource;
            var col = dt.Columns;

            try
            {


                dt.DefaultView.RowFilter = $"CONVERT([Transaction Date], 'System.DateTime') >= #{DateFrom.Date}# AND CONVERT([Transaction Date], 'System.DateTime') < #{DateTo.Date.AddDays(1)}#";


            }
            catch (Exception error)
            {
                MessageBox.Show($"Error while filtering: "+ error.Message);
                GetTransaction();

            }


            dtgSalesReport.DataSource = dt.DefaultView.ToTable();



        }

        private void txtBoxArchiveServiceSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxArchiveServiceSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                GetTransaction();
            }
            else
            {
                if (dtgSalesReport.DataSource != null)
                {

                    DataTable dt = (DataTable)dtgSalesReport.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"[Customer Name] LIKE '%{keyword}%'"+

                        $"OR [transact_No] LIKE '%{keyword}%' " +
                        $"OR [Staff Name] LIKE '%{keyword}%' ";
                      
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetTransaction();
                    }


                    dtgSalesReport.DataSource = dt.DefaultView.ToTable();
                }

            }
        }

        private void dateTimePickerArchiveServiceFrom_ValueChanged(object sender, EventArgs e)
        {
            SearchByDate();
        }

        private void dateTimePickerArchiveServiceTo_ValueChanged(object sender, EventArgs e)
        {
            SearchByDate();
        }

        private void dtgSalesReport_DataSourceChanged(object sender, EventArgs e)
        {
            decimal totalSales = 0.00M;
            foreach(DataGridViewRow row in dtgSalesReport.Rows)
            {

                totalSales += Convert.ToDecimal(row.Cells["transact_AmountDue"].Value);

            }

            textBoxSalesTotal.Text = totalSales.ToString();
        }
    }
}
