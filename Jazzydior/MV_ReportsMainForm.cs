using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class MV_ReportsMainForm : Form
    {
        public MV_ReportsMainForm()
        {
            InitializeComponent();
        }
 //Transaction Report Button
        private void btnTransactionReport_Click(object sender, EventArgs e)
        {
            MV_RTransactionReport frm = new MV_RTransactionReport();
            frm.TopLevel = false;
            panelSwitchReport.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

 //Sales Report Button
        private void btnSalesReport_Click_1(object sender, EventArgs e)
        {
            MV_RSalesReport frm = new MV_RSalesReport();
            frm.TopLevel = false;
            panelSwitchReport.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

// Exit Application
        private void btnLogoutReport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

    }
}
