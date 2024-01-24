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
using Jazzydior.DBClass;

namespace Jazzydior
{
    public partial class SalonReceptionistView : Form
    {

        public SalonReceptionistView()
        {
            InitializeComponent();
        }

//
//
// Add Form to the Right Panel by Clicking the Buttons
//
//

 //Home Button
        private void btnHomeSR_Click(object sender, EventArgs e)
        {
            SR_Home frm = new SR_Home();
            frm.TopLevel = false;
            SalonReceptRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Add New Transaction Button
        private void btnSRAddNewTransact_Click(object sender, EventArgs e)
        {
            //SR_NewTransaction frm = new SR_NewTransaction();
            //frm.Show();
        }

//Transaction Report Button
        private void btnSRTransactReports_Click(object sender, EventArgs e)
        {
            SR_TransactionReport frm = new SR_TransactionReport();
            frm.TopLevel = false;
            SalonReceptRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

// Exit Application for Salon Receptionist View
        private void btnLogoutSRV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    // Add New Transaction
        private void btnAddNewTransactionSR_Click(object sender, EventArgs e)
        {
            SR_NewTransaction frm = new SR_NewTransaction();
            frm.TopLevel = false;
            SalonReceptRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnLogoutSR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void SalonReceptRightPanel_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }


    // Minimized Form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    // Maximize Form
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    // Exit Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
            }
        }
    }
}
