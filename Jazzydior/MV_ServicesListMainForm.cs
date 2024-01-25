using Jazzydior.DBClass;
using Jazzydior.BusinessClass;
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

namespace Jazzydior
{
    public partial class MV_ServicesListMainForm : Form
    {
        Services services = new Services();
        private List<string> selectedData = new List<string>();

        public MV_ServicesListMainForm()
        {
            InitializeComponent();

        }

        // Load Inputted Data
        private void MV_ServicesList_Load(object sender, EventArgs e)
        {
            GetServiceRecord();
            LoadComboboxCategory();
        }

    // Load Data to DataGridView
        public void GetServiceRecord()
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

            dtgServices.DataSource = dt;

            // Change the Column Name
            dtgServices.Columns[0].Visible = false;
            dtgServices.Columns["serv_ID"].HeaderText = "Service ID No";
            dtgServices.Columns["serv_Name"].HeaderText = "Service Name";
            dtgServices.Columns[2].Visible = false;
            dtgServices.Columns["serv_CategoryID"].HeaderText = "CategoryID";
            dtgServices.Columns["serv_CategoryName"].HeaderText = "Category";
            dtgServices.Columns["serv_LeadTime"].HeaderText = "Lead Time";
            dtgServices.Columns["serv_Price"].HeaderText = "Price";

        }

    // Load Data to ComboBox Category
        public void LoadComboboxCategory()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from servicesCategory", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable src = new DataTable();
                src.Load(sdr);

                cmbServiceCategory.DisplayMember = "serv_CategoryName";
                cmbServiceCategory.ValueMember = "serv_CatID";
                cmbServiceCategory.DataSource = src;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            con.Close();
        }

    // Add Button to Add New Service Details Form
        private void btnServicesAdd_Click(object sender, EventArgs e)
        {
            MV_ServicesListAddNew frm = new MV_ServicesListAddNew(this);
            frm.Show();
        }

    // Category List Button
        private void btnServiceCategory_Click(object sender, EventArgs e)
        {
            MV_ServicesCategoryList frm = new MV_ServicesCategoryList();
            frm.Show();
            
        }

    // DataGridView Cell Select
        private void dtgServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dynamic data = dtgServices.SelectedRows[0];

            txtBoxServID.Text = Convert.ToString( data.Cells[0].Value);
            txtBoxAddServicesName.Text = data.Cells[1].Value;
            cmbServiceCategory.SelectedValue = data.Cells[2].Value;
            txtBoxAddServiceLeadTime.Text = data.Cells[4].Value;
            txtBoxAddServicePrice.Text = Convert.ToString(data.Cells[5].Value);

        }

    // Delete Button
        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            Services deleteService = new Services();

            deleteService.ServiceName = txtBoxAddServicesName.Text;
            deleteService.ServiceID = Convert.ToInt32(txtBoxServID.Text);
            deleteService.ServiceCategoryID = Convert.ToInt32(cmbServiceCategory.SelectedValue);
            deleteService.ServiceLeadTime = txtBoxAddServiceLeadTime.Text;
            deleteService.ServicePrice = Convert.ToDecimal(txtBoxAddServicePrice.Text);

            ServicesDB.DeleteServices(deleteService);

            if (MessageBox.Show("Are you sure you want to delete this service details?", "Confirm Deleting Service Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetServiceRecord();
            ClearFormControls();

        }

    // Edit Button
        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            if (btnServiceUpdate.Text == "Edit")
            {
                btnServiceUpdate.Text = "Update";
                cmbServiceCategory.Enabled = false;
                txtBoxAddServiceLeadTime.Enabled = false;
                txtBoxAddServicePrice.Enabled = false;

                btnServiceDelete.Enabled = false;

                cmbServiceCategory.Enabled = true;
                txtBoxAddServiceLeadTime.Enabled = true;
                txtBoxAddServicePrice.Enabled = true;

            }
            else
            {
                Services updateService = new Services();

                updateService.ServiceName = txtBoxAddServicesName.Text;
                updateService.ServiceID = Convert.ToInt32(txtBoxServID.Text);
                updateService.ServiceCategoryID = Convert.ToInt32(cmbServiceCategory.SelectedValue);
                updateService.ServiceLeadTime = txtBoxAddServiceLeadTime.Text;
                updateService.ServicePrice = Convert.ToDecimal(txtBoxAddServicePrice.Text);

                ServicesDB.UpdateServices(updateService);

                if (MessageBox.Show("Are you sure you want to update this package details?", "Confirm Updating Package Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully updated.");
                }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetServiceRecord();
                ClearFormControls();

                cmbServiceCategory.Enabled = true;
                txtBoxAddServiceLeadTime.Enabled = true;
                txtBoxAddServicePrice.Enabled = true;

                btnServiceUpdate.Text = "Edit";
                btnServiceDelete.Enabled = true;

                cmbServiceCategory.Enabled = false;
                txtBoxAddServiceLeadTime.Enabled = false;
                txtBoxAddServicePrice.Enabled = false;
            }
        }

    // Cancel Button
        private void btnServiceCancel_Click(object sender, EventArgs e)
        {
            if (btnServiceCancel.Text == "Cancel")
            {
                btnServiceUpdate.Enabled = false;
                btnServiceDelete.Enabled = false;

                ClearFormControls();

                btnServiceUpdate.Enabled = true;
                btnServiceDelete.Enabled = true;

                cmbServiceCategory.SelectedIndex = -1;
                cmbServiceCategory.Enabled = false;
                txtBoxAddServiceLeadTime.Enabled = false;
                txtBoxAddServicePrice.Enabled = false;

                btnServiceUpdate.Text = "Edit";
            }
        }

        private void ClearFormControls()
        {
            txtBoxAddServicesName.Clear();
            txtBoxAddServiceLeadTime.Clear();
            txtBoxAddServicePrice.Clear();

            txtBoxAddServicesName.Focus();
        }

    // Package List Button
        private void btnServicePackageList_Click(object sender, EventArgs e)
        {
            MV_ServicesPackageList frm = new MV_ServicesPackageList();
            frm.Show();
        }

    // Searc Service Record
        private void SearchServiceRecord(object sender, EventArgs e)
        {
            string keyword = txtBoxSearchServices.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                GetServiceRecord();
            }
            else
            {
                if (dtgServices.DataSource != null)
                {

                    DataTable dt = (DataTable)dtgServices.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"serv_CategoryName LIKE '%{keyword}%'" +
                                                   $"OR Convert(serv_ID, 'System.String')  LIKE '%{keyword}%'" +
                                                   $"OR serv_Name LIKE '%{keyword}%' " +
                                                   $"OR serv_LeadTime LIKE '%{keyword}%' " +
                                                   $"OR Convert(serv_Price,'System.String') LIKE '%{keyword}%'";
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetServiceRecord();
                    }


                    dtgServices.DataSource = dt.DefaultView.ToTable();
                }

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
