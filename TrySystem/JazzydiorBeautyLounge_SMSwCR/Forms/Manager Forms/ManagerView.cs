using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzydiorBeautyLounge_SMSwCR
{

    public partial class ManagerView : Form
    {
        
        public ManagerView()
        {
            InitializeComponent();
        }

        private void btnManagerHome_Click(object sender, EventArgs e)
        {
            Forms.FormManagerHome frm = new Forms.FormManagerHome();
            frm.TopLevel = false;
            ManagerRightPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
