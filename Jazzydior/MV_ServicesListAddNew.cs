using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Jazzydior.BusinessClass;
using Jazzydior.DBClass;

namespace Jazzydior
{
    public partial class MV_ServicesListAddNew : Form
    {
        Services services = new Services();
        private readonly MV_ServicesListMainForm _mainFormService;

        public MV_ServicesListAddNew(MV_ServicesListMainForm mainFormService)
        {
            InitializeComponent();
            _mainFormService = mainFormService;
            
        }

    // Load Category Data to ComboBox
        private void MV_ServicesListAddNew_Load(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from servicesCategory", con);

                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable src = new DataTable();
                    src.Load(sdr);

                    cmbPckgAddService.DisplayMember = "serv_CategoryName";
                    cmbPckgAddService.ValueMember = "serv_CatID";
                    cmbPckgAddService.DataSource = src;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                con.Close();

        }

    // Exit Button for Add New Service
        private void buttonexitaddnewservice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Add New Service Details Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    // Save Button for New Service Details
        private void btnAddServiceSave_Click(object sender, EventArgs e)
        {

            services.ServiceName = txtBoxAddServicesName.Text;
            services.ServiceCategoryID = Convert.ToInt32(cmbPckgAddService.SelectedValue);
            services.ServiceLeadTime = txtBoxAddServiceLeadTime.Text;
            services.ServicePrice = Convert.ToDecimal(txtBoxAddServicePrice.Text);
            int serv_ID = ServicesDB.AddServices(services);

            if (MessageBox.Show("Are you sure you want to save this service details?", "Confirm Adding New Service Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Record has been successfully saved.");
            }
            
            ClearFormControls();
            _mainFormService.GetServiceRecord();

        }

    // Cancel Button
        private void btnAddServiceClear_Click(object sender, EventArgs e)
        {
            if (btnAddServiceCancel.Text == "Cancel")
            {

                ClearFormControls();

                btnAddServiceSave.Enabled = true;

                btnAddServiceSave.Text = "Add";
            }
        }

        private void ClearFormControls()
        {
            txtBoxAddServicesName.Clear();
            cmbPckgAddService.SelectedIndex = -1;
            txtBoxAddServiceLeadTime.Clear();
            txtBoxAddServicePrice.Clear();

            txtBoxAddServicesName.Focus();
        }

    // Exit Button for Service List Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Add New Service Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    // Dont allow letters in textBoxPrice
        private void txtBoxAddServicePrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
