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
    public partial class MV_ReportsMainForm : Form
    {
        public MV_ReportsMainForm()
        {

            InitializeComponent();
            GetSalesRecord();
        }
 //Transaction Report Button
        private void btnTransactionReport_Click(object sender, EventArgs e) { 
            MV_RTransactionReport frm = new MV_RTransactionReport();
               frm.TopLevel = false;
            panelSwitchReport.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

 //Sales Report Button
        private void btnSalesReport_Click_1(object sender, EventArgs e)
        {
            MV_RSalesReport frm = new MV_RSalesReport();
            frm.TopLevel = false;
            panelSwitchReport.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

// Exit Application
        private void btnLogoutReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }




        private void GetSalesRecord()
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
