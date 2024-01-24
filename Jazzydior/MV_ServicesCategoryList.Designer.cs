
namespace Jazzydior
{
    partial class MV_ServicesCategoryList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MV_ServicesCategoryList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagerServicesCategoryTopPanel = new System.Windows.Forms.Panel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.lblMCategoryListTopTitle = new System.Windows.Forms.Label();
            this.txtBoxServiceCategoryID = new System.Windows.Forms.TextBox();
            this.dtgServiceCategory = new System.Windows.Forms.DataGridView();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.txtBoxServiceCategoryName = new System.Windows.Forms.TextBox();
            this.lblAddServiceCategoryName = new System.Windows.Forms.Label();
            this.btnCategoryCancel = new System.Windows.Forms.Button();
            this.ManagerServicesCategoryTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiceCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerServicesCategoryTopPanel
            // 
            this.ManagerServicesCategoryTopPanel.BackColor = System.Drawing.Color.LightPink;
            this.ManagerServicesCategoryTopPanel.Controls.Add(this.btnExitForm);
            this.ManagerServicesCategoryTopPanel.Controls.Add(this.lblMCategoryListTopTitle);
            this.ManagerServicesCategoryTopPanel.Controls.Add(this.txtBoxServiceCategoryID);
            this.ManagerServicesCategoryTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerServicesCategoryTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerServicesCategoryTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerServicesCategoryTopPanel.Name = "ManagerServicesCategoryTopPanel";
            this.ManagerServicesCategoryTopPanel.Size = new System.Drawing.Size(982, 52);
            this.ManagerServicesCategoryTopPanel.TabIndex = 2;
            // 
            // btnExitForm
            // 
            this.btnExitForm.BackColor = System.Drawing.Color.LightPink;
            this.btnExitForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitForm.BackgroundImage")));
            this.btnExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitForm.ForeColor = System.Drawing.Color.LightPink;
            this.btnExitForm.Location = new System.Drawing.Point(936, 1);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(46, 48);
            this.btnExitForm.TabIndex = 37;
            this.btnExitForm.UseVisualStyleBackColor = false;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // lblMCategoryListTopTitle
            // 
            this.lblMCategoryListTopTitle.AutoSize = true;
            this.lblMCategoryListTopTitle.Font = new System.Drawing.Font("Script MT Bold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCategoryListTopTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblMCategoryListTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMCategoryListTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMCategoryListTopTitle.Name = "lblMCategoryListTopTitle";
            this.lblMCategoryListTopTitle.Size = new System.Drawing.Size(252, 52);
            this.lblMCategoryListTopTitle.TabIndex = 1;
            this.lblMCategoryListTopTitle.Text = "Category List";
            // 
            // txtBoxServiceCategoryID
            // 
            this.txtBoxServiceCategoryID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxServiceCategoryID.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxServiceCategoryID.Enabled = false;
            this.txtBoxServiceCategoryID.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtBoxServiceCategoryID.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.txtBoxServiceCategoryID.Location = new System.Drawing.Point(638, 3);
            this.txtBoxServiceCategoryID.Multiline = true;
            this.txtBoxServiceCategoryID.Name = "txtBoxServiceCategoryID";
            this.txtBoxServiceCategoryID.Size = new System.Drawing.Size(303, 41);
            this.txtBoxServiceCategoryID.TabIndex = 37;
            this.txtBoxServiceCategoryID.Visible = false;
            // 
            // dtgServiceCategory
            // 
            this.dtgServiceCategory.AllowUserToAddRows = false;
            this.dtgServiceCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgServiceCategory.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dtgServiceCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgServiceCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServiceCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServiceCategory.ColumnHeadersHeight = 50;
            this.dtgServiceCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServiceCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgServiceCategory.EnableHeadersVisualStyles = false;
            this.dtgServiceCategory.Location = new System.Drawing.Point(13, 158);
            this.dtgServiceCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgServiceCategory.Name = "dtgServiceCategory";
            this.dtgServiceCategory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServiceCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgServiceCategory.RowHeadersWidth = 30;
            this.dtgServiceCategory.RowTemplate.Height = 24;
            this.dtgServiceCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgServiceCategory.Size = new System.Drawing.Size(956, 483);
            this.dtgServiceCategory.TabIndex = 27;
            this.dtgServiceCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgServiceCategory_CellClick);
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.BackColor = System.Drawing.Color.Pink;
            this.btnCategorySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCategorySave.FlatAppearance.BorderSize = 0;
            this.btnCategorySave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnCategorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorySave.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnCategorySave.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCategorySave.Location = new System.Drawing.Point(771, 107);
            this.btnCategorySave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(88, 32);
            this.btnCategorySave.TabIndex = 33;
            this.btnCategorySave.Text = "Add";
            this.btnCategorySave.UseVisualStyleBackColor = false;
            this.btnCategorySave.Click += new System.EventHandler(this.btnServicesCategoryAdd_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.BackColor = System.Drawing.Color.Pink;
            this.btnCategoryDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCategoryDelete.FlatAppearance.BorderSize = 0;
            this.btnCategoryDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnCategoryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryDelete.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnCategoryDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCategoryDelete.Location = new System.Drawing.Point(867, 107);
            this.btnCategoryDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(88, 32);
            this.btnCategoryDelete.TabIndex = 36;
            this.btnCategoryDelete.Text = "Delete";
            this.btnCategoryDelete.UseVisualStyleBackColor = false;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // txtBoxServiceCategoryName
            // 
            this.txtBoxServiceCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxServiceCategoryName.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxServiceCategoryName.Enabled = false;
            this.txtBoxServiceCategoryName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtBoxServiceCategoryName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.txtBoxServiceCategoryName.Location = new System.Drawing.Point(664, 61);
            this.txtBoxServiceCategoryName.Multiline = true;
            this.txtBoxServiceCategoryName.Name = "txtBoxServiceCategoryName";
            this.txtBoxServiceCategoryName.Size = new System.Drawing.Size(303, 41);
            this.txtBoxServiceCategoryName.TabIndex = 32;
            // 
            // lblAddServiceCategoryName
            // 
            this.lblAddServiceCategoryName.AutoSize = true;
            this.lblAddServiceCategoryName.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddServiceCategoryName.ForeColor = System.Drawing.Color.MistyRose;
            this.lblAddServiceCategoryName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddServiceCategoryName.Location = new System.Drawing.Point(434, 65);
            this.lblAddServiceCategoryName.Name = "lblAddServiceCategoryName";
            this.lblAddServiceCategoryName.Size = new System.Drawing.Size(215, 27);
            this.lblAddServiceCategoryName.TabIndex = 31;
            this.lblAddServiceCategoryName.Text = "Category Name :";
            // 
            // btnCategoryCancel
            // 
            this.btnCategoryCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCategoryCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCategoryCancel.FlatAppearance.BorderSize = 0;
            this.btnCategoryCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnCategoryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryCancel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryCancel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCategoryCancel.Location = new System.Drawing.Point(675, 107);
            this.btnCategoryCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoryCancel.Name = "btnCategoryCancel";
            this.btnCategoryCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCategoryCancel.TabIndex = 34;
            this.btnCategoryCancel.Text = "Cancel";
            this.btnCategoryCancel.UseVisualStyleBackColor = false;
            this.btnCategoryCancel.Click += new System.EventHandler(this.btnCategoryCancel_Click);
            // 
            // MV_ServicesCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.ControlBox = false;
            this.Controls.Add(this.btnCategoryCancel);
            this.Controls.Add(this.lblAddServiceCategoryName);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.dtgServiceCategory);
            this.Controls.Add(this.ManagerServicesCategoryTopPanel);
            this.Controls.Add(this.txtBoxServiceCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(580, 180);
            this.Name = "MV_ServicesCategoryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MV_ServiceCategory_Load);
            this.ManagerServicesCategoryTopPanel.ResumeLayout(false);
            this.ManagerServicesCategoryTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiceCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManagerServicesCategoryTopPanel;
        private System.Windows.Forms.Label lblMCategoryListTopTitle;
        private System.Windows.Forms.DataGridView dtgServiceCategory;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.TextBox txtBoxServiceCategoryName;
        private System.Windows.Forms.Label lblAddServiceCategoryName;
        private System.Windows.Forms.Button btnCategoryCancel;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.TextBox txtBoxServiceCategoryID;
    }
}