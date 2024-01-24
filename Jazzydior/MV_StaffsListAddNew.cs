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
    public partial class MV_StaffsListAddNew : Form
    {
        Staffs staffs = new Staffs();
        private readonly MV_StaffListMainForm _mainFormStaff;

        public MV_StaffsListAddNew(MV_StaffListMainForm mainFormStaff)
        {
            InitializeComponent();
            _mainFormStaff = mainFormStaff;
        }

    // Load Position Data to the ComboBox
        private void MV_StaffsListAddNew_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from position", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable src = new DataTable();
                src.Load(sdr);

                cmbAddStaffPosition.DisplayMember = "position_Name";
                cmbAddStaffPosition.ValueMember = "position_ID";
                cmbAddStaffPosition.DataSource = src;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            con.Close();

        }

    // Cancel Button
        private void btnStaffCancel_Click(object sender, EventArgs e)
        {
            if (btnStaffCancel.Text == "Cancel")
            {

                ClearFormControls();

                btnAddStaffSave.Enabled = true;

                btnAddStaffSave.Text = "Add";
            }
        }

        private void ClearFormControls()
        {
            txtBoxAddStaffFirstname.Clear();
            txtBoxAddStaffLastname.Clear();
            cmbAddStaffPosition.SelectedIndex = -1;
            txtBoxAddStaffContact.Clear();
            txtBoxAddStaffEmail.Clear();
            txtBoxAddStaffStreet.Clear();
            txtBoxAddStaffBldg.Clear();
            txtBoxAddStaffHouse.Clear();
            txtBoxAddStaffPurok.Clear();
            txtBoxAddStaffBrgy.Clear();
            txtBoxAddStaffCity.Clear();
            txtBoxAddStaffProvince.Clear();
            txtBoxAddStaffCountry.Clear();
            
            txtBoxAddStaffFirstname.Focus();
        }

    // Exit Button for Staff List Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Add New Service Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        // Save Button for New Staff Details
        private void btnAddStaffSave_Click(object sender, EventArgs e)
        {
            staffs.StaffFName = txtBoxAddStaffFirstname.Text;
            staffs.StaffLName = txtBoxAddStaffLastname.Text;
            staffs.StaffPositionID = Convert.ToInt32(cmbAddStaffPosition.SelectedValue);
            staffs.StaffSex = rbAddStaffFemale.Checked ? "Male" : "Female";
            //staffs.StaffContactNo = Convert.ToInt32(txtBoxAddStaffContact.Text);
            if (Int64.TryParse(txtBoxAddStaffContact.Text, out long contactNo) && contactNo >= 0 && contactNo <= 99999999999)
            {
                staffs.StaffContactNo = (int)contactNo; // Explicitly cast to int
            }
            else
            {
                MessageBox.Show("Invalid Staff Contact Number. Please enter a valid 11-digit number.");
                return; // Stop further processing
            }
            staffs.StaffEmail = txtBoxAddStaffEmail.Text;
            staffs.StaffStreet = txtBoxAddStaffStreet.Text;
            staffs.StaffBuildingNo = Convert.ToInt32(txtBoxAddStaffBldg.Text);
            staffs.StaffHouseNo = Convert.ToInt32(txtBoxAddStaffHouse.Text);
            staffs.StaffPurok = (txtBoxAddStaffPurok.Text);
            staffs.StaffBarangay = txtBoxAddStaffBrgy.Text;
            staffs.StaffCity = txtBoxAddStaffCity.Text;
            staffs.StaffProvince = txtBoxAddStaffProvince.Text;
            staffs.StaffCountry = txtBoxAddStaffProvince.Text;
            staffs.StaffStatus = rbEmployed.Checked ? "Employed" : "Unemployed";
            int staff_ID = StaffsDB.AddStaffs(staffs);

            if (MessageBox.Show("Are you sure you want to save this staff details?", "Confirm Adding New Staff Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Record has been successfully saved.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Add failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFormControls();
            _mainFormStaff.GetStaffRecord();

        }



        // }

        // Dont allow letters in textBoxContact
        private void txtBoxAddStaffContact_KeyPress(object sender, KeyPressEventArgs e)
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

    // Dont allow letters in textBoxBldgNo
        private void txtBoxAddStaffBldg_KeyPress(object sender, KeyPressEventArgs e)
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

    // Dont allow letters in textBoxHouseNo
        private void txtBoxAddStaffHouse_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxAddStaffContact_TextChanged(object sender, EventArgs e)
        {
            txtBoxAddStaffContact.MaxLength = 11;
        }

    }
}

