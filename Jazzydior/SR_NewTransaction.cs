using Jazzydior.BusinessClass;
using Jazzydior.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
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
        public DataGridViewRow currentSelectedRowServices;
        public DataGridViewRow currentSelectedRowPackages;

        public Transact transaction = new Transact()
        {
           
            AmountTendered = 0,
            AmountDue = 0,
            Change = 0,
            VAT = 0,
            Vatable = 0,
            TransNo = 0,
            TotalAmount = 0

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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
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
        private void DrawDataGridForServices()
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

        private void DrawDataGridForPackages()
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
            this.transaction.TransactionNo = GenerateTransactionNumber();
            lblNewTransactNum.Text = transaction.TransactionNo.ToString();
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


       

        #region -- Calculator --


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
        // Clear txtBoxAmountTendered Button
        private void btnC_Click(object sender, EventArgs e)
        {
            txtBoxTendered.Clear();
        }

        #endregion


        #region -- Transaction Control --

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
            count += dtgPackageTransact.Rows.Count;
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
        public void ProcessChange()
        {
            if (double.TryParse(txtBoxTendered.Text, out double value1) && double.TryParse(txtBoxAmountDue.Text, out double value2))
            {
                txtBoxChange.Text = (value1 - value2).ToString();
            }
        }

        #endregion

        // Computation in Transaction Services
        public void TransactService(ServiceRecord data)
        {   
            
            // Persist data of the total amount , before VATs and discounts
            this.transaction.TotalAmount +=data.Service_Price;
            // Compute Amount Due
            this.transaction.AmountDue += data.Service_Price;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            //Compute Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;


            //lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            //lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);
            //lblSalesTotal.Text = this.transaction.AmountDue.ToString();
            ProcessUI();


            servicesStack.Push(data);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = servicesStack;
            dtgServiceTransact.DataSource = bindingSource;
            DrawDataGridForServices();
        }

        // Computation in Transaction Package
        public void TransactPackage(PackageRecord data)
        {
            // Persist data of the total amount , before VATs and discounts
            this.transaction.TotalAmount +=data.Package_Price;
            // Compute Amount Due
            this.transaction.AmountDue += data.Package_Price;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            // Comput Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;

            //lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            //lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);

            //lblSalesTotal.Text = this.transaction.AmountDue.ToString();
            ProcessUI();

            packageStack.Push(data);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = packageStack;
            dtgPackageTransact.DataSource = bindingSource;
            DrawDataGridForPackages();
        }



        // Process UI
        public void ProcessUI()
        {
            //lblAmountDue.Text = string.Format("{0:0.##}", this.transaction.AmountDue);
            lblSalesTotal.Text = transaction.AmountDue.ToString("0.00");
            lblVAT.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.VAT);
            lblVatable.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Vatable);
            //lblSalesTotal.Text = this.transaction.AmountDue.ToString();
            lblDiscount.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Discount);
            lblTotal.Text = string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.TotalAmount);
        }


        // Calculate Change
        private void txtBoxTendered_TextChanged(object sender, EventArgs e)
        {
            transaction.AmountTendered = Convert.ToDecimal(txtBoxTendered.Text);
            ProcessChange();
        }


        private void txtBoxAmountDue_TextChanged(object sender, EventArgs e)
        {
            ProcessChange();
        }


        // Save Transaction Details to Reports
        private void btnOkay_Click(object sender, EventArgs e)
        {  
            reports.TransactionNo = transaction.TransactionNo;
            reports.CustomerName = txtBoxCustName.Text ?? "Unnamed Customer";
            reports.TransStaffID = Convert.ToInt32(cmbTransactStaffFName.SelectedValue);
            reports.Discount = transaction.Discount;
            reports.TransAmountTendered = transaction.AmountTendered;
            reports.TransAmountDue = transaction.AmountDue;
            reports.TransTotalAmount = transaction.TotalAmount;
            reports.TransVATSales = transaction.VAT;
            reports.TransVATAmount = transaction.Vatable;
            





            int trans_ID = ReportsDB.AddReports(reports);

            if(dtgPackageTransact.Rows.Count > 0) {
                InsertRowsIntoDatabase(dtgPackageTransact, trans_ID, true);
            }
            if(dtgServiceTransact.Rows.Count > 0)
            {
                InsertRowsIntoDatabase(dtgServiceTransact, trans_ID, false);
            }
           
          

            if (trans_ID != 0)
            {
                //printDocument1.Print();
                //printPreviewDialog1.ShowDialog();

                ProcessPrinting();
                panelSettlePayment.Dispose();

            }
            //Receipt frm = new Receipt();
            //frm.Show();

        }

        private void InsertRowsIntoDatabase(DataGridView dataGridView, int transactionID , bool isPackage)
        {

            if(dataGridView == null) return;
            if(transactionID == 0 ) return;
            
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True"))
            {
                connection.Open();
               
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!isPackage) {
                        //FOR SERVICES
                        string query = "INSERT INTO transactionjunction (transact_ID, serv_ID) VALUES (@transactID, @servID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@transactID", transactionID);
                            command.Parameters.AddWithValue("@servID", row.Cells["Service_ID"].Value);
                            command.ExecuteNonQuery();
                        }


                    }
                    else
                    {
                        // FOR SERVICES PACKAGE
                        string query = "INSERT INTO transactionjunction (transact_ID, servpack_ID) VALUES (@transactID, @servpackID)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@transactID", transactionID);
                            command.Parameters.AddWithValue("@servpackID", row.Cells["Package_Id"].Value);
                            command.ExecuteNonQuery();
                        }

                    }
                    


                      
                    
                }
            }
        }



        #region -- Removing of Queued Services/Packages --
        private void dtgServiceTransact_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            currentSelectedRowServices = dtgServiceTransact.SelectedRows[0];
                 


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
        private void dtgPackageTransact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedRowPackages = dtgPackageTransact.SelectedRows[0];
        }
        private void btnRemoveServices_Click(object sender, EventArgs e)
        {
            
            if(currentSelectedRowPackages == null && currentSelectedRowServices == null)
            {   //break the flow, since we can't process anything without selection
                return;

            }

            if(currentSelectedRowServices != null)
            {
                RemoveInCart<DataGridViewRow, DataGridView>(currentSelectedRowServices, dtgServiceTransact, false);
            }
            else if (currentSelectedRowPackages != null)
            {
                RemoveInCart<DataGridViewRow, DataGridView>(currentSelectedRowPackages, dtgPackageTransact, true);
            }
           

            ProcessUI();



        }

        private void RemoveInCart<T,S>(T SelectionType, S DGV , bool ispackage) 
                where T :  DataGridViewRow
                where S : DataGridView
        {
            var priceColumn = ispackage ? 8 : 5;

            transaction.TotalAmount -= (decimal)SelectionType.Cells[priceColumn].Value;

            transaction.AmountDue -= (decimal)SelectionType.Cells[priceColumn].Value;
            // Compute VAT
            this.transaction.VAT = this.transaction.AmountDue * 0.12M;
            //Compute Vatable
            this.transaction.Vatable = this.transaction.AmountDue - this.transaction.VAT;
            // remove the row from the corresponding datagrid
            DGV.Rows.Remove(SelectionType);

            // set the selection back to null
            currentSelectedRowPackages = null;
            currentSelectedRowServices = null;
            SelectionType = null;
            DGV.ClearSelection();
            DGV = null;
            ProcessUI();
        }


        #endregion
        #region -- Printing Invoice --

        private void ProcessPrinting()
        {
            PrinterSettings printerSettings = new PrinterSettings();
            PaperSize paperSize = new PaperSize("Custom", 100, 200);
            //printerSettings.PrinterName = 
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Document.DefaultPageSettings.PaperSize = paperSize;

            printDocument1.DefaultPageSettings.PaperSize.Height= 820;//820
            printDocument1.DefaultPageSettings.PaperSize.Width= 520;//520

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            DialogResult result = printPreviewDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = printDocument1;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }



        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image logo = Image.FromFile(@"../../Resources/logo.png");


            //e.Graphics.DrawString("**********************", new Font(FontFamily.GenericMonospace,12,FontStyle.Bold), Brushes.Black, new Point(1, 20));
            //e.Graphics.DrawString(
            //    "JAZZYDIOR BEAUTY LOUNGE", 
            //    new Font(FontFamily.GenericSansSerif, 15,FontStyle.Bold),

            //    Brushes.DeepPink,
            //     new Point(Top, 20));
            //e.Graphics.DrawString("Pres ML Quezon, Suba, Bantayan, Cebu",new Font(FontFamily.GenericMonospace,12,FontStyle.Italic),
            //Brushes.Black,
            //new Point(30,30)
            // );




            Graphics graphics = e.Graphics;
            Font font = new Font("Consolas", 10); //Courier New
            float fontHeight = font.GetHeight();
            int startX = 35;
            int startY = 55;
            int Offset = 40;
            String underLine = "---------------------------------";
             graphics.DrawImage(ResizeImage(logo, 60, 60),startX+180,startY + Offset);
            Offset = Offset + 70;
            graphics.DrawString("Welcome to JazzyDior Beauty Lounge", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX+10, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Pres ML Quezon, Suba, Bantayan, Cebu", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Transaction Date: " + DateTime.Now.ToString(), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Staff: " + cmbTransactStaffFName.Text, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Customer : " + txtBoxCustName.Text, new Font("Courier New", 12 , FontStyle.Italic), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString(underLine, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

            if(dtgServiceTransact.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dtgServiceTransact.Rows)
                {

                    graphics.DrawString(row.Cells[1].Value.ToString()+"   "+row.Cells[5].Value.ToString(), new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                }
               


            }

            if (dtgPackageTransact.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgPackageTransact.Rows)
                {

                    graphics.DrawString(row.Cells[1].Value.ToString()+"   "+row.Cells[8].Value.ToString(), new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Black), startX, startY + Offset);
                    Offset = Offset + 20;
                }



            }




            graphics.DrawString(underLine, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Amount Due: " + string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.AmountDue), new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Total: " + string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.TotalAmount), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;


            if(transaction.Discount > 0)
            {
                graphics.DrawString("Discount: " + string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.Discount), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
                Offset = Offset + 20;

            }


            graphics.DrawString("Amount Tendered: " + string.Format(new CultureInfo("fil-PH"), "{0:C}", this.transaction.AmountTendered), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;



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

        #endregion

       
    }
}
