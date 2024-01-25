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
    public partial class MV_UserPosition : Form
    {
        Position position = new Position();

        public MV_UserPosition()
        {
            InitializeComponent();
        }

    // Load Data to DataGridView
        private void MV_Position_Load(object sender, EventArgs e)
        {
            GetPositionRecord();
        }

        private void GetPositionRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from position", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dtgPosition.DataSource = dt;

            // Change the Column Name
            dtgPosition.Columns[0].Visible = false;
            dtgPosition.Columns["position_ID"].HeaderText = "Position ID No";
            dtgPosition.Columns["position_Name"].HeaderText = "Position Name";
        }


    // Save Button to Add New User Position
        private void btnPositionSave_Click(object sender, EventArgs e)
        {
            if (btnPositionSave.Text == "Add")
            {
                btnPositionSave.Text = "Save";
                txtBoxPositionName.Enabled = false;

                btnPositionUpdate.Enabled = false;
                btnPositionDelete.Enabled = false;

                txtBoxPositionName.Enabled = true;
            }
            else
            {
            position.PositionName = txtBoxPositionName.Text;
            int position_ID = PositionDB.AddPosition(position);

            if (MessageBox.Show("Are you sure you want to save this position?", "Confirm Adding New User Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Record has been successfully saved.");
            }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Add failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtBoxPositionName.Enabled = true;
                
                btnPositionSave.Text = "Add";
                btnPositionUpdate.Enabled = true;
                btnPositionDelete.Enabled = true;

                txtBoxPositionName.Enabled = false;

                ClearFormControls();
                GetPositionRecord();
            }
        }

    // Exit Button for Add New Position
        private void btnExitUserPosition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Adding New User Position Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    // Cancel Button
        private void btnPositionCancel_Click(object sender, EventArgs e)
        {
            if (btnPositionCancel.Text == "Cancel")
            {
                btnPositionSave.Enabled = false;
                btnPositionUpdate.Enabled = false;
                btnPositionDelete.Enabled = false;

                ClearFormControls();

                btnPositionSave.Enabled = true;
                btnPositionUpdate.Enabled = true;
                btnPositionDelete.Enabled = true;

                txtBoxPositionName.Enabled = false;

                btnPositionSave.Text = "Add";
                btnPositionUpdate.Text = "Edit";
            }
        }

        private void ClearFormControls()
        {
            txtBoxPositionName.Clear();

            txtBoxPositionName.Focus();
        }


    // DataGridView Cell Select
        private void dtgPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic data = dtgPosition.SelectedRows[0];

            txtBoxPositionID.Text = Convert.ToString(data.Cells[0].Value);
            txtBoxPositionName.Text = data.Cells[1].Value;
        }

    // Edit Button
        private void btnPositionUpdate_Click(object sender, EventArgs e)
        {
            if (btnPositionUpdate.Text == "Edit")
            {
                btnPositionUpdate.Text = "Update";
                txtBoxPositionName.Enabled = false;

                btnPositionSave.Enabled = false;
                btnPositionDelete.Enabled = false;

                txtBoxPositionName.Enabled = true;
            }
            else
            {
                Position updatePosition = new Position();

                updatePosition.PositionName = txtBoxPositionName.Text;
                updatePosition.PositionID = Convert.ToInt32(txtBoxPositionID.Text);

                PositionDB.UpdatePosition(updatePosition);

                if (MessageBox.Show("Are you sure you want to update this position?", "Confirm Updating User Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Successfully updated.");
                }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetPositionRecord();
                ClearFormControls();

                txtBoxPositionName.Enabled = true;

                btnPositionUpdate.Text = "Edit";
                btnPositionSave.Enabled = true;
                btnPositionDelete.Enabled = true;

                txtBoxPositionName.Enabled = false;
            }
        }

    // Delete Button
        private void btnPositionDelete_Click(object sender, EventArgs e)
        {
            Position deletePosition = new Position();

            deletePosition.PositionName = txtBoxPositionName.Text;
            deletePosition.PositionID = Convert.ToInt32(txtBoxPositionID.Text);

            PositionDB.DeletePosition(deletePosition);

            if (MessageBox.Show("Are you sure you want to delete this position?", "Confirm Deleting Position Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetPositionRecord();
            ClearFormControls();
        }
    }
    
}
