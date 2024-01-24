using Jazzydior.BusinessClass;
using Jazzydior.DBClass;
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
    public partial class MV_ServicesPackageList : Form
    {
        ServicePackage servicePackage = new ServicePackage();

        public MV_ServicesPackageList()
        {
            InitializeComponent();
        }

    // Load Data to Form
        private void MV_ServicePackage_Load(object sender, EventArgs e)
        {
            GetPackageRecord();
            FillComboSearchServices();
        }

        // Fill Data in ComboBox
        private void FillComboSearchServices()
        {
            cmbPckgService1.Items.Clear();
            cmbPckgService2.Items.Clear();
            cmbPckgService3.Items.Clear();
            cmbPckgService4.Items.Clear();
            cmbPckgService5.Items.Clear();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select serv_ID, serv_Name from services";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cmbPckgService3.Items.Add("N/A");
            cmbPckgService4.Items.Add("N/A");
            cmbPckgService5.Items.Add("N/A");



            foreach (DataRow dr in dt.Rows)
            {   
                cmbPckgService1.Items.Add(dr["serv_Name"].ToString());
                cmbPckgService2.Items.Add(dr["serv_Name"].ToString());
                cmbPckgService3.Items.Add(dr["serv_Name"].ToString());
                cmbPckgService4.Items.Add(dr["serv_Name"].ToString());
                cmbPckgService5.Items.Add(dr["serv_Name"].ToString());
            }
            con.Close();
        }

    // Store Inputted Data to DataGrid
        private void GetPackageRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from servicepackage", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dtgServicePackage.DataSource = dt;

            // Change the Column Name
            dtgServicePackage.Columns[0].Visible = false;
            dtgServicePackage.Columns["pckg_Id"].HeaderText = "Package ID No";
            dtgServicePackage.Columns["pckg_Name"].HeaderText = "Package Name";
            dtgServicePackage.Columns["pckg_Serv1"].HeaderText = "Service 1";
            dtgServicePackage.Columns["pckg_Serv2"].HeaderText = "Service 2";
            dtgServicePackage.Columns["pckg_Serv3"].HeaderText = "Service 3";
            dtgServicePackage.Columns["pckg_Serv4"].HeaderText = "Service 4";
            dtgServicePackage.Columns["pckg_Serv5"].HeaderText = "Service 5";
            dtgServicePackage.Columns["pckg_LeadTime"].HeaderText = "Lead Time";
            dtgServicePackage.Columns["pckg_Price"].HeaderText = "Price";

        }

    // Exit Package Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Package List Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

    // Save Button to Add New Package List
        private void btnPackageSave_Click(object sender, EventArgs e)
        {
                if (btnPackageSave.Text == "Add")
                {
                    btnPackageSave.Text = "Save";
                    txtBoxPckgName.Enabled = false;
                    cmbPckgService1.Enabled = false;
                    cmbPckgService2.Enabled = false;
                    cmbPckgService3.Enabled = false;
                    cmbPckgService4.Enabled = false;
                    cmbPckgService5.Enabled = false;
                    txtBoxPckgLeadTime.Enabled = false;
                    txtBoxPckgPrice.Enabled = false;

                    btnPackageUpdate.Enabled = false;
                    btnPackageDelete.Enabled = false;

                    txtBoxPckgName.Enabled = true;
                    cmbPckgService1.Enabled = true;
                    cmbPckgService2.Enabled = true;
                    cmbPckgService3.Enabled = true;
                    cmbPckgService4.Enabled = true;
                    cmbPckgService5.Enabled = true;
                    txtBoxPckgLeadTime.Enabled = true;
                    txtBoxPckgPrice.Enabled = true;

                }
                else
                {
                    servicePackage.PackageName = txtBoxPckgName.Text;
                    servicePackage.Service1 = cmbPckgService1.Text;
                    servicePackage.Service2 = cmbPckgService2.Text;
                    servicePackage.Service3 =cmbPckgService3.Text;
                    servicePackage.Service4 = cmbPckgService4.Text;
                    servicePackage.Service5 = cmbPckgService5.Text;
                    servicePackage.PackageLeadTime = txtBoxPckgLeadTime.Text;
                    servicePackage.PackagePrice = Convert.ToInt32(txtBoxPckgPrice.Text);
                    int pckg_ID = ServicePackageDB.AddServicesPackage(servicePackage);

                    if (MessageBox.Show("Are you sure you want to save this package details?", "Confirm Adding New Package Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Record has been successfully saved.");
                    }

                    txtBoxPckgName.Enabled = true;
                    cmbPckgService1.Enabled = true;
                    cmbPckgService2.Enabled = true;
                    cmbPckgService3.Enabled = true;
                    cmbPckgService4.Enabled = true;
                    cmbPckgService5.Enabled = true;
                    txtBoxPckgLeadTime.Enabled = true;
                    txtBoxPckgPrice.Enabled = true;

                    btnPackageSave.Text = "Add";
                    btnPackageUpdate.Enabled = true;
                    btnPackageDelete.Enabled = true;

                    txtBoxPckgName.Enabled = false;
                    cmbPckgService1.Enabled = false;
                    cmbPckgService2.Enabled = false;
                    cmbPckgService3.Enabled = false;
                    cmbPckgService4.Enabled = false;
                    cmbPckgService5.Enabled = false;
                    txtBoxPckgLeadTime.Enabled = false;
                    txtBoxPckgPrice.Enabled = false;

                    ClearFormControls();
                    GetPackageRecord();
            }
        }

    // DataGridView Cell Select
        private void dtgServicePackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic data = dtgServicePackage.SelectedRows[0];

            txtBoxPckgID.Text = Convert.ToString(data.Cells[0].Value);
            txtBoxPckgName.Text = data.Cells[1].Value;
            cmbPckgService1.Text = data.Cells[2].Value;
            cmbPckgService2.Text = data.Cells[3].Value;
            cmbPckgService3.Text = data.Cells[4].Value;
            cmbPckgService4.Text = data.Cells[5].Value;
            cmbPckgService5.Text = data.Cells[6].Value;
            txtBoxPckgLeadTime.Text = data.Cells[7].Value;
            txtBoxPckgPrice.Text = Convert.ToString(data.Cells[8].Value);
                
        }

    // Delete Button
        private void btnPackageDelete_Click(object sender, EventArgs e)
        {
            ServicePackage deleteServicePackage = new ServicePackage();

            deleteServicePackage.PackageName = txtBoxPckgName.Text;
            deleteServicePackage.Service1 =cmbPckgService1.Text;
            deleteServicePackage.Service2 =cmbPckgService2.Text;
            deleteServicePackage.Service3 =cmbPckgService3.Text;
            deleteServicePackage.Service4 =cmbPckgService4.Text;
            deleteServicePackage.Service5 =cmbPckgService5.Text;
            deleteServicePackage.PackageLeadTime = txtBoxPckgLeadTime.Text;
            deleteServicePackage.PackagePrice = Convert.ToDecimal(txtBoxPckgPrice.Text);
            deleteServicePackage.PackageID = Convert.ToInt32(txtBoxPckgID.Text);

            ServicePackageDB.DeleteServicesPackage(deleteServicePackage);
            
            if (MessageBox.Show("Are you sure you want to delete this package details?", "Confirm Deleting Package Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }

            GetPackageRecord();
            ClearFormControls();
        }

    // Edit Button
        private void btnPackageUpdate_Click(object sender, EventArgs e)
        {
            if (btnPackageUpdate.Text == "Edit")
            {
                btnPackageUpdate.Text = "Update";
                txtBoxPckgLeadTime.Enabled = false;
                txtBoxPckgPrice.Enabled = false;

                btnPackageSave.Enabled = false;
                btnPackageDelete.Enabled = false;

                txtBoxPckgLeadTime.Enabled = true;
                txtBoxPckgPrice.Enabled = true;

            }
            else
            {
                ServicePackage updateServicePackage = new ServicePackage();

                updateServicePackage.PackageName = txtBoxPckgName.Text;
                updateServicePackage.Service1 = cmbPckgService1.Text;
                updateServicePackage.Service2 = cmbPckgService2.Text;
                updateServicePackage.Service3 = cmbPckgService3.Text;
                updateServicePackage.Service4 = cmbPckgService4.Text;
                updateServicePackage.Service5 = cmbPckgService5.Text;
                updateServicePackage.PackageLeadTime = txtBoxPckgLeadTime.Text;
                updateServicePackage.PackagePrice = Convert.ToDecimal(txtBoxPckgPrice.Text);
                updateServicePackage.PackageID = Convert.ToInt32(txtBoxPckgID.Text);

                ServicePackageDB.UpdateServicesPackage(updateServicePackage);

                if (MessageBox.Show("Are you sure you want to update this package details?", "Confirm Updating Package Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully updated.");
                }

                GetPackageRecord();
                ClearFormControls();

                txtBoxPckgLeadTime.Enabled = true;
                txtBoxPckgPrice.Enabled = true;

                btnPackageUpdate.Text = "Edit";
                btnPackageSave.Enabled = true;
                btnPackageDelete.Enabled = true;

                txtBoxPckgLeadTime.Enabled = false;
                txtBoxPckgPrice.Enabled = false;
            }
        }

    // Cancel Button
        private void btnPackageCancel_Click(object sender, EventArgs e)
        {
                if (btnPackageCancel.Text == "Cancel")
                {
                    btnPackageSave.Enabled = false;
                    btnPackageUpdate.Enabled = false;
                    btnPackageDelete.Enabled = false;

                    ClearFormControls();

                    btnPackageSave.Enabled = true;
                    btnPackageUpdate.Enabled = true;
                    btnPackageDelete.Enabled = true;

                    txtBoxPckgName.Enabled = false;
                    cmbPckgService1.Enabled = false;
                    cmbPckgService2.Enabled = false;
                    cmbPckgService3.Enabled = false;
                    cmbPckgService4.Enabled = false;
                    cmbPckgService5.Enabled = false;
                    txtBoxPckgLeadTime.Enabled = false;
                    txtBoxPckgPrice.Enabled = false;

                    btnPackageSave.Text = "Add";
                    btnPackageUpdate.Text = "Edit";
            }
        }

        private void ClearFormControls()
        {
            txtBoxPckgName.Clear();
            cmbPckgService1.SelectedIndex = -1;
            cmbPckgService2.SelectedIndex = -1;
            cmbPckgService3.SelectedIndex = -1;
            cmbPckgService4.SelectedIndex = -1;
            cmbPckgService5.SelectedIndex = -1;
            txtBoxPckgLeadTime.Clear();
            txtBoxPckgPrice.Clear();

            txtBoxPckgName.Focus();
        }

    // Don't allow letters
        private void txtBoxPckgPrice_KeyPress(object sender, KeyPressEventArgs e)
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
