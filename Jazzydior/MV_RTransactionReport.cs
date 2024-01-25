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
    public partial class MV_RTransactionReport : Form
    {
        public MV_RTransactionReport()
        {
            InitializeComponent();
            GetSalesRecord();
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

            dataGridViewTransactionReport.DataSource = dt;

            // Change the Column Name
            dataGridViewTransactionReport.Columns["transact_No"].HeaderText = "Transaction No";
            dataGridViewTransactionReport.Columns["trans_CustName"].HeaderText = "Customer Name";
            dataGridViewTransactionReport.Columns["Staff Name"].HeaderText = "Staff Name";
            //dtgTransactionRep.Columns[2].Visible = false;
            dataGridViewTransactionReport.Columns["transact_Time"].HeaderText = "Date";
            dataGridViewTransactionReport.Columns["transact_AmountDue"].HeaderText = "Amount Due";
            dataGridViewTransactionReport.Columns["transact_AmountTendered"].HeaderText ="Amount Tendered";
            dataGridViewTransactionReport.Columns["Service Availed"].HeaderText = "Service Availed";
        }
        private void SearchByDate()
        {
            DateTime DateFrom = dateTimePickerTransactionFrom.Value;
            DateTime DateTo = dateTimePickerTransactionTo.Value;
            GetSalesRecord();

            var df = DateFrom.Date;
            var t = DateTo.Date;
            Console.WriteLine(df);
            Console.WriteLine(t);

            if (DateFrom == DateTime.Today && DateTo == DateTime.Today)
            {
                return;
            }




            DataTable dt = (DataTable)dataGridViewTransactionReport.DataSource;
            var col = dt.Columns;

            try
            {


                dt.DefaultView.RowFilter = $"CONVERT(transact_Time, 'System.DateTime') >= #{DateFrom.Date}# AND CONVERT(transact_Time, 'System.DateTime') < #{DateTo.Date.AddDays(1)}#";


            }
            catch (Exception error)
            {
                MessageBox.Show($"Error while filtering: "+ error.Message);
                GetSalesRecord();

            }


            dataGridViewTransactionReport.DataSource = dt.DefaultView.ToTable();



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
                if (dataGridViewTransactionReport.DataSource != null)
                {

                    DataTable dt = (DataTable)dataGridViewTransactionReport.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"trans_CustName LIKE '%{keyword}%'"+
                            $"OR [transact_No] LIKE '%{keyword}%' " +
                        $"OR [Staff Name] LIKE '%{keyword}%' " +
                        $"OR [Service Availed] LIKE '%{keyword}%' ";
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetSalesRecord();
                    }


                    dataGridViewTransactionReport.DataSource = dt.DefaultView.ToTable();
                }

            }
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
