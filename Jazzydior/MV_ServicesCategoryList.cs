using Jazzydior.DBClass;
using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class MV_ServicesCategoryList : Form
    {
        ServicesCategory servicesCategory = new ServicesCategory();

        public MV_ServicesCategoryList()
        {
            InitializeComponent();
        }
        
    // Store Inputted Data to DataGrid
       private void MV_ServiceCategory_Load(object sender, EventArgs e)
        {
            GetCategoryRecord();
        }

        private void GetCategoryRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from servicesCategory", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dtgServiceCategory.DataSource = dt;

            // Change the Column Name
            dtgServiceCategory.Columns[0].Visible = false;
            dtgServiceCategory.Columns["serv_CatID"].HeaderText = "Category ID No";
            dtgServiceCategory.Columns["serv_CategoryName"].HeaderText = "Category Name";
        }

    // Add New Category
        private void btnServicesCategoryAdd_Click(object sender, EventArgs e)
        {
            if (btnCategorySave.Text == "Add")
            {
                btnCategorySave.Text = "Save";
                txtBoxServiceCategoryName.Enabled = false;

                btnCategoryDelete.Enabled = false;

                txtBoxServiceCategoryName.Enabled = true;

            }
            else
            {
                servicesCategory.CategoryName = txtBoxServiceCategoryName.Text;
                int serv_CatID = ServicesCategoryDB.AddServicesCategory(servicesCategory);

                if (MessageBox.Show("Are you sure you want to save this category details?", "Confirm Adding New Category Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Record has been successfully saved.");
                }
                else
                {
                    // Display a message box for the failed condition
                    MessageBox.Show("Add failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtBoxServiceCategoryName.Enabled = true;

                btnCategorySave.Text = "Add";
                btnCategoryDelete.Enabled = true;

                txtBoxServiceCategoryName.Enabled = false;

                ClearFormControls();
                GetCategoryRecord();
            }
        }
     
    // Exit Button for Category List Form
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to leave this form. Do you want to proceed?", "Exit Category List Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    // Delete Button
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            ServicesCategory deleteServiceCategory = new ServicesCategory();

            deleteServiceCategory.CategoryName = txtBoxServiceCategoryName.Text;
            deleteServiceCategory.CategoryID = Convert.ToInt32(txtBoxServiceCategoryID.Text);

            ServicesCategoryDB.DeleteServicesCategory(deleteServiceCategory);

            if (MessageBox.Show("Are you sure you want to delete this category details?", "Confirm Deleteing Category Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Successfully deleted.");
            }
            else
            {
                // Display a message box for the failed condition
                MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetCategoryRecord();
            ClearFormControls();
        }


    // DataGridView Cell Select
        private void dtgServiceCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic data = dtgServiceCategory.SelectedRows[0];

            txtBoxServiceCategoryID.Text = Convert.ToString(data.Cells[0].Value);
            txtBoxServiceCategoryName.Text = data.Cells[1].Value;
        }

    // Clear Button
        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {
            if (btnCategoryCancel.Text == "Cancel")
            {
                btnCategorySave.Enabled = false;
                btnCategoryDelete.Enabled = false;

                ClearFormControls();

                btnCategorySave.Enabled = true;
                btnCategoryDelete.Enabled = true;

                txtBoxServiceCategoryName.Enabled = false;
                btnCategorySave.Text = "Add";
            }

        }

        private void ClearFormControls()
        {
            txtBoxServiceCategoryName.Clear();

            txtBoxServiceCategoryName.Focus();
        }
    }
}
