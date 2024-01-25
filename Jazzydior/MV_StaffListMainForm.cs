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
    public partial class MV_StaffListMainForm : Form
    {
        Staffs staffs = new Staffs();

        public MV_StaffListMainForm()
        {
            InitializeComponent();
        }

    // Load Staff Data
        private void MV_StaffList_Load(object sender, EventArgs e)
        {
           GetStaffRecord();
           LoadComboboxStaffPosition();
            
        }

    // Load Inputted Data to DataGrid
        public void GetStaffRecord()
        {
            var query = "Select staff_ID, staff_FName, staff_LName, staff_PositionID, p.position_Name,  staff_Sex, staff_Street, staff_BuildingNo, staff_HouseNo, " +
                            "staff_Purok, staff_Brgy, staff_City, staff_Province, staff_Country, staff_ContactNo, " +
                            "staff_Email, staff_Status from  staffs st " +
                        "INNER JOIN  position p ON st.staff_PositionID = p.position_ID";

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("staffs");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgStaffs.DataSource = dt;

            // Change the Column Name
            dtgStaffs.Columns["staff_ID"].HeaderText = "Staff ID No";
            dtgStaffs.Columns["staff_FName"].HeaderText = "Firstname";
            dtgStaffs.Columns["staff_LName"].HeaderText = "Lastname";
            dtgStaffs.Columns[3].Visible = false;
            dtgStaffs.Columns["staff_PositionID"].HeaderText = "PositionID";
            dtgStaffs.Columns["position_Name"].HeaderText = "Position";
            dtgStaffs.Columns["staff_Sex"].HeaderText = "Sex";
            dtgStaffs.Columns["staff_BuildingNo"].HeaderText = "Building No";
            dtgStaffs.Columns["staff_Email"].HeaderText = "Email Address";
            dtgStaffs.Columns["staff_Street"].HeaderText = "Street";
            dtgStaffs.Columns["staff_ContactNo"].HeaderText = "Contact No";
            dtgStaffs.Columns["staff_HouseNo"].HeaderText = "House No";
            dtgStaffs.Columns["staff_Purok"].HeaderText = "Purok";
            dtgStaffs.Columns["staff_Brgy"].HeaderText = "Barangay";
            dtgStaffs.Columns["staff_City"].HeaderText = "City";
            dtgStaffs.Columns["staff_Province"].HeaderText = "Province";
            dtgStaffs.Columns["staff_Country"].HeaderText = "Country";
            dtgStaffs.Columns["staff_Status"].HeaderText = "Status";

        }

    // Load Data to ComboBox Category
        public void LoadComboboxStaffPosition()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from position", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable src = new DataTable();
                src.Load(sdr);

                cmbCreateAcctPosition.DisplayMember = "position_Name";
                cmbCreateAcctPosition.ValueMember = "position_ID";
                cmbCreateAcctPosition.DataSource = src;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            con.Close();
        }

    // Exit Application
        private void btnLogoutStaffs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

    // Add Button for Staff List
        private void btnStaffsAdd_Click(object sender, EventArgs e)
        {
            MV_StaffsListAddNew frm = new MV_StaffsListAddNew(this);
            frm.Show();
        }

    // DataGridView Cell Select
        private void dtgStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dynamic data = dtgStaffs.SelectedRows[0];

            txtBoxStaffsID.Text = Convert.ToString(data.Cells[0].Value);
            txtBoxStaffsFirstname.Text = data.Cells[1].Value;
            txtBoxStaffsLastname.Text = data.Cells[2].Value;
            cmbCreateAcctPosition.SelectedValue = data.Cells[3].Value;

           

            txtBoxStaffsStreet.Text = data.Cells[6].Value;
            txtBoxStaffsBuilding.Text = Convert.ToString(data.Cells[7].Value);
            txtBoxStaffsHouse.Text = Convert.ToString(data.Cells[8].Value);
            txtBoxStaffsPurok.Text = data.Cells[9].Value;
            txtBoxStaffsBrgy.Text = data.Cells[10].Value;
            txtBoxStaffsCity.Text = data.Cells[11].Value;
            txtBoxStaffsProvince.Text = data.Cells[12].Value;
            txtBoxStaffsCountry.Text = data.Cells[13].Value;
            txtBoxStaffsContact.Text = Convert.ToString(data.Cells[14].Value);
            txtBoxStaffsEmail.Text = data.Cells[15].Value;

            var em = data.Cells[16].Value.ToString();


            rbStaffEmployed.Checked = string.Equals(em, "Employed");
            rbStaffUnemployed.Checked = !string.Equals(em, "Employed");
            //if(string.Equals(em,"Employed"))
            //{
            //    rbStaffEmployed.Checked = true;
            //    rbStaffUnemployed.Checked = false;
            //}
            //else
            //{
            //    rbStaffEmployed.Checked= false;
            //    rbStaffUnemployed.Checked= true;
            //}

            if (data.Cells[5].Value.ToString() == "Male")
            {
                rbStaffsMale.Checked = true;
                rbStaffsFemale.Checked = false;
                

            }
            else
            {
                rbStaffsMale.Checked = false;
                rbStaffsFemale.Checked = true;
            }

        }

    // Edit Button
        private void btnStaffsUpdate_Click(object sender, EventArgs e)
        {
            if (btnStaffsUpdate.Text == "Edit")
            {
                btnStaffsUpdate.Text = "Update";
                cmbCreateAcctPosition.Enabled = false;
                txtBoxStaffsContact.Enabled = false;
                txtBoxStaffsEmail.Enabled = false;
                txtBoxStaffsStreet.Enabled = false;
                txtBoxStaffsBuilding.Enabled = false;
                txtBoxStaffsHouse.Enabled = false;
                txtBoxStaffsPurok.Enabled = false;
                txtBoxStaffsBrgy.Enabled = false;
                txtBoxStaffsCity.Enabled = false;
                txtBoxStaffsProvince.Enabled = false;
                txtBoxStaffsCountry.Enabled = false;
                rbStaffEmployed.Enabled = false;
                rbStaffUnemployed.Enabled = false;

                btnStaffsDelete.Enabled = false;

                cmbCreateAcctPosition.Enabled = true;
                txtBoxStaffsContact.Enabled = true;
                txtBoxStaffsEmail.Enabled = true;
                txtBoxStaffsStreet.Enabled = true;
                txtBoxStaffsBuilding.Enabled = true;
                txtBoxStaffsHouse.Enabled = true;
                txtBoxStaffsPurok.Enabled = true;
                txtBoxStaffsBrgy.Enabled = true;
                txtBoxStaffsCity.Enabled = true;
                txtBoxStaffsProvince.Enabled = true;
                txtBoxStaffsCountry.Enabled = true;
                rbStaffEmployed.Enabled = true;
                rbStaffUnemployed.Enabled = true;

            }
            else
            {
            Staffs updateStaff = new Staffs();

            updateStaff.StaffID = Convert.ToInt32(txtBoxStaffsID.Text);
            updateStaff.StaffFName = txtBoxStaffsFirstname.Text;
            updateStaff.StaffLName = txtBoxStaffsLastname.Text;
            updateStaff.StaffSex = rbStaffsMale.Checked ? "Male" : "Female";
            updateStaff.StaffPositionID = Convert.ToInt32(cmbCreateAcctPosition.SelectedValue);
            updateStaff.StaffContactNo = Convert.ToInt32(txtBoxStaffsContact.Text);
            updateStaff.StaffEmail = txtBoxStaffsEmail.Text;
            updateStaff.StaffStreet = txtBoxStaffsStreet.Text;
            updateStaff.StaffBuildingNo = Convert.ToInt32(txtBoxStaffsBuilding.Text);
            updateStaff.StaffHouseNo = Convert.ToInt32(txtBoxStaffsHouse.Text);
            updateStaff.StaffPurok = txtBoxStaffsPurok.Text;
            updateStaff.StaffBarangay = txtBoxStaffsBrgy.Text;
            updateStaff.StaffCity = txtBoxStaffsCity.Text;
            updateStaff.StaffProvince = txtBoxStaffsProvince.Text;
            updateStaff.StaffCountry = txtBoxStaffsCountry.Text;
            updateStaff.StaffStatus = rbStaffEmployed.Checked ? "Employed" : "Unemployed";

            StaffsDB.UpdateStaffs(updateStaff);

                if (MessageBox.Show("Are you sure you want to update this staff details?", "Confirm Updating Staff Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully updated.");
                }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetStaffRecord();

            cmbCreateAcctPosition.Enabled = true;
            txtBoxStaffsContact.Enabled = true;
            txtBoxStaffsEmail.Enabled = true;
            txtBoxStaffsStreet.Enabled = true;
            txtBoxStaffsBuilding.Enabled = true;
            txtBoxStaffsHouse.Enabled = true;
            txtBoxStaffsPurok.Enabled = true;
            txtBoxStaffsBrgy.Enabled = true;
            txtBoxStaffsCity.Enabled = true;
            txtBoxStaffsProvince.Enabled = true;
            txtBoxStaffsCountry.Enabled = true;
            rbStaffEmployed.Enabled = true;
            rbStaffUnemployed.Enabled = true;

            btnStaffsUpdate.Text = "Edit";
            btnStaffsDelete.Enabled = true;

            cmbCreateAcctPosition.Enabled = false;
            txtBoxStaffsContact.Enabled = false;
            txtBoxStaffsEmail.Enabled = false;
            txtBoxStaffsStreet.Enabled = false;
            txtBoxStaffsBuilding.Enabled = false;
            txtBoxStaffsHouse.Enabled = false;
            txtBoxStaffsPurok.Enabled = false;
            txtBoxStaffsBrgy.Enabled = false;
            txtBoxStaffsCity.Enabled = false;
            txtBoxStaffsProvince.Enabled = false;
            txtBoxStaffsCountry.Enabled = false;
            rbStaffEmployed.Enabled = false;
            rbStaffUnemployed.Enabled = false;
            }
        }



    // Cancel Button
        private void btnStaffsCancel_Click(object sender, EventArgs e)
        {
            if (btnStaffsCancel.Text == "Cancel")
            {
                btnStaffsUpdate.Enabled = false;
                btnStaffsDelete.Enabled = false;

                ClearFormControls();

                btnStaffsUpdate.Enabled = true;
                btnStaffsDelete.Enabled = true;

                cmbCreateAcctPosition.SelectedIndex = -1;
                cmbCreateAcctPosition.Enabled = false;
                txtBoxStaffsContact.Enabled = false;
                txtBoxStaffsEmail.Enabled = false;
                txtBoxStaffsStreet.Enabled = false;
                txtBoxStaffsBuilding.Enabled = false;
                txtBoxStaffsHouse.Enabled = false;
                txtBoxStaffsPurok.Enabled = false;
                txtBoxStaffsBrgy.Enabled = false;
                txtBoxStaffsCity.Enabled = false;
                txtBoxStaffsProvince.Enabled = false;
                txtBoxStaffsCountry.Enabled = false;
                rbStaffEmployed.Enabled = false;
                rbStaffUnemployed.Enabled = false;

                btnStaffsUpdate.Text = "Edit";
            }
        }

        private void ClearFormControls()
        {
            txtBoxStaffsFirstname.Clear();
            txtBoxStaffsLastname.Clear();
            txtBoxStaffsContact.Clear();
            txtBoxStaffsEmail.Clear();
            txtBoxStaffsStreet.Clear();
            txtBoxStaffsBuilding.Clear();
            txtBoxStaffsHouse.Clear();
            txtBoxStaffsPurok.Clear();
            txtBoxStaffsBrgy.Clear();
            txtBoxStaffsCity.Clear();
            txtBoxStaffsProvince.Clear();
            txtBoxStaffsCountry.Clear();

            txtBoxStaffsFirstname.Focus();
        }

    // Dont allow letters in textBoxContact
        private void txtBoxStaffsContact_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtBoxStaffsBuilding_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtBoxStaffsHouse_KeyPress(object sender, KeyPressEventArgs e)
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

    // Delete Button
        private void btnStaffsDelete_Click(object sender, EventArgs e)
        {
            Staffs deleteStaff = new Staffs();

            deleteStaff.StaffID = Convert.ToInt32(txtBoxStaffsID.Text);
            deleteStaff.StaffFName = txtBoxStaffsFirstname.Text;
            deleteStaff.StaffLName = txtBoxStaffsLastname.Text;
            deleteStaff.StaffSex = rbStaffsMale.Checked ? "Male" : "Female";
            deleteStaff.StaffPositionID = Convert.ToInt32(cmbCreateAcctPosition.SelectedValue);
            deleteStaff.StaffContactNo = Convert.ToInt32(txtBoxStaffsContact.Text);
            deleteStaff.StaffEmail = txtBoxStaffsEmail.Text;
            deleteStaff.StaffStreet = txtBoxStaffsStreet.Text;
            deleteStaff.StaffBuildingNo = Convert.ToInt32(txtBoxStaffsBuilding.Text);
            deleteStaff.StaffHouseNo = Convert.ToInt32(txtBoxStaffsHouse.Text);
            deleteStaff.StaffPurok = txtBoxStaffsPurok.Text;
            deleteStaff.StaffBarangay = txtBoxStaffsBrgy.Text;
            deleteStaff.StaffCity = txtBoxStaffsCity.Text;
            deleteStaff.StaffProvince = txtBoxStaffsProvince.Text;
            deleteStaff.StaffCountry = txtBoxStaffsCountry.Text;
            deleteStaff.StaffStatus = rbStaffEmployed.Checked ? "Employed" : "Unemployed";

          

            if (MessageBox.Show("Are you sure you want to delete this staff details?", "Confirm Deleting Staff Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StaffsDB.DeleteStaffs(deleteStaff);
                MessageBox.Show("Successfully deleted.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetStaffRecord();
        }

        private void SearchStaffRecord(object sender, EventArgs e)
        {
            string keyword = txtBoxStaffsSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                GetStaffRecord();
            }
            else
            {
                if (dtgStaffs.DataSource != null)
                {

                    DataTable dt = (DataTable)dtgStaffs.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"staff_FName LIKE '%{keyword}%'" +
                                                   $"OR Convert(staff_ID, 'System.String')  LIKE '%{keyword}%'" +
                                                   $"OR staff_LName LIKE '%{keyword}%' " +
                                                    $"OR Convert(staff_PositionID, 'System.String')  LIKE '%{keyword}%'" +
                                                   $"OR staff_Email LIKE '%{keyword}%' " +
                                                    $"OR Convert(staff_ContactNo, 'System.String')  LIKE '%{keyword}%'" +
                                                   $"OR staff_Sex LIKE '%{keyword}%' " +
                                                   $"OR staff_Street LIKE '%{keyword}%' " +
                                                   $"OR staff_Purok LIKE '%{keyword}%' " +
                                                   $"OR staff_Brgy LIKE '%{keyword}%' " +
                                                    $"OR staff_City LIKE '%{keyword}%' " +
                                                   $"OR staff_Province LIKE '%{keyword}%' " +
                                                   $"OR staff_Country LIKE '%{keyword}%' " +
                                                   $"OR staff_Email LIKE '%{keyword}%' " +
                                                   $"OR staff_Status LIKE '%{keyword}%' " +
                                                   $"OR Convert(staff_BuildingNo,'System.String') LIKE '%{keyword}%'";
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetStaffRecord();
                    }


                    dtgStaffs.DataSource = dt.DefaultView.ToTable();
                }

            }
        }
    }
}
