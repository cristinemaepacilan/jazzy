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
    public partial class MV_UserAcctMainForm : Form
    {
        UserAccount userAccount = new UserAccount();

        public MV_UserAcctMainForm()
        {
            InitializeComponent();
        }

    // Load Data
        private void MV_UserAcctMainForm_Load(object sender, EventArgs e)
        {
            GetUserRecord();
            LoadComboboxUserPosition();
        }

    // Load Data to ComboBox User Position
        private void LoadComboboxUserPosition()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from position", con);

            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable src = new DataTable();
                src.Load(sdr);

                cmbMAcctPosition.DisplayMember = "position_Name";
                cmbMAcctPosition.ValueMember = "position_ID";
                cmbMAcctPosition.DataSource = src;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            con.Close();
        }

    // Load Data to DatagridView
        public void GetUserRecord()
        {
            var query = "Select user_ID, user_FName, user_LName, user_PositionID, p.position_Name, " +
                        "user_Status, user_Username, user_Pass, user_DateCreated from  userAccount ua " +
                        "INNER JOIN  position p ON ua.user_PositionID = p.position_ID";


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);


            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("userAccount");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgMAcct.DataSource = dt;

            // Change the Column Name
            dtgMAcct.Columns[0].Visible = false;
            dtgMAcct.Columns["user_ID"].HeaderText = "User ID No";
            dtgMAcct.Columns["user_FName"].HeaderText = "Firstname";
            dtgMAcct.Columns["user_LName"].HeaderText = "Lastname";
            dtgMAcct.Columns[3].Visible = false;
            dtgMAcct.Columns["user_PositionID"].HeaderText = "Position ID";
            dtgMAcct.Columns["position_Name"].HeaderText = "Position";
            dtgMAcct.Columns["user_Status"].HeaderText = "Status";
            dtgMAcct.Columns["user_Username"].HeaderText = "Username";
            dtgMAcct.Columns["user_Pass"].HeaderText = "Password";
            dtgMAcct.Columns["user_DateCreated"].HeaderText = "Date Created";
        }

    // Add New User Position Button
        private void btnPosition_Click(object sender, EventArgs e)
        {
            MV_UserPosition frm = new MV_UserPosition();
            frm.Show();
        }

    // Create New Account Button
        private void btnMActtCreateAdd_Click(object sender, EventArgs e)
        {
            MV_UserCreateAcct frm = new MV_UserCreateAcct(this);
            frm.Show();
        }

    // DataGridView Cell Select
        private void dtgMAcct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic data = dtgMAcct.SelectedRows[0];

            txtBoxMAcctID.Text = Convert.ToString(data.Cells[0].Value);
            txtBoxMAcctFName.Text = data.Cells[1].Value;
            txtBoxMAcctLName.Text = data.Cells[2].Value;
            cmbMAcctPosition.SelectedValue = Convert.ToString(data.Cells[3].Value);

            if (data.Cells[4].Value == "Active")
            {
                rbMAcctActive.Checked = true;
            }
            else
            {
                rbMAcctDeactived.Checked = true;
            }

            txtBoxMAcctUsername.Text = data.Cells[6].Value;
            txtBoxMAcctPass.Text = data.Cells[7].Value;
            dtPickerUserDateCreated.Value = data.Cells[8].Value;
        }

    // Edit Button
        private void btnMAcctUpdate_Click(object sender, EventArgs e)
        {
            if (btnMAcctUpdate.Text == "Edit")
            {
                btnMAcctUpdate.Text = "Update";
                cmbMAcctPosition.Enabled = false;
                rbMAcctActive.Enabled = false;
                rbMAcctDeactived.Enabled = false;
                txtBoxMAcctUsername.Enabled = false;
                txtBoxMAcctPass.Enabled = false;

                btnMAcctDelete.Enabled = false;

                cmbMAcctPosition.Enabled = true;
                rbMAcctActive.Enabled = true;
                rbMAcctDeactived.Enabled = true;
                txtBoxMAcctUsername.Enabled = true;
                txtBoxMAcctPass.Enabled = true;

            }
            else
            {
                UserAccount updateUser = new UserAccount();

                updateUser.UserID = Convert.ToInt32(txtBoxMAcctID.Text);
                updateUser.UserFName = txtBoxMAcctFName.Text;
                updateUser.UserLName = txtBoxMAcctLName.Text;
                updateUser.UserPositionID = Convert.ToInt32(cmbMAcctPosition.SelectedValue);
                updateUser.UserStatus = rbMAcctActive.Checked ? "Active" : "Deactive";
                updateUser.Username = txtBoxMAcctUsername.Text;
                updateUser.UserPassword = txtBoxMAcctPass.Text;
                updateUser.UserDateCreated = dtPickerUserDateCreated.Value;

                UserAccountDB.UpdateUser(updateUser);

                if (MessageBox.Show("Are you sure you want to update this user details?", "Confirm Deleting Position Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully updated.");
                }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetUserRecord();
                ClearFormControls();

                cmbMAcctPosition.Enabled = true;
                rbMAcctActive.Enabled = true;
                rbMAcctDeactived.Enabled = true;
                txtBoxMAcctUsername.Enabled = true;
                txtBoxMAcctPass.Enabled = true;

                btnMAcctUpdate.Text = "Edit";
                btnMAcctDelete.Enabled = true;

                cmbMAcctPosition.Enabled = false;
                rbMAcctActive.Enabled = false;
                rbMAcctDeactived.Enabled = false;
                txtBoxMAcctUsername.Enabled = false;
                txtBoxMAcctPass.Enabled = false;
            }
        }

    // Delete Button
        private void btnMAcctDelete_Click(object sender, EventArgs e)
        {
            UserAccount deleteUser = new UserAccount();

            deleteUser.UserID = Convert.ToInt32(txtBoxMAcctID.Text);
            deleteUser.UserFName = txtBoxMAcctFName.Text;
            deleteUser.UserLName = txtBoxMAcctLName.Text;
            deleteUser.UserPositionID = Convert.ToInt32(cmbMAcctPosition.SelectedValue);
            deleteUser.UserStatus = rbMAcctActive.Checked ? "Active" : "Deactive";
            deleteUser.Username = txtBoxMAcctUsername.Text;
            deleteUser.UserPassword = txtBoxMAcctPass.Text;
            deleteUser.UserDateCreated = dtPickerUserDateCreated.Value;

            UserAccountDB.DeleteUser(deleteUser);

            if (MessageBox.Show("Are you sure you want to delete this user details?", "Confirm Deleting Position Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetUserRecord();
            ClearFormControls();
        }

    // Cancel Button
        private void btnMAcctCancel_Click(object sender, EventArgs e)
        {
            if (btnMAcctCancel.Text == "Cancel")
            {
                btnMAcctUpdate.Enabled = false;
                btnMAcctDelete.Enabled = false;

                ClearFormControls();

                btnMAcctUpdate.Enabled = true;
                btnMAcctDelete.Enabled = true;

                cmbMAcctPosition.SelectedIndex = -1;
                cmbMAcctPosition.Enabled = false;
                rbMAcctActive.Enabled = false;
                rbMAcctDeactived.Enabled = false;
                txtBoxMAcctUsername.Enabled = false;
                txtBoxMAcctPass.Enabled = false;

                btnMAcctUpdate.Text = "Edit";
            }
        }

        private void ClearFormControls()
        {
            txtBoxMAcctFName.Clear();
            txtBoxMAcctLName.Clear();
            txtBoxMAcctUsername.Clear();
            txtBoxMAcctPass.Clear();

            txtBoxMAcctFName.Focus();
        }

    // Search User Record
        private void SearchUserRecord(object sender, EventArgs e)
        {
            string keyword = txtBoxUserSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                GetUserRecord();
            }
            else
            {
                if (dtgMAcct.DataSource != null)
                {
                    DataTable dt = (DataTable)dtgMAcct.DataSource;
                    var col = dt.Columns;

                    try
                    {
                        dt.DefaultView.RowFilter = $"position_Name LIKE '%{keyword}%'" +
                                                   $"OR Convert(user_ID, 'System.String') LIKE '%{keyword}%'" +
                                                   $"OR user_FName LIKE '%{keyword}%'" +
                                                   $"OR user_LName LIKE '%{keyword}%'" +
                                                   $"OR user_Status LIKE '%{keyword}%'" +
                                                   $"OR user_Username LIKE '%{keyword}%'" +
                                                   $"OR user_Pass LIKE '%{keyword}%'";
                                                   //$"OR user_DateCreated LIKE '%{keyword}%'";
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        GetUserRecord();
                    }

                    dtgMAcct.DataSource = dt.DefaultView.ToTable();

                }
            }
        }



    }
}
