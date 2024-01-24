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
    public partial class ManagerView : Form
    {
        
        public ManagerView()
        {
            InitializeComponent();
        }

//Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

//
//
// Add Form to the Right Panel by Clicking the Menu Buttons
//
//

//Home Button
        private void btnHomeMV_Click(object sender, EventArgs e)
        {
            MV_Home frm = new MV_Home();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Service Button
        private void btnServices_Click(object sender, EventArgs e)
        {
            MV_ServicesListMainForm frm = new MV_ServicesListMainForm();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Staff Button
        private void btnStaffs_Click(object sender, EventArgs e)
        {
            MV_StaffListMainForm frm = new MV_StaffListMainForm();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Reports Button
        private void btnReports_Click(object sender, EventArgs e)
        {
            MV_ReportsMainForm frm = new MV_ReportsMainForm();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Archive Button
        private void btnArchive_Click(object sender, EventArgs e)
        {
            MV_ArchiveMainForm frm = new MV_ArchiveMainForm();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Manage Account Button
        private void btnManageAcct_Click(object sender, EventArgs e)
        {
            MV_UserAcctMainForm frm = new MV_UserAcctMainForm();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Logout Button Exit Application
        private void btnLogout_Click(object sender, EventArgs e)
        {

           if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

           {

                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
           }

        }

// Maximized Form
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

// Minimixed Form 
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void ManagerRightPanel_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
