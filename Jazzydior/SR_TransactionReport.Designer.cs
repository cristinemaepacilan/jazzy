
namespace Jazzydior
{
    partial class SR_TransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_TransactionReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxTransactionSearch = new System.Windows.Forms.TextBox();
            this.lblTransactionSearch = new System.Windows.Forms.Label();
            this.btnTransactionLoad = new System.Windows.Forms.Button();
            this.btnTransactionDelete = new System.Windows.Forms.Button();
            this.dtgTransactionRep = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTransactionTo = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionTo = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionFrom = new System.Windows.Forms.Label();
            this.lblTransactionFilteredBy = new System.Windows.Forms.Label();
            this.lblTransactionFilteredByPanel = new System.Windows.Forms.Label();
            this.lblTransactionSearchPanel = new System.Windows.Forms.Label();
            this.ManagerReportsTopPanel = new System.Windows.Forms.Panel();
            this.lblMReportsTopTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionRep)).BeginInit();
            this.ManagerReportsTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxTransactionSearch
            // 
            this.txtBoxTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTransactionSearch.Location = new System.Drawing.Point(577, 73);
            this.txtBoxTransactionSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxTransactionSearch.Multiline = true;
            this.txtBoxTransactionSearch.Name = "txtBoxTransactionSearch";
            this.txtBoxTransactionSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxTransactionSearch.TabIndex = 34;
            // 
            // lblTransactionSearch
            // 
            this.lblTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTransactionSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionSearch.Location = new System.Drawing.Point(546, 45);
            this.lblTransactionSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionSearch.Name = "lblTransactionSearch";
            this.lblTransactionSearch.Size = new System.Drawing.Size(119, 33);
            this.lblTransactionSearch.TabIndex = 33;
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
            this.btnTransactionLoad.Location = new System.Drawing.Point(876, 70);
            this.btnTransactionLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactionLoad.Name = "btnTransactionLoad";
            this.btnTransactionLoad.Size = new System.Drawing.Size(89, 35);
            this.btnTransactionLoad.TabIndex = 35;
            this.btnTransactionLoad.Text = "LOAD";
            this.btnTransactionLoad.UseVisualStyleBackColor = false;
            // 
            // btnTransactionDelete
            // 
            this.btnTransactionDelete.BackColor = System.Drawing.Color.Pink;
            this.btnTransactionDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransactionDelete.BackgroundImage")));
            this.btnTransactionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransactionDelete.FlatAppearance.BorderSize = 0;
            this.btnTransactionDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnTransactionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionDelete.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnTransactionDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnTransactionDelete.Location = new System.Drawing.Point(1078, 90);
            this.btnTransactionDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactionDelete.Name = "btnTransactionDelete";
            this.btnTransactionDelete.Size = new System.Drawing.Size(50, 43);
            this.btnTransactionDelete.TabIndex = 44;
            this.btnTransactionDelete.UseVisualStyleBackColor = false;
            // 
            // dtgTransactionRep
            // 
            this.dtgTransactionRep.AllowUserToAddRows = false;
            this.dtgTransactionRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTransactionRep.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgTransactionRep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTransactionRep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTransactionRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTransactionRep.ColumnHeadersHeight = 50;
            this.dtgTransactionRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTransactionRep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTransactionRep.EnableHeadersVisualStyles = false;
            this.dtgTransactionRep.Location = new System.Drawing.Point(13, 136);
            this.dtgTransactionRep.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTransactionRep.Name = "dtgTransactionRep";
            this.dtgTransactionRep.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTransactionRep.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTransactionRep.RowHeadersWidth = 30;
            this.dtgTransactionRep.RowTemplate.Height = 24;
            this.dtgTransactionRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTransactionRep.Size = new System.Drawing.Size(1115, 609);
            this.dtgTransactionRep.TabIndex = 42;
            // 
            // dateTimePickerTransactionTo
            // 
            this.dateTimePickerTransactionTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionTo.Location = new System.Drawing.Point(355, 76);
            this.dateTimePickerTransactionTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionTo.Name = "dateTimePickerTransactionTo";
            this.dateTimePickerTransactionTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionTo.TabIndex = 41;
            // 
            // lblTransactionTo
            // 
            this.lblTransactionTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionTo.Location = new System.Drawing.Point(314, 81);
            this.lblTransactionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionTo.Name = "lblTransactionTo";
            this.lblTransactionTo.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionTo.TabIndex = 40;
            this.lblTransactionTo.Tag = "";
            this.lblTransactionTo.Text = "To:";
            // 
            // dateTimePickerTransactionFrom
            // 
            this.dateTimePickerTransactionFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionFrom.Location = new System.Drawing.Point(133, 76);
            this.dateTimePickerTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionFrom.Name = "dateTimePickerTransactionFrom";
            this.dateTimePickerTransactionFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionFrom.TabIndex = 39;
            // 
            // lblTransactionFrom
            // 
            this.lblTransactionFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFrom.Location = new System.Drawing.Point(69, 81);
            this.lblTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFrom.Name = "lblTransactionFrom";
            this.lblTransactionFrom.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionFrom.TabIndex = 38;
            this.lblTransactionFrom.Text = "From:";
            // 
            // lblTransactionFilteredBy
            // 
            this.lblTransactionFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTransactionFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFilteredBy.Location = new System.Drawing.Point(38, 47);
            this.lblTransactionFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredBy.Name = "lblTransactionFilteredBy";
            this.lblTransactionFilteredBy.Size = new System.Drawing.Size(119, 22);
            this.lblTransactionFilteredBy.TabIndex = 37;
            this.lblTransactionFilteredBy.Text = "Filtered By";
            this.lblTransactionFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionFilteredByPanel
            // 
            this.lblTransactionFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionFilteredByPanel.Location = new System.Drawing.Point(20, 60);
            this.lblTransactionFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredByPanel.Name = "lblTransactionFilteredByPanel";
            this.lblTransactionFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblTransactionFilteredByPanel.TabIndex = 36;
            // 
            // lblTransactionSearchPanel
            // 
            this.lblTransactionSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionSearchPanel.Location = new System.Drawing.Point(535, 60);
            this.lblTransactionSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionSearchPanel.Name = "lblTransactionSearchPanel";
            this.lblTransactionSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblTransactionSearchPanel.TabIndex = 32;
            // 
            // ManagerReportsTopPanel
            // 
            this.ManagerReportsTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerReportsTopPanel.Controls.Add(this.lblMReportsTopTitle);
            this.ManagerReportsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerReportsTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerReportsTopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ManagerReportsTopPanel.Name = "ManagerReportsTopPanel";
            this.ManagerReportsTopPanel.Size = new System.Drawing.Size(1140, 35);
            this.ManagerReportsTopPanel.TabIndex = 45;
            // 
            // lblMReportsTopTitle
            // 
            this.lblMReportsTopTitle.AutoSize = true;
            this.lblMReportsTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMReportsTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMReportsTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMReportsTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMReportsTopTitle.Name = "lblMReportsTopTitle";
            this.lblMReportsTopTitle.Size = new System.Drawing.Size(286, 39);
            this.lblMReportsTopTitle.TabIndex = 1;
            this.lblMReportsTopTitle.Text = "Transaction Reports";
            // 
            // SR_TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1140, 758);
            this.ControlBox = false;
            this.Controls.Add(this.ManagerReportsTopPanel);
            this.Controls.Add(this.txtBoxTransactionSearch);
            this.Controls.Add(this.lblTransactionSearch);
            this.Controls.Add(this.btnTransactionLoad);
            this.Controls.Add(this.btnTransactionDelete);
            this.Controls.Add(this.dtgTransactionRep);
            this.Controls.Add(this.dateTimePickerTransactionTo);
            this.Controls.Add(this.lblTransactionTo);
            this.Controls.Add(this.dateTimePickerTransactionFrom);
            this.Controls.Add(this.lblTransactionFrom);
            this.Controls.Add(this.lblTransactionFilteredBy);
            this.Controls.Add(this.lblTransactionFilteredByPanel);
            this.Controls.Add(this.lblTransactionSearchPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SR_TransactionReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SR_TransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransactionRep)).EndInit();
            this.ManagerReportsTopPanel.ResumeLayout(false);
            this.ManagerReportsTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTransactionSearch;
        private System.Windows.Forms.Label lblTransactionSearch;
        private System.Windows.Forms.Button btnTransactionLoad;
        private System.Windows.Forms.Button btnTransactionDelete;
        private System.Windows.Forms.DataGridView dtgTransactionRep;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionTo;
        private System.Windows.Forms.Label lblTransactionTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFilteredBy;
        private System.Windows.Forms.Label lblTransactionFilteredByPanel;
        private System.Windows.Forms.Label lblTransactionSearchPanel;
        private System.Windows.Forms.Panel ManagerReportsTopPanel;
        private System.Windows.Forms.Label lblMReportsTopTitle;
    }
}