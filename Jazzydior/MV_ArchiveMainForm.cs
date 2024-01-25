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
    public partial class MV_ArchiveMainForm : Form
    {

        public MV_ArchiveMainForm()
        {
            InitializeComponent();

        }

        // Load Inputted Data to DataGrid
        private void MV_Archive_Load(object sender, EventArgs e)
        {
        
        }

    //Services Button in Archive Page
        private void btnArchiveServices_Click(object sender, EventArgs e)
        {
            MV_ArchiveServices frm = new MV_ArchiveServices();
            frm.TopLevel = false;
            panelSwitchArchive.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Staffs Button in Archive Page
        private void btnArchiveStaff_Click(object sender, EventArgs e)
        {
            MV_ArchiveStaffs frm = new MV_ArchiveStaffs();
            frm.TopLevel = false;
            panelSwitchArchive.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

//Sales Button in Archive Page
        private void btnArchiveSales_Click(object sender, EventArgs e)
            {
                MV_ArchiveSales frm = new MV_ArchiveSales();
                frm.TopLevel = false;
                panelSwitchArchive.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }

// Exit Application
        private void btnLogoutArchive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this application and you'll need to log in again.", "Are you sure you want to logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
        }

    // Delete Permanently Button
        private void btnArchiveServiceDelete_Click(object sender, EventArgs e)
        {
            Services deleteService = new Services();

            //deleteService.ServiceName = txtBoxAddServicesName.Text;
            //deleteService.ServiceID = Convert.ToInt32(txtBoxServID.Text);
            //deleteService.ServiceCategory = txtBoxAddServicesCategory.Text;
            //deleteService.ServiceLeadTime = txtBoxAddServiceLeadTime.Text;
            //deleteService.ServicePrice = Convert.ToDouble(txtBoxAddServicePrice.Text);

            if (MessageBox.Show("This details will be deleted permanently! Are you sure you want to proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }

            ServicesDB.DeleteServices(deleteService);
            //GetServiceRecord();
        }

        public void SetSelectedData(List<string> data)
        {
            // Populate DataGridView in Form2 with selected data
            foreach (string item in data)
            {
                dtgArchiveServices.Rows.Add(item);
            }
        }

        private void dtgArchiveServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
