
namespace Jazzydior
{
    partial class MV_ArchiveMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagerArchiveTopPanel = new System.Windows.Forms.Panel();
            this.lblMArchiveTopTitle = new System.Windows.Forms.Label();
            this.dtgArchiveServices = new System.Windows.Forms.DataGridView();
            this.panelSwitchArchive = new System.Windows.Forms.Panel();
            this.lblSwitchArchiveServicesConnect = new System.Windows.Forms.Label();
            this.panelArchiveServicesPanel = new System.Windows.Forms.Panel();
            this.btnArchiveServiceRestore = new System.Windows.Forms.Button();
            this.btnArchiveServiceDelete = new System.Windows.Forms.Button();
            this.dateTimePickerArchiveServiceTo = new System.Windows.Forms.DateTimePicker();
            this.lblArchiveServiceTo = new System.Windows.Forms.Label();
            this.dateTimePickerArchiveServiceFrom = new System.Windows.Forms.DateTimePicker();
            this.lblArchiveServiceFrom = new System.Windows.Forms.Label();
            this.lblArchiveServiceFilteredBy = new System.Windows.Forms.Label();
            this.lblArchiveServiceFilteredByPanel = new System.Windows.Forms.Label();
            this.btnArchiveServiceLoad = new System.Windows.Forms.Button();
            this.txtBoxArchiveServiceSearch = new System.Windows.Forms.TextBox();
            this.lblArchiveServiceSearch = new System.Windows.Forms.Label();
            this.lblArchiveServiceSearchPanel = new System.Windows.Forms.Label();
            this.btnArchiveServices = new System.Windows.Forms.Button();
            this.btnArchiveStaff = new System.Windows.Forms.Button();
            this.btnArchiveSales = new System.Windows.Forms.Button();
            this.ManagerArchiveTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveServices)).BeginInit();
            this.panelSwitchArchive.SuspendLayout();
            this.panelArchiveServicesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerArchiveTopPanel
            // 
            this.ManagerArchiveTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerArchiveTopPanel.Controls.Add(this.lblMArchiveTopTitle);
            this.ManagerArchiveTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerArchiveTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerArchiveTopPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ManagerArchiveTopPanel.Name = "ManagerArchiveTopPanel";
            this.ManagerArchiveTopPanel.Size = new System.Drawing.Size(1145, 35);
            this.ManagerArchiveTopPanel.TabIndex = 2;
            // 
            // lblMArchiveTopTitle
            // 
            this.lblMArchiveTopTitle.AutoSize = true;
            this.lblMArchiveTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMArchiveTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMArchiveTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMArchiveTopTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMArchiveTopTitle.Name = "lblMArchiveTopTitle";
            this.lblMArchiveTopTitle.Size = new System.Drawing.Size(113, 39);
            this.lblMArchiveTopTitle.TabIndex = 1;
            this.lblMArchiveTopTitle.Text = "Archive";
            // 
            // dtgArchiveServices
            // 
            this.dtgArchiveServices.AllowUserToAddRows = false;
            this.dtgArchiveServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArchiveServices.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgArchiveServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgArchiveServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgArchiveServices.ColumnHeadersHeight = 50;
            this.dtgArchiveServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgArchiveServices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgArchiveServices.EnableHeadersVisualStyles = false;
            this.dtgArchiveServices.Location = new System.Drawing.Point(-1, 120);
            this.dtgArchiveServices.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtgArchiveServices.Name = "dtgArchiveServices";
            this.dtgArchiveServices.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgArchiveServices.RowHeadersWidth = 30;
            this.dtgArchiveServices.RowTemplate.Height = 24;
            this.dtgArchiveServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArchiveServices.Size = new System.Drawing.Size(1117, 536);
            this.dtgArchiveServices.TabIndex = 38;
            // 
            // panelSwitchArchive
            // 
            this.panelSwitchArchive.Controls.Add(this.lblSwitchArchiveServicesConnect);
            this.panelSwitchArchive.Controls.Add(this.panelArchiveServicesPanel);
            this.panelSwitchArchive.Location = new System.Drawing.Point(0, 58);
            this.panelSwitchArchive.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSwitchArchive.Name = "panelSwitchArchive";
            this.panelSwitchArchive.Size = new System.Drawing.Size(1145, 698);
            this.panelSwitchArchive.TabIndex = 39;
            // 
            // lblSwitchArchiveServicesConnect
            // 
            this.lblSwitchArchiveServicesConnect.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblSwitchArchiveServicesConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSwitchArchiveServicesConnect.Location = new System.Drawing.Point(84, 2);
            this.lblSwitchArchiveServicesConnect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSwitchArchiveServicesConnect.Name = "lblSwitchArchiveServicesConnect";
            this.lblSwitchArchiveServicesConnect.Size = new System.Drawing.Size(179, 25);
            this.lblSwitchArchiveServicesConnect.TabIndex = 40;
            // 
            // panelArchiveServicesPanel
            // 
            this.panelArchiveServicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArchiveServicesPanel.Controls.Add(this.btnArchiveServiceRestore);
            this.panelArchiveServicesPanel.Controls.Add(this.btnArchiveServiceDelete);
            this.panelArchiveServicesPanel.Controls.Add(this.dateTimePickerArchiveServiceTo);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceTo);
            this.panelArchiveServicesPanel.Controls.Add(this.dateTimePickerArchiveServiceFrom);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceFrom);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceFilteredBy);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceFilteredByPanel);
            this.panelArchiveServicesPanel.Controls.Add(this.btnArchiveServiceLoad);
            this.panelArchiveServicesPanel.Controls.Add(this.txtBoxArchiveServiceSearch);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceSearch);
            this.panelArchiveServicesPanel.Controls.Add(this.lblArchiveServiceSearchPanel);
            this.panelArchiveServicesPanel.Controls.Add(this.dtgArchiveServices);
            this.panelArchiveServicesPanel.Location = new System.Drawing.Point(14, 26);
            this.panelArchiveServicesPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelArchiveServicesPanel.Name = "panelArchiveServicesPanel";
            this.panelArchiveServicesPanel.Size = new System.Drawing.Size(1117, 657);
            this.panelArchiveServicesPanel.TabIndex = 39;
            // 
            // btnArchiveServiceRestore
            // 
            this.btnArchiveServiceRestore.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceRestore.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceRestore.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceRestore.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceRestore.Location = new System.Drawing.Point(741, 88);
            this.btnArchiveServiceRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceRestore.Name = "btnArchiveServiceRestore";
            this.btnArchiveServiceRestore.Size = new System.Drawing.Size(154, 25);
            this.btnArchiveServiceRestore.TabIndex = 51;
            this.btnArchiveServiceRestore.Text = "Restore";
            this.btnArchiveServiceRestore.UseVisualStyleBackColor = false;
            // 
            // btnArchiveServiceDelete
            // 
            this.btnArchiveServiceDelete.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceDelete.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceDelete.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceDelete.Location = new System.Drawing.Point(899, 87);
            this.btnArchiveServiceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceDelete.Name = "btnArchiveServiceDelete";
            this.btnArchiveServiceDelete.Size = new System.Drawing.Size(207, 25);
            this.btnArchiveServiceDelete.TabIndex = 50;
            this.btnArchiveServiceDelete.Text = "Delete Permanently";
            this.btnArchiveServiceDelete.UseVisualStyleBackColor = false;
            this.btnArchiveServiceDelete.Click += new System.EventHandler(this.btnArchiveServiceDelete_Click);
            // 
            // dateTimePickerArchiveServiceTo
            // 
            this.dateTimePickerArchiveServiceTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceTo.Location = new System.Drawing.Point(412, 35);
            this.dateTimePickerArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceTo.Name = "dateTimePickerArchiveServiceTo";
            this.dateTimePickerArchiveServiceTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceTo.TabIndex = 49;
            // 
            // lblArchiveServiceTo
            // 
            this.lblArchiveServiceTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceTo.Location = new System.Drawing.Point(371, 40);
            this.lblArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceTo.Name = "lblArchiveServiceTo";
            this.lblArchiveServiceTo.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceTo.TabIndex = 48;
            this.lblArchiveServiceTo.Tag = "";
            this.lblArchiveServiceTo.Text = "To:";
            // 
            // dateTimePickerArchiveServiceFrom
            // 
            this.dateTimePickerArchiveServiceFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceFrom.Location = new System.Drawing.Point(190, 35);
            this.dateTimePickerArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceFrom.Name = "dateTimePickerArchiveServiceFrom";
            this.dateTimePickerArchiveServiceFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceFrom.TabIndex = 47;
            // 
            // lblArchiveServiceFrom
            // 
            this.lblArchiveServiceFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFrom.Location = new System.Drawing.Point(126, 40);
            this.lblArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFrom.Name = "lblArchiveServiceFrom";
            this.lblArchiveServiceFrom.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceFrom.TabIndex = 46;
            this.lblArchiveServiceFrom.Text = "From:";
            // 
            // lblArchiveServiceFilteredBy
            // 
            this.lblArchiveServiceFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFilteredBy.Location = new System.Drawing.Point(95, -1);
            this.lblArchiveServiceFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFilteredBy.Name = "lblArchiveServiceFilteredBy";
            this.lblArchiveServiceFilteredBy.Size = new System.Drawing.Size(119, 33);
            this.lblArchiveServiceFilteredBy.TabIndex = 45;
            this.lblArchiveServiceFilteredBy.Text = "Filtered By";
            this.lblArchiveServiceFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveServiceFilteredByPanel
            // 
            this.lblArchiveServiceFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArchiveServiceFilteredByPanel.Location = new System.Drawing.Point(77, 19);
            this.lblArchiveServiceFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFilteredByPanel.Name = "lblArchiveServiceFilteredByPanel";
            this.lblArchiveServiceFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblArchiveServiceFilteredByPanel.TabIndex = 44;
            // 
            // btnArchiveServiceLoad
            // 
            this.btnArchiveServiceLoad.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceLoad.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceLoad.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceLoad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceLoad.Location = new System.Drawing.Point(933, 33);
            this.btnArchiveServiceLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceLoad.Name = "btnArchiveServiceLoad";
            this.btnArchiveServiceLoad.Size = new System.Drawing.Size(80, 29);
            this.btnArchiveServiceLoad.TabIndex = 43;
            this.btnArchiveServiceLoad.Text = "LOAD";
            this.btnArchiveServiceLoad.UseVisualStyleBackColor = false;
            // 
            // txtBoxArchiveServiceSearch
            // 
            this.txtBoxArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArchiveServiceSearch.Location = new System.Drawing.Point(634, 32);
            this.txtBoxArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxArchiveServiceSearch.Multiline = true;
            this.txtBoxArchiveServiceSearch.Name = "txtBoxArchiveServiceSearch";
            this.txtBoxArchiveServiceSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxArchiveServiceSearch.TabIndex = 42;
            // 
            // lblArchiveServiceSearch
            // 
            this.lblArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceSearch.Location = new System.Drawing.Point(603, -1);
            this.lblArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearch.Name = "lblArchiveServiceSearch";
            this.lblArchiveServiceSearch.Size = new System.Drawing.Size(119, 33);
            this.lblArchiveServiceSearch.TabIndex = 41;
            this.lblArchiveServiceSearch.Text = "Search Here";
            this.lblArchiveServiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveServiceSearchPanel
            // 
            this.lblArchiveServiceSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArchiveServiceSearchPanel.Location = new System.Drawing.Point(592, 19);
            this.lblArchiveServiceSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearchPanel.Name = "lblArchiveServiceSearchPanel";
            this.lblArchiveServiceSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblArchiveServiceSearchPanel.TabIndex = 40;
            // 
            // btnArchiveServices
            // 
            this.btnArchiveServices.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServices.FlatAppearance.BorderSize = 0;
            this.btnArchiveServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServices.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServices.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServices.Location = new System.Drawing.Point(84, 46);
            this.btnArchiveServices.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnArchiveServices.Name = "btnArchiveServices";
            this.btnArchiveServices.Size = new System.Drawing.Size(179, 25);
            this.btnArchiveServices.TabIndex = 42;
            this.btnArchiveServices.Text = "Services";
            this.btnArchiveServices.UseVisualStyleBackColor = false;
            this.btnArchiveServices.Click += new System.EventHandler(this.btnArchiveServices_Click);
            // 
            // btnArchiveStaff
            // 
            this.btnArchiveStaff.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveStaff.FlatAppearance.BorderSize = 0;
            this.btnArchiveStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveStaff.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveStaff.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveStaff.Location = new System.Drawing.Point(270, 46);
            this.btnArchiveStaff.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnArchiveStaff.Name = "btnArchiveStaff";
            this.btnArchiveStaff.Size = new System.Drawing.Size(179, 25);
            this.btnArchiveStaff.TabIndex = 45;
            this.btnArchiveStaff.Text = "Staffs";
            this.btnArchiveStaff.UseVisualStyleBackColor = false;
            this.btnArchiveStaff.Click += new System.EventHandler(this.btnArchiveStaff_Click);
            // 
            // btnArchiveSales
            // 
            this.btnArchiveSales.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveSales.FlatAppearance.BorderSize = 0;
            this.btnArchiveSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveSales.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveSales.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveSales.Location = new System.Drawing.Point(455, 46);
            this.btnArchiveSales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnArchiveSales.Name = "btnArchiveSales";
            this.btnArchiveSales.Size = new System.Drawing.Size(179, 25);
            this.btnArchiveSales.TabIndex = 39;
            this.btnArchiveSales.Text = "Sales";
            this.btnArchiveSales.UseVisualStyleBackColor = false;
            this.btnArchiveSales.Click += new System.EventHandler(this.btnArchiveSales_Click);
            // 
            // MV_ArchiveMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.btnArchiveSales);
            this.Controls.Add(this.btnArchiveStaff);
            this.Controls.Add(this.btnArchiveServices);
            this.Controls.Add(this.ManagerArchiveTopPanel);
            this.Controls.Add(this.panelSwitchArchive);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MV_ArchiveMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MV_Archive_Load);
            this.ManagerArchiveTopPanel.ResumeLayout(false);
            this.ManagerArchiveTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveServices)).EndInit();
            this.panelSwitchArchive.ResumeLayout(false);
            this.panelArchiveServicesPanel.ResumeLayout(false);
            this.panelArchiveServicesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagerArchiveTopPanel;
        private System.Windows.Forms.Label lblMArchiveTopTitle;
        private System.Windows.Forms.DataGridView dtgArchiveServices;
        private System.Windows.Forms.Panel panelSwitchArchive;
        private System.Windows.Forms.Panel panelArchiveServicesPanel;
        private System.Windows.Forms.Label lblSwitchArchiveServicesConnect;
        private System.Windows.Forms.Button btnArchiveServices;
        private System.Windows.Forms.Button btnArchiveStaff;
        private System.Windows.Forms.Button btnArchiveSales;
        private System.Windows.Forms.Button btnArchiveServiceRestore;
        private System.Windows.Forms.Button btnArchiveServiceDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveServiceTo;
        private System.Windows.Forms.Label lblArchiveServiceTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveServiceFrom;
        private System.Windows.Forms.Label lblArchiveServiceFrom;
        private System.Windows.Forms.Label lblArchiveServiceFilteredBy;
        private System.Windows.Forms.Label lblArchiveServiceFilteredByPanel;
        private System.Windows.Forms.Button btnArchiveServiceLoad;
        private System.Windows.Forms.TextBox txtBoxArchiveServiceSearch;
        private System.Windows.Forms.Label lblArchiveServiceSearch;
        private System.Windows.Forms.Label lblArchiveServiceSearchPanel;
    }
}