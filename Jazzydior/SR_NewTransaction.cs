using Jazzydior.BusinessClass;
using Jazzydior.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class SR_NewTransaction : Form
    {
        Reports reports = new Reports();

        public Stack<ServiceRecord> servicesStack = new Stack<ServiceRecord>();
        public Stack<PackageRecord> packageStack = new Stack<PackageRecord>();
        public DataGridViewRow currentSelectedRow;

        public Transact transaction = new Transact()
        {

            AmountTendered = 0,
            AmountDue = 0,
            Change = 0,
            VAT = 0,
            Vatable = 0,
            TransNo = 0

        };

        public SR_NewTransaction()
        {
            InitializeComponent();

            txtBoxTendered.TextChanged += txtBoxTendered_TextChanged;
            txtBoxAmountDue.TextChanged += txtBoxAmountDue_TextChanged;
        }


        // Back to Home Page
        private void btnExitSeviceForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
            }
        }


        // Load Data
        private void SR_AddNewTransaction_Load(object sender, EventArgs e)
        {
            NewTransaction();
            LoadComboboxStaffName();
        }


        // Load ComboBox Staff Name
        private void LoadComboboxStaffName()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(" SELECT staff_ID , CONCAT(staff_FName , ' ',staff_LName) StaffName FROM  staffs ", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable src = new DataTable();
                src.Load(sdr);

                cmbTransactStaffFName.DisplayMember = "StaffName";
                cmbTransactStaffFName.ValueMember = "staff_ID";
                cmbTransactStaffFName.DataSource = src;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            con.Close();

        }


        // Load Transaction Data to DataGridView
        private void GetServiceRecord()
        {
            // DataGrid for Service List

            dtgServiceTransact.Columns["Service_ID"].HeaderText = "Service ID No";
            dtgServiceTransact.Columns["Service_Name"].HeaderText = "Service Name";
            dtgServiceTransact.Columns["Service_CategoryID"].HeaderText = "CategoryID";
            dtgServiceTransact.Columns["Service_CategoryName"].HeaderText = "Category";
            dtgServiceTransact.Columns["Service_LeadTime"].HeaderText = "Lead Time";
            dtgServiceTransact.Columns["Service_Price"].HeaderText = "Price";

            dtgServiceTransact.Columns[0].Visible = false;
            dtgServiceTransact.Columns[2].Visible = false;
            dtgServiceTransact.Columns[3].Visible = false;
        }

        private void GetPackageRecord()
        {
            //DataGrid for Package List


            dtgPackageTransact.Columns["Package_Id"].HeaderText = "Package ID No";
            dtgPackageTransact.Columns["Package_Name"].HeaderText = "Package Name";
            dtgPackageTransact.Columns["Service_1"].HeaderText = "Service 1";
            dtgPackageTransact.Columns["Service_2"].HeaderText = "Service 2";
            dtgPackageTransact.Columns["Service_3"].HeaderText = "Service 3";
            dtgPackageTransact.Columns["Service_4"].HeaderText = "Service 4";
            dtgPackageTransact.Columns["Service_5"].HeaderText = "Service 5";
            dtgPackageTransact.Columns["Package_LeadTime"].HeaderText = "Lead Time";
            dtgPackageTransact.Columns["Package_Price"].HeaderText = "Price";


            dtgPackageTransact.Columns[0].Visible = false;
            dtgPackageTransact.Columns[2].Visible = false;
            dtgPackageTransact.Columns[3].Visible = false;
            dtgPackageTransact.Columns[4].Visible = false;
            dtgPackageTransact.Columns[5].Visible = false;
            dtgPackageTransact.Columns[6].Visible = false;
        }


        // Generate Automatic Transaction No and DateTime
        private void NewTransaction()
        {
            dtgServiceTransact.Rows.Clear();

            lblNewTransactNum.Text = GenerateTransactionNumber().ToString();
            lblNewTransactDateTime.Text = DateTime.Now.ToLongDateString();
            lblNewTransactTime.Text = DateTime.Now.ToLongTimeString();
            lblSalesTotal.Text = "0.00";


        }


        // Generate Transaction Number
        private string GenerateTransactionNumber()
        {
            Random random = new Random();
            string transactionNumber = "";

            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(0, 10);
                transactionNumber += number.ToString();
            }

            return transactionNumber;
        }


        // Search Services Button
        private void btnNewTransactService_Click(object sender, EventArgs e)
        {
            SearchServices frm = new SearchServices(this);
            frm.Show();
        }


        // Computation in Transaction Package
        public void TransactPackage(PackageRecord data)
        {
            // Compute Amount Due
            this.transaction.AmountDue += data.Package_Price;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            // Comput Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;

            lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);

            lblSalesTotal.Text = this.transaction.AmountDue.ToString();

            packageStack.Push(data);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = packageStack;
            dtgPackageTransact.DataSource = bindingSource;
            GetPackageRecord();
        }


        #region Calculator


        // Button 1
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "1";
            }
            else txtBoxTendered.Text += 1;
        }

        // Button 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "2";
            }
            else txtBoxTendered.Text += 2;
        }

        // Button 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "3";
            }
            else txtBoxTendered.Text += 3;
        }

        // Button 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "4";
            }
            else txtBoxTendered.Text += 4;
        }

        // Button 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "5";
            }
            else txtBoxTendered.Text += 5;
        }

        // Button 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "6";
            }
            else txtBoxTendered.Text += 6;
        }

        // Button 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "7";
            }
            else txtBoxTendered.Text += 7;
        }

        // Button 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "8";
            }
            else txtBoxTendered.Text += 8;
        }

        // Button 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "9";
            }
            else txtBoxTendered.Text += 9;
        }

        // Button 0
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text == "0.00" || txtBoxTendered.Text == "0" || txtBoxTendered.Text == string.Empty)
            {
                txtBoxTendered.Text = "0";
            }
            else txtBoxTendered.Text += 0;
        }

        // Backspace Button
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtBoxTendered.Text.Length > 0)
            {
                txtBoxTendered.Text = txtBoxTendered.Text.Remove(txtBoxTendered.Text.Length - 1, 1);
            }

            if (txtBoxTendered.Text == "")
            {
                txtBoxTendered.Text = "0";
            }
        }
        #endregion


        // Clear txtBoxAmountTendered Button
        private void btnC_Click(object sender, EventArgs e)
        {
            txtBoxTendered.Clear();
        }


        // Number only in TextBoxAmountTendered
        private void txtBoxTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        // Settle Payment Form
        private void btnNewTransactPayment_Click(object sender, EventArgs e)
        {

            int count = dtgServiceTransact.Rows.Count;
            if (count < 1)
            {
                return;
            }

            panelSettlePayment.Visible = true;
            txtBoxAmountDue.Text = this.transaction.AmountDue.ToString();
        }


        // Clear Cart
        private void btnNewTransactClear_Click(object sender, EventArgs e)
        {
            dtgServiceTransact.Rows.Clear();
            dtgPackageTransact.Rows.Clear();
        }


        // Add Discount Form
        private void btnNewTransactDiscount_Click(object sender, EventArgs e)
        {
            SR_Discount frm = new SR_Discount(this);
            frm.Show();
        }


       


        // Calculate Change in Settle Payment
        public void SettlePayment()
        {
            if (double.TryParse(txtBoxTendered.Text, out double value1) && double.TryParse(txtBoxAmountDue.Text, out double value2))
            {
                txtBoxChange.Text = (value1 - value2).ToString();
            }
        }


        // Computation in Transaction Services
        public void TransactService(ServiceRecord data)
        {
            // Compute Amount Due
            this.transaction.AmountDue += data.Service_Price;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            //Compute Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;


            lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);

            lblSalesTotal.Text = this.transaction.AmountDue.ToString();



            servicesStack.Push(data);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = servicesStack;
            dtgServiceTransact.DataSource = bindingSource;
            GetServiceRecord();
        }


        // Process UI
        public void ProcessUI()
        {
            lblAmountDue.Text = string.Format("{0:0.##}", this.transaction.AmountDue);
            lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);
            lblSalesTotal.Text = this.transaction.AmountDue.ToString();
            lblDiscount.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Discount);
        }


        // Calculate Change
        private void txtBoxTendered_TextChanged(object sender, EventArgs e)
        {
            SettlePayment();
        }


        private void txtBoxAmountDue_TextChanged(object sender, EventArgs e)
        {
            SettlePayment();
        }


        // Save Transaction Details to Reports
        private void btnOkay_Click(object sender, EventArgs e)
        {  
            reports.TransactionNo = lblNewTransactNo.Text;
            reports.CustomerName = txtBoxCustName.Text;
            reports.TransService = dtgServiceTransact.Text;
            reports.TransStaffID = Convert.ToInt32(cmbTransactStaffFName.SelectedValue);
            reports.Discount = lblDiscount.Text;
            //reports.TransDate = lblNewTransactDateTime.Text;
            //reports.TransTime = lblNewTransactDate.Text;
            reports.TransAmountTendered = lblAmountTendered.Text;
            reports.TransAmountDue = lblSalesTotal.Text;
            reports.TransVATSales = lblVAT.Text;
            reports.TransVATAmount = lblVatable.Text;

            int trans_ID = ReportsDB.AddReports(reports);

            if(trans_ID != 0)
            {
                //printDocument1.Print();
                printPreviewDialog1.ShowDialog();
            }
            //Receipt frm = new Receipt();
            //frm.Show();

        }
        // Remove Services to Table Cart
        private void btnRemoveServices_Click(object sender, EventArgs e)
        {
            
            transaction.AmountDue -= (decimal)currentSelectedRow.Cells[5].Value;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            //Compute Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;

            dtgServiceTransact.Rows.Remove(currentSelectedRow);
            ProcessUI();

        }

        private void dtgServiceTransact_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            currentSelectedRow = dtgServiceTransact.SelectedRows[0];
                 


            //dtgServiceTransact.Rows.Remove(selectedData);

            //mainform.TransactService(

            //    new ServiceRecord
            //    {
            //        Service_ID = (int)selectedData.Cells[0].Value,
            //        Service_Name = selectedData.Cells[1].Value.ToString(),
            //        Service_CategoryID = (int)selectedData.Cells[2].Value,
            //        Service_CategoryName = selectedData.Cells[3].Value.ToString(),
            //        Service_LeadTime = selectedData.Cells[4].Value.ToString(),
            //        Service_Price = (decimal)selectedData.Cells[5].Value
            //    }
            //    );
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image logo = Image.FromFile(@"C:\Users\admin\Downloads\logo.png");
            
            e.Graphics?.DrawImage(ResizeImage(logo,100,100), new Point(50, 50));
            e.Graphics.DrawString("**********************", new Font(FontFamily.GenericMonospace,12,FontStyle.Bold), Brushes.Black, new Point(1, 20));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            
        }
        private Image ResizeImage(Image image, int newWidth, int newHeight)
        {
            // Create a new Bitmap with the desired size
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            // Create a Graphics object to draw on the new Bitmap
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                // Set the interpolation mode to HighQualityBicubic for better quality
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the new Bitmap with the specified size
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }
    }
}
