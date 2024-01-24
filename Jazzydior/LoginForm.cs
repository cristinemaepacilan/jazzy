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
    public partial class LoginForm : Form
    {
        //SqlConnection con = new SqlConnection (Properties.Settings.Default.ConnectionString);
        //SqlDataAdapter da;
        //SqlCommand cmd;

        UserAccount userAccount = new UserAccount();

        public LoginForm()
        {
            InitializeComponent();
        }

    //Exit Button for Login Form
        private void btnExitLoginAcct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Login Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                           Application.Exit();
                        }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxLoginUser.Text != "")
            {
                if (txtBoxLoginPass.Text == "")
                {
                    MessageBox.Show("Please enter the password.");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N8ORNKQ\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");

                        SqlCommand cmd = new SqlCommand("Select * from userAccount WHERE user_Username = @user_Username and user_Pass = @user_Pass", con);
                        cmd.Parameters.AddWithValue("@user_Username", txtBoxLoginUser.Text);
                        cmd.Parameters.AddWithValue("user_Pass", txtBoxLoginPass.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("Invalid username or password!");
                        }

                            var user = dt.Rows[0];


                        if (Convert.ToInt32(user.ItemArray[0]) == 1000)
                        {
                            ManagerView main = new ManagerView();
                            this.Hide();
                            main.Show();
                        }
                        else
                        {


                            SalonReceptionistView main = new SalonReceptionistView();
                            this.Hide();
                            main.Show();
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error:" + ex.Message);
                    }
                }

            }
        }

    // Hide Password
        private void btnHidePassw_Click(object sender, EventArgs e)
        {
            if (txtBoxLoginPass.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtBoxLoginPass.PasswordChar = '*';
            }
        }

    // Show Password
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtBoxLoginPass.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtBoxLoginPass.PasswordChar = '\0';
            }
        }
    }
}
