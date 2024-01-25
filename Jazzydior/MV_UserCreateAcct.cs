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
    public partial class MV_UserCreateAcct : Form
    {
        UserAccount userAccount = new UserAccount();
        private readonly MV_UserAcctMainForm _mainFormUser;

        public MV_UserCreateAcct(MV_UserAcctMainForm mainFormUser)
        {
            InitializeComponent();
            _mainFormUser = mainFormUser;
        }

    // Load Position Data to the ComboBox
        private void MV_ManageUserCreateAcct_Load(object sender, EventArgs e)
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

    // Save Button for New User Details
        private void btnCreateAcctSave_Click(object sender, EventArgs e)
        {   
            userAccount.UserFName = txtBoxCreateAcctFName.Text;
            userAccount.UserLName = txtBoxCreateAcctLName.Text;
            userAccount.UserPositionID = Convert.ToInt32(cmbCreateAcctPosition.SelectedValue);
            userAccount.UserStatus = rbAddMAcctActive.Checked ? "Active" : "Deactive";
            userAccount.Username = txtBoxCreateAcctUsername.Text;
            userAccount.UserPassword = txtBoxCreateAcctPass.Text;
            userAccount.UserDateCreated = dtPickerAddUserDateCreated.Value;
            int user_ID = UserAccountDB.AddUser(userAccount);

            if (MessageBox.Show("Are you sure you want to save this user details?", "Confirm Adding New User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Record has been successfully saved.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Add failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFormControls();
            _mainFormUser.GetUserRecord();
        }

        // Cancel Button
        private void btnAddServiceCancel_Click(object sender, EventArgs e)
        {
            if (btnAddServiceCancel.Text == "Cancel")
            {

                ClearFormControls();

                btnCreateAcctSave.Enabled = true;

                btnCreateAcctSave.Text = "Add";
            }
        }

        private void ClearFormControls()
        {
            txtBoxCreateAcctFName.Clear();
            txtBoxCreateAcctLName.Clear();
            cmbCreateAcctPosition.SelectedIndex = -1;
            txtBoxCreateAcctUsername.Clear();
            txtBoxCreateAcctPass.Clear();

            txtBoxCreateAcctFName.Focus();
        }

    // Exit Button for Create Account
        private void btnExitCreateAcct_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Create New Account Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtBoxCreateAcctPass.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtBoxCreateAcctPass.PasswordChar = '*';
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtBoxCreateAcctPass.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtBoxCreateAcctPass.PasswordChar = '\0';
            }
        }


    }
}
