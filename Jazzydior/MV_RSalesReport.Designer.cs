
namespace Jazzydior
{
    partial class MV_RSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MV_RSalesReport));
            this.lblSwitchSalesRConnect = new System.Windows.Forms.Label();
            this.dtgSalesReport = new System.Windows.Forms.DataGridView();
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.textBoxSalesTotal = new System.Windows.Forms.TextBox();
            this.btnSalesPrintReview = new System.Windows.Forms.Button();
            this.panelSalesReportMainPanel = new System.Windows.Forms.Panel();
            this.btnSalesDelete = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).BeginInit();
            this.panelSalesReportMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSwitchSalesRConnect
            // 
            this.lblSwitchSalesRConnect.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblSwitchSalesRConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSwitchSalesRConnect.Location = new System.Drawing.Point(260, 0);
            this.lblSwitchSalesRConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSwitchSalesRConnect.Name = "lblSwitchSalesRConnect";
            this.lblSwitchSalesRConnect.Size = new System.Drawing.Size(140, 25);
            this.lblSwitchSalesRConnect.TabIndex = 0;
            // 
            // dtgSalesReport
            // 
            this.dtgSalesReport.AllowUserToAddRows = false;
            this.dtgSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSalesReport.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSalesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSalesReport.ColumnHeadersHeight = 50;
            this.dtgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSalesReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSalesReport.EnableHeadersVisualStyles = false;
            this.dtgSalesReport.Location = new System.Drawing.Point(-1, 95);
            this.dtgSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSalesReport.Name = "dtgSalesReport";
            this.dtgSalesReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSalesReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSalesReport.RowHeadersWidth = 30;
            this.dtgSalesReport.RowTemplate.Height = 24;
            this.dtgSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSalesReport.Size = new System.Drawing.Size(1121, 497);
            this.dtgSalesReport.TabIndex = 26;
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTotal.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblSalesTotal.Location = new System.Drawing.Point(626, 607);
            this.lblSalesTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(187, 44);
            this.lblSalesTotal.TabIndex = 27;
            this.lblSalesTotal.Text = "Total Sales:";
            // 
            // textBoxSalesTotal
            // 
            this.textBoxSalesTotal.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalesTotal.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.textBoxSalesTotal.Location = new System.Drawing.Point(757, 600);
            this.textBoxSalesTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSalesTotal.Multiline = true;
            this.textBoxSalesTotal.Name = "textBoxSalesTotal";
            this.textBoxSalesTotal.Size = new System.Drawing.Size(186, 39);
            this.textBoxSalesTotal.TabIndex = 64;
            // 
            // btnSalesPrintReview
            // 
            this.btnSalesPrintReview.BackColor = System.Drawing.Color.Pink;
            this.btnSalesPrintReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesPrintReview.FlatAppearance.BorderSize = 0;
            this.btnSalesPrintReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSalesPrintReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesPrintReview.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesPrintReview.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSalesPrintReview.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesPrintReview.Image")));
            this.btnSalesPrintReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesPrintReview.Location = new System.Drawing.Point(951, 598);
            this.btnSalesPrintReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesPrintReview.Name = "btnSalesPrintReview";
            this.btnSalesPrintReview.Size = new System.Drawing.Size(163, 43);
            this.btnSalesPrintReview.TabIndex = 65;
            this.btnSalesPrintReview.Text = "Print Review";
            this.btnSalesPrintReview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesPrintReview.UseVisualStyleBackColor = false;
            this.btnSalesPrintReview.Click += new System.EventHandler(this.btnSalesPrintReview_Click_1);
            // 
            // panelSalesReportMainPanel
            // 
            this.panelSalesReportMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSalesReportMainPanel.Controls.Add(this.btnSalesDelete);
            this.panelSalesReportMainPanel.Controls.Add(this.dateTimePickerArchiveServiceTo);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceTo);
            this.panelSalesReportMainPanel.Controls.Add(this.dateTimePickerArchiveServiceFrom);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceFrom);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceFilteredBy);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceFilteredByPanel);
            this.panelSalesReportMainPanel.Controls.Add(this.btnArchiveServiceLoad);
            this.panelSalesReportMainPanel.Controls.Add(this.txtBoxArchiveServiceSearch);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceSearch);
            this.panelSalesReportMainPanel.Controls.Add(this.lblArchiveServiceSearchPanel);
            this.panelSalesReportMainPanel.Controls.Add(this.btnSalesPrintReview);
            this.panelSalesReportMainPanel.Controls.Add(this.textBoxSalesTotal);
            this.panelSalesReportMainPanel.Controls.Add(this.lblSalesTotal);
            this.panelSalesReportMainPanel.Controls.Add(this.dtgSalesReport);
            this.panelSalesReportMainPanel.Location = new System.Drawing.Point(13, 25);
            this.panelSalesReportMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelSalesReportMainPanel.Name = "panelSalesReportMainPanel";
            this.panelSalesReportMainPanel.Size = new System.Drawing.Size(1121, 649);
            this.panelSalesReportMainPanel.TabIndex = 1;
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.BackColor = System.Drawing.Color.Pink;
            this.btnSalesDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalesDelete.BackgroundImage")));
            this.btnSalesDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalesDelete.FlatAppearance.BorderSize = 0;
            this.btnSalesDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSalesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDelete.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.btnSalesDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSalesDelete.Location = new System.Drawing.Point(1071, 50);
            this.btnSalesDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(43, 40);
            this.btnSalesDelete.TabIndex = 63;
            this.btnSalesDelete.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerArchiveServiceTo
            // 
            this.dateTimePickerArchiveServiceTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceTo.Location = new System.Drawing.Point(409, 30);
            this.dateTimePickerArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceTo.Name = "dateTimePickerArchiveServiceTo";
            this.dateTimePickerArchiveServiceTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceTo.TabIndex = 60;
            // 
            // lblArchiveServiceTo
            // 
            this.lblArchiveServiceTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceTo.Location = new System.Drawing.Point(368, 35);
            this.lblArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceTo.Name = "lblArchiveServiceTo";
            this.lblArchiveServiceTo.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceTo.TabIndex = 60;
            this.lblArchiveServiceTo.Tag = "";
            this.lblArchiveServiceTo.Text = "To:";
            // 
            // dateTimePickerArchiveServiceFrom
            // 
            this.dateTimePickerArchiveServiceFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceFrom.Location = new System.Drawing.Point(187, 30);
            this.dateTimePickerArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceFrom.Name = "dateTimePickerArchiveServiceFrom";
            this.dateTimePickerArchiveServiceFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceFrom.TabIndex = 59;
            // 
            // lblArchiveServiceFrom
            // 
            this.lblArchiveServiceFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFrom.Location = new System.Drawing.Point(123, 35);
            this.lblArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFrom.Name = "lblArchiveServiceFrom";
            this.lblArchiveServiceFrom.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceFrom.TabIndex = 58;
            this.lblArchiveServiceFrom.Text = "From:";
            // 
            // lblArchiveServiceFilteredBy
            // 
            this.lblArchiveServiceFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFilteredBy.Location = new System.Drawing.Point(92, 0);
            this.lblArchiveServiceFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFilteredBy.Name = "lblArchiveServiceFilteredBy";
            this.lblArchiveServiceFilteredBy.Size = new System.Drawing.Size(119, 33);
            this.lblArchiveServiceFilteredBy.TabIndex = 57;
            this.lblArchiveServiceFilteredBy.Text = "Filtered By";
            this.lblArchiveServiceFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveServiceFilteredByPanel
            // 
            this.lblArchiveServiceFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArchiveServiceFilteredByPanel.Location = new System.Drawing.Point(74, 14);
            this.lblArchiveServiceFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFilteredByPanel.Name = "lblArchiveServiceFilteredByPanel";
            this.lblArchiveServiceFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblArchiveServiceFilteredByPanel.TabIndex = 56;
            // 
            // btnArchiveServiceLoad
            // 
            this.btnArchiveServiceLoad.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceLoad.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceLoad.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceLoad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceLoad.Location = new System.Drawing.Point(930, 29);
            this.btnArchiveServiceLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceLoad.Name = "btnArchiveServiceLoad";
            this.btnArchiveServiceLoad.Size = new System.Drawing.Size(71, 26);
            this.btnArchiveServiceLoad.TabIndex = 62;
            this.btnArchiveServiceLoad.Text = "LOAD";
            this.btnArchiveServiceLoad.UseVisualStyleBackColor = false;
            // 
            // txtBoxArchiveServiceSearch
            // 
            this.txtBoxArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArchiveServiceSearch.Location = new System.Drawing.Point(631, 27);
            this.txtBoxArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxArchiveServiceSearch.Multiline = true;
            this.txtBoxArchiveServiceSearch.Name = "txtBoxArchiveServiceSearch";
            this.txtBoxArchiveServiceSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxArchiveServiceSearch.TabIndex = 61;
            // 
            // lblArchiveServiceSearch
            // 
            this.lblArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceSearch.Location = new System.Drawing.Point(600, -1);
            this.lblArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearch.Name = "lblArchiveServiceSearch";
            this.lblArchiveServiceSearch.Size = new System.Drawing.Size(119, 33);
            this.lblArchiveServiceSearch.TabIndex = 53;
            this.lblArchiveServiceSearch.Text = "Search Here";
            this.lblArchiveServiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveServiceSearchPanel
            // 
            this.lblArchiveServiceSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArchiveServiceSearchPanel.Location = new System.Drawing.Point(589, 14);
            this.lblArchiveServiceSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearchPanel.Name = "lblArchiveServiceSearchPanel";
            this.lblArchiveServiceSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblArchiveServiceSearchPanel.TabIndex = 52;
            // 
            // MV_RSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1147, 683);
            this.ControlBox = false;
            this.Controls.Add(this.panelSalesReportMainPanel);
            this.Controls.Add(this.lblSwitchSalesRConnect);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MV_RSalesReport";
            this.Load += new System.EventHandler(this.MV_RSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).EndInit();
            this.panelSalesReportMainPanel.ResumeLayout(false);
            this.panelSalesReportMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSwitchSalesRConnect;
        private System.Windows.Forms.DataGridView dtgSalesReport;
        private System.Windows.Forms.Label lblSalesTotal;
        private System.Windows.Forms.TextBox textBoxSalesTotal;
        private System.Windows.Forms.Button btnSalesPrintReview;
        private System.Windows.Forms.Panel panelSalesReportMainPanel;
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
        private System.Windows.Forms.Button btnSalesDelete;
    }
}