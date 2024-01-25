using Jazzydior.BusinessClass;
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
    public partial class SearchServices : Form
    {
        Services services = new Services();
        ServicePackage servicePackage = new ServicePackage();
        private readonly SR_NewTransaction mainform;

        public SearchServices(SR_NewTransaction sender)
        {
            this.mainform = sender;
            InitializeComponent();
           
        }

    // Exit Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    // Load Data
        private void Search_Load(object sender, EventArgs e)
        {
            GetServiceRecord();
            GetPackageRecord();
        }

    // Load Package Data to DataGridView
        private void GetPackageRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from servicepackage", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dtgSearchPackage.DataSource = dt;

            // Change the Column Name
            dtgSearchPackage.Columns["pckg_id"].HeaderText = "Package ID No";
            dtgSearchPackage.Columns["pckg_name"].HeaderText = "Package Name";
            dtgSearchPackage.Columns["pckg_serv1"].HeaderText = "Service 1";
            dtgSearchPackage.Columns["pckg_serv2"].HeaderText = "Service 2";
            dtgSearchPackage.Columns["pckg_serv3"].HeaderText = "Service 3";
            dtgSearchPackage.Columns["pckg_serv4"].HeaderText = "Service 4";
            dtgSearchPackage.Columns["pckg_serv5"].HeaderText = "Service 5";
            dtgSearchPackage.Columns["pckg_LeadTime"].HeaderText = "Lead Time";
            dtgSearchPackage.Columns["pckg_Price"].HeaderText = "Price";
        }

    // Load Services Data to DataGridView
        private void GetServiceRecord()
        {
            var query = "Select serv_ID, serv_Name, serv_CategoryID, sc.serv_CategoryName, " +
            "serv_LeadTime, serv_Price from  services s " +
            "INNER JOIN  servicesCategory sc ON s.serv_CategoryID = sc.serv_CatID";


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);


            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("services");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgSearchServices.DataSource = dt;

            // Change the Column Name
            dtgSearchServices.Columns["serv_ID"].HeaderText = "Service ID No";
            dtgSearchServices.Columns["serv_Name"].HeaderText = "Name";
            dtgSearchServices.Columns[2].Visible = false;
            dtgSearchServices.Columns["serv_CategoryID"].HeaderText = "CategoryID";
            dtgSearchServices.Columns["serv_CategoryName"].HeaderText = "Category";
            dtgSearchServices.Columns["serv_LeadTime"].HeaderText = "Lead Time";
            dtgSearchServices.Columns["serv_Price"].HeaderText = "Price";
        }

        private void dtgSearchServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewRow selectedData =  dtgSearchServices.SelectedRows[0];
            
            mainform.TransactService(
                
                new ServiceRecord {
                    Service_ID = (int)selectedData.Cells[0].Value ,
                    Service_Name = selectedData.Cells[1].Value.ToString(),
                    Service_CategoryID = (int)selectedData.Cells[2].Value,
                    Service_CategoryName = selectedData.Cells[3].Value.ToString(),
                    Service_LeadTime = selectedData.Cells[4].Value.ToString(),
                    Service_Price = (decimal)selectedData.Cells[5].Value
                }
                );
            

        }

        private void dtgSearchPackage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedData = dtgSearchPackage.SelectedRows[0];

            mainform.TransactPackage(new PackageRecord
            {
                Package_ID = (int)selectedData.Cells[0].Value,
                Package_Name = selectedData.Cells[1].Value.ToString(),
                Service_1 = selectedData.Cells[2].Value.ToString(),
                Service_2 = selectedData.Cells[3].Value.ToString(),
                Service_3 = selectedData.Cells[4].Value.ToString(),
                Service_4 = selectedData.Cells[5].Value.ToString(),
                Service_5 = selectedData.Cells[6].Value.ToString(),
                Package_LeadTime = selectedData.Cells[7].Value.ToString(),
                Package_Price = (decimal)selectedData.Cells[8].Value
            });
        }

    }
}
