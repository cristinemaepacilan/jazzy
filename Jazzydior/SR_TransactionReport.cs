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
    public partial class SR_TransactionReport : Form
    {

        public SR_TransactionReport()
        {
            InitializeComponent();
        }

        private void SR_TransactionReport_Load(object sender, EventArgs e)
        {
            GetSalesRecord();
            //dateTimePickerTransactionFrom.Value = new DateTime().AddDays(-7);
            //dateTimePickerTransactionTo.Value = DateTime.Today;
        }

        public void GetSalesRecord()
        {
            //var query = "SELECT * FROM reports";


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="spGetTransactionRecords";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("transaction");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgTransactionRep.DataSource = dt;

            // Change the Column Name
            dtgTransactionRep.Columns["trans_CustName"].HeaderText = "Customer Name";
            dtgTransactionRep.Columns["Staff Name"].HeaderText = "Staff Name";
            //dtgTransactionRep.Columns[2].Visible = false;
            dtgTransactionRep.Columns["transact_Time"].HeaderText = "Date";
            dtgTransactionRep.Columns["transact_AmountDue"].HeaderText = "Amount Due";
            dtgTransactionRep.Columns["transact_AmountTendered"].HeaderText ="Amount Tendered";
            dtgTransactionRep.Columns["Service Availed"].HeaderText = "Service Availed";
        }

        private void txtBoxTransactionSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxTransactionSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                GetSalesRecord();
            }
            else
            {
                if (dtgTransactionRep.DataSource != null)
                {

                    DataTable dt = (DataTable)dtgTransactionRep.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"trans_CustName LIKE '%{keyword}%'"+

                        $"OR [Staff Name] LIKE '%{keyword}%' " +
                        $"OR [Service Availed] LIKE '%{keyword}%' ";
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetSalesRecord();
                    }


                    dtgTransactionRep.DataSource = dt.DefaultView.ToTable();
                }

            }
        }


        private void SearchByDate()
        {
            DateTime DateFrom =dateTimePickerTransactionFrom.Value;
            DateTime DateTo =dateTimePickerTransactionTo.Value;


    

            if (DateFrom == DateTime.Today && DateTo == DateTime.Today)
            {
                return;
            }


            if (dtgTransactionRep.DataSource != null)
            {

                DataTable dt = (DataTable)dtgTransactionRep.DataSource;
                var col = dt.Columns;

                try
                {

                    FilterByDate(DateFrom, DateTo);

                    ////dt.DefaultView.RowFilter = $"transact_Time BETWEEN '%{DateFrom.ToShortDateString()}%' AND '%{DateTo.ToShortDateString()}%' ";
                    ////dt.DefaultView.RowFilter = $" CONVERT(DATE,transact_Time) >= '{DateFrom.ToShortDateString()}' AND CONVERT(DATE,transact_Time) <= '{DateFrom.ToShortDateString()}'";
                    ////dt.DefaultView.RowFilter = $"transact_Time >= #" + DateFrom.ToString("yyyy-MM-dd") + "# AND transact_Time < #" + DateFrom.ToString("yyyy-MM-dd") + "#";
                    //dt.DefaultView.RowFilter = $"transact_Time BETWEEN #{DateFrom.ToString("yyyy-MM-dd")}# AND #{DateTo.ToString("yyyy-MM-dd")}#";


                    //$"OR [Staff Name] LIKE '%{keyword}%' " +
                    //$"OR [Service Availed] LIKE '%{keyword}%' ";
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    GetSalesRecord();
                }


                dtgTransactionRep.DataSource = dt.DefaultView.ToTable();
            }


        }

        private void FilterByDate(DateTime DateFrom , DateTime DateTo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="FilterTransactionByDate";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DateFrom", DateFrom);
            cmd.Parameters.AddWithValue("@DateTo", DateTo);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("transaction");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();
            
            dtgTransactionRep.DataSource = dt;

            // Change the Column Name
            dtgTransactionRep.Columns["trans_CustName"].HeaderText = "Customer Name";
            dtgTransactionRep.Columns["Staff Name"].HeaderText = "Staff Name";
            //dtgTransactionRep.Columns[2].Visible = false;
            dtgTransactionRep.Columns["transact_Time"].HeaderText = "Date";
            dtgTransactionRep.Columns["transact_AmountDue"].HeaderText = "Amount Due";
            dtgTransactionRep.Columns["transact_AmountTendered"].HeaderText ="Amount Tendered";
            dtgTransactionRep.Columns["Service Availed"].HeaderText = "Service Availed";

        }

        private void dateTimePickerTransactionFrom_ValueChanged(object sender, EventArgs e)
        {
            SearchByDate();
        }

        private void dateTimePickerTransactionTo_ValueChanged(object sender, EventArgs e)
        {
            SearchByDate();
        }
    }
}
