namespace Jazzydior
{
    partial class MV_ReportsMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMReportsTopTitle = new System.Windows.Forms.Label();
            this.ManagerReportsTopPanel = new System.Windows.Forms.Panel();
            this.btnTransactionReport = new System.Windows.Forms.Button();
            this.panelSwitchReport = new System.Windows.Forms.Panel();
            this.panelTransactionReportMainPanel = new System.Windows.Forms.Panel();
            this.txtBoxTransactionSearch = new System.Windows.Forms.TextBox();
            this.lblTransactionSearch = new System.Windows.Forms.Label();
            this.btnTransactionLoad = new System.Windows.Forms.Button();
            this.dataGridViewTransactionReport = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTransactionTo = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionTo = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionFrom = new System.Windows.Forms.Label();
            this.lblTransactionFilteredBy = new System.Windows.Forms.Label();
            this.lblTransactionFilteredByPanel = new System.Windows.Forms.Label();
            this.lblTransactionSearchPanel = new System.Windows.Forms.Label();
            this.lblSwitchTransactionConnect = new System.Windows.Forms.Label();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.ManagerReportsTopPanel.SuspendLayout();
            this.panelSwitchReport.SuspendLayout();
            this.panelTransactionReportMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMReportsTopTitle
            // 
            this.lblMReportsTopTitle.AutoSize = true;
            this.lblMReportsTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMReportsTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMReportsTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMReportsTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMReportsTopTitle.Name = "lblMReportsTopTitle";
            this.lblMReportsTopTitle.Size = new System.Drawing.Size(122, 39);
            this.lblMReportsTopTitle.TabIndex = 1;
            this.lblMReportsTopTitle.Text = "Reports";
            // 
            // ManagerReportsTopPanel
            // 
            this.ManagerReportsTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerReportsTopPanel.Controls.Add(this.lblMReportsTopTitle);
            this.ManagerReportsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerReportsTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerReportsTopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ManagerReportsTopPanel.Name = "ManagerReportsTopPanel";
            this.ManagerReportsTopPanel.Size = new System.Drawing.Size(1145, 35);
            this.ManagerReportsTopPanel.TabIndex = 3;
            // 
            // btnTransactionReport
            // 
            this.btnTransactionReport.BackColor = System.Drawing.Color.Pink;
            this.btnTransactionReport.FlatAppearance.BorderSize = 0;
            this.btnTransactionReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnTransactionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionReport.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionReport.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransactionReport.Location = new System.Drawing.Point(42, 52);
            this.btnTransactionReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactionReport.Name = "btnTransactionReport";
            this.btnTransactionReport.Size = new System.Drawing.Size(210, 25);
            this.btnTransactionReport.TabIndex = 17;
            this.btnTransactionReport.Text = "Transaction Report";
            this.btnTransactionReport.UseVisualStyleBackColor = false;
            this.btnTransactionReport.Click += new System.EventHandler(this.btnTransactionReport_Click);
            // 
            // panelSwitchReport
            // 
            this.panelSwitchReport.Controls.Add(this.panelTransactionReportMainPanel);
            this.panelSwitchReport.Controls.Add(this.lblSwitchTransactionConnect);
            this.panelSwitchReport.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.panelSwitchReport.Location = new System.Drawing.Point(-1, 73);
            this.panelSwitchReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSwitchReport.Name = "panelSwitchReport";
            this.panelSwitchReport.Size = new System.Drawing.Size(1147, 683);
            this.panelSwitchReport.TabIndex = 18;
            // 
            // panelTransactionReportMainPanel
            // 
            this.panelTransactionReportMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransactionReportMainPanel.Controls.Add(this.txtBoxTransactionSearch);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionSearch);
            this.panelTransactionReportMainPanel.Controls.Add(this.btnTransactionLoad);
            this.panelTransactionReportMainPanel.Controls.Add(this.dataGridViewTransactionReport);
            this.panelTransactionReportMainPanel.Controls.Add(this.dateTimePickerTransactionTo);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionTo);
            this.panelTransactionReportMainPanel.Controls.Add(this.dateTimePickerTransactionFrom);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionFrom);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionFilteredBy);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionFilteredByPanel);
            this.panelTransactionReportMainPanel.Controls.Add(this.lblTransactionSearchPanel);
            this.panelTransactionReportMainPanel.Location = new System.Drawing.Point(16, 24);
            this.panelTransactionReportMainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTransactionReportMainPanel.Name = "panelTransactionReportMainPanel";
            this.panelTransactionReportMainPanel.Size = new System.Drawing.Size(1115, 641);
            this.panelTransactionReportMainPanel.TabIndex = 3;
            // 
            // txtBoxTransactionSearch
            // 
            this.txtBoxTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTransactionSearch.Location = new System.Drawing.Point(625, 31);
            this.txtBoxTransactionSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxTransactionSearch.Multiline = true;
            this.txtBoxTransactionSearch.Name = "txtBoxTransactionSearch";
            this.txtBoxTransactionSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxTransactionSearch.TabIndex = 18;
            this.txtBoxTransactionSearch.TextChanged += new System.EventHandler(this.txtBoxTransactionSearch_TextChanged);
            // 
            // lblTransactionSearch
            // 
            this.lblTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionSearch.Location = new System.Drawing.Point(594, 3);
            this.lblTransactionSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionSearch.Name = "lblTransactionSearch";
            this.lblTransactionSearch.Size = new System.Drawing.Size(119, 33);
            this.lblTransactionSearch.TabIndex = 17;
            this.lblTransactionSearch.Text = "Search Here";
            this.lblTransactionSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransactionLoad
            // 
            this.btnTransactionLoad.BackColor = System.Drawing.Color.Pink;
            this.btnTransactionLoad.FlatAppearance.BorderSize = 0;
            this.btnTransactionLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnTransactionLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionLoad.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionLoad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransactionLoad.Location = new System.Drawing.Point(926, 33);
            this.btnTransactionLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactionLoad.Name = "btnTransactionLoad";
            this.btnTransactionLoad.Size = new System.Drawing.Size(78, 29);
            this.btnTransactionLoad.TabIndex = 19;
            this.btnTransactionLoad.Text = "LOAD";
            this.btnTransactionLoad.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTransactionReport
            // 
            this.dataGridViewTransactionReport.AllowUserToAddRows = false;
            this.dataGridViewTransactionReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactionReport.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewTransactionReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTransactionReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTransactionReport.ColumnHeadersHeight = 50;
            this.dataGridViewTransactionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransactionReport.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTransactionReport.EnableHeadersVisualStyles = false;
            this.dataGridViewTransactionReport.Location = new System.Drawing.Point(-1, 95);
            this.dataGridViewTransactionReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewTransactionReport.Name = "dataGridViewTransactionReport";
            this.dataGridViewTransactionReport.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTransactionReport.RowHeadersWidth = 30;
            this.dataGridViewTransactionReport.RowTemplate.Height = 24;
            this.dataGridViewTransactionReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactionReport.Size = new System.Drawing.Size(1116, 545);
            this.dataGridViewTransactionReport.TabIndex = 26;
            // 
            // dateTimePickerTransactionTo
            // 
            this.dateTimePickerTransactionTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionTo.Location = new System.Drawing.Point(403, 34);
            this.dateTimePickerTransactionTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionTo.Name = "dateTimePickerTransactionTo";
            this.dateTimePickerTransactionTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionTo.TabIndex = 25;
            this.dateTimePickerTransactionTo.ValueChanged += new System.EventHandler(this.dateTimePickerTransactionTo_ValueChanged);
            // 
            // lblTransactionTo
            // 
            this.lblTransactionTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionTo.Location = new System.Drawing.Point(362, 39);
            this.lblTransactionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionTo.Name = "lblTransactionTo";
            this.lblTransactionTo.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionTo.TabIndex = 24;
            this.lblTransactionTo.Tag = "";
            this.lblTransactionTo.Text = "To:";
            // 
            // dateTimePickerTransactionFrom
            // 
            this.dateTimePickerTransactionFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionFrom.Location = new System.Drawing.Point(181, 34);
            this.dateTimePickerTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionFrom.Name = "dateTimePickerTransactionFrom";
            this.dateTimePickerTransactionFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionFrom.TabIndex = 23;
            this.dateTimePickerTransactionFrom.ValueChanged += new System.EventHandler(this.dateTimePickerTransactionFrom_ValueChanged);
            // 
            // lblTransactionFrom
            // 
            this.lblTransactionFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFrom.Location = new System.Drawing.Point(117, 39);
            this.lblTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFrom.Name = "lblTransactionFrom";
            this.lblTransactionFrom.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionFrom.TabIndex = 22;
            this.lblTransactionFrom.Text = "From:";
            // 
            // lblTransactionFilteredBy
            // 
            this.lblTransactionFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFilteredBy.Location = new System.Drawing.Point(86, 3);
            this.lblTransactionFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredBy.Name = "lblTransactionFilteredBy";
            this.lblTransactionFilteredBy.Size = new System.Drawing.Size(119, 33);
            this.lblTransactionFilteredBy.TabIndex = 21;
            this.lblTransactionFilteredBy.Text = "Filtered By";
            this.lblTransactionFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionFilteredByPanel
            // 
            this.lblTransactionFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionFilteredByPanel.Location = new System.Drawing.Point(68, 18);
            this.lblTransactionFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredByPanel.Name = "lblTransactionFilteredByPanel";
            this.lblTransactionFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblTransactionFilteredByPanel.TabIndex = 20;
            // 
            // lblTransactionSearchPanel
            // 
            this.lblTransactionSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionSearchPanel.Location = new System.Drawing.Point(583, 18);
            this.lblTransactionSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionSearchPanel.Name = "lblTransactionSearchPanel";
            this.lblTransactionSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblTransactionSearchPanel.TabIndex = 16;
            // 
            // lblSwitchTransactionConnect
            // 
            this.lblSwitchTransactionConnect.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblSwitchTransactionConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSwitchTransactionConnect.Location = new System.Drawing.Point(43, 0);
            this.lblSwitchTransactionConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSwitchTransactionConnect.Name = "lblSwitchTransactionConnect";
            this.lblSwitchTransactionConnect.Size = new System.Drawing.Size(210, 25);
            this.lblSwitchTransactionConnect.TabIndex = 2;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.Pink;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSalesReport.Location = new System.Drawing.Point(259, 52);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(140, 25);
            this.btnSalesReport.TabIndex = 19;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click_1);
            // 
            // MV_ReportsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnTransactionReport);
            this.Controls.Add(this.panelSwitchReport);
            this.Controls.Add(this.ManagerReportsTopPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MV_ReportsMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ManagerReportsTopPanel.ResumeLayout(false);
            this.ManagerReportsTopPanel.PerformLayout();
            this.panelSwitchReport.ResumeLayout(false);
            this.panelTransactionReportMainPanel.ResumeLayout(false);
            this.panelTransactionReportMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMReportsTopTitle;
        private System.Windows.Forms.Panel ManagerReportsTopPanel;
        private System.Windows.Forms.Button btnTransactionReport;
        private System.Windows.Forms.Panel panelSwitchReport;
        private System.Windows.Forms.Panel panelTransactionReportMainPanel;
        private System.Windows.Forms.Label lblSwitchTransactionConnect;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.TextBox txtBoxTransactionSearch;
        private System.Windows.Forms.Label lblTransactionSearch;
        private System.Windows.Forms.Button btnTransactionLoad;
        private System.Windows.Forms.DataGridView dataGridViewTransactionReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionTo;
        private System.Windows.Forms.Label lblTransactionTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFilteredBy;
        private System.Windows.Forms.Label lblTransactionFilteredByPanel;
        private System.Windows.Forms.Label lblTransactionSearchPanel;
    }
}