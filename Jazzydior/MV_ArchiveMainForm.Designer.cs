
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagerArchiveTopPanel = new System.Windows.Forms.Panel();
            this.lblMArchiveTopTitle = new System.Windows.Forms.Label();
            this.btnArchiveServiceRestore = new System.Windows.Forms.Button();
            this.btnArchiveServiceDelete = new System.Windows.Forms.Button();
            this.dateTimePickerArchiveServiceTo = new System.Windows.Forms.DateTimePicker();
            this.txtBoxArchiveServiceSearch = new System.Windows.Forms.TextBox();
            this.lblArchiveServiceTo = new System.Windows.Forms.Label();
            this.lblArchiveServiceSearchPanel = new System.Windows.Forms.Label();
            this.dateTimePickerArchiveServiceFrom = new System.Windows.Forms.DateTimePicker();
            this.lblArchiveServiceSearch = new System.Windows.Forms.Label();
            this.lblArchiveServiceFrom = new System.Windows.Forms.Label();
            this.btnArchiveServiceLoad = new System.Windows.Forms.Button();
            this.lblArchiveServiceFilteredBy = new System.Windows.Forms.Label();
            this.lblArchiveServiceFilteredByPanel = new System.Windows.Forms.Label();
            this.dtgArchiveServices = new System.Windows.Forms.DataGridView();
            this.dtgArchiveStaffs = new System.Windows.Forms.DataGridView();
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ManagerArchiveTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveStaffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btnArchiveServiceRestore
            // 
            this.btnArchiveServiceRestore.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceRestore.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceRestore.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceRestore.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceRestore.Location = new System.Drawing.Point(696, 123);
            this.btnArchiveServiceRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceRestore.Name = "btnArchiveServiceRestore";
            this.btnArchiveServiceRestore.Size = new System.Drawing.Size(154, 25);
            this.btnArchiveServiceRestore.TabIndex = 63;
            this.btnArchiveServiceRestore.Text = "Restore";
            this.btnArchiveServiceRestore.UseVisualStyleBackColor = false;
            this.btnArchiveServiceRestore.Click += new System.EventHandler(this.btnArchiveServiceRestore_Click);
            // 
            // btnArchiveServiceDelete
            // 
            this.btnArchiveServiceDelete.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceDelete.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceDelete.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceDelete.Location = new System.Drawing.Point(854, 122);
            this.btnArchiveServiceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceDelete.Name = "btnArchiveServiceDelete";
            this.btnArchiveServiceDelete.Size = new System.Drawing.Size(207, 25);
            this.btnArchiveServiceDelete.TabIndex = 62;
            this.btnArchiveServiceDelete.Text = "Delete Permanently";
            this.btnArchiveServiceDelete.UseVisualStyleBackColor = false;
            this.btnArchiveServiceDelete.Click += new System.EventHandler(this.btnArchiveServiceDelete_Click);
            // 
            // dateTimePickerArchiveServiceTo
            // 
            this.dateTimePickerArchiveServiceTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceTo.Location = new System.Drawing.Point(367, 70);
            this.dateTimePickerArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceTo.Name = "dateTimePickerArchiveServiceTo";
            this.dateTimePickerArchiveServiceTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceTo.TabIndex = 61;
            // 
            // txtBoxArchiveServiceSearch
            // 
            this.txtBoxArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArchiveServiceSearch.Location = new System.Drawing.Point(589, 67);
            this.txtBoxArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxArchiveServiceSearch.Multiline = true;
            this.txtBoxArchiveServiceSearch.Name = "txtBoxArchiveServiceSearch";
            this.txtBoxArchiveServiceSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxArchiveServiceSearch.TabIndex = 54;
            // 
            // lblArchiveServiceTo
            // 
            this.lblArchiveServiceTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceTo.Location = new System.Drawing.Point(326, 75);
            this.lblArchiveServiceTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceTo.Name = "lblArchiveServiceTo";
            this.lblArchiveServiceTo.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceTo.TabIndex = 60;
            this.lblArchiveServiceTo.Tag = "";
            this.lblArchiveServiceTo.Text = "To:";
            // 
            // lblArchiveServiceSearchPanel
            // 
            this.lblArchiveServiceSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArchiveServiceSearchPanel.Location = new System.Drawing.Point(547, 54);
            this.lblArchiveServiceSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearchPanel.Name = "lblArchiveServiceSearchPanel";
            this.lblArchiveServiceSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblArchiveServiceSearchPanel.TabIndex = 52;
            // 
            // dateTimePickerArchiveServiceFrom
            // 
            this.dateTimePickerArchiveServiceFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerArchiveServiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArchiveServiceFrom.Location = new System.Drawing.Point(145, 70);
            this.dateTimePickerArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerArchiveServiceFrom.Name = "dateTimePickerArchiveServiceFrom";
            this.dateTimePickerArchiveServiceFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerArchiveServiceFrom.TabIndex = 59;
            // 
            // lblArchiveServiceSearch
            // 
            this.lblArchiveServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceSearch.Location = new System.Drawing.Point(558, 35);
            this.lblArchiveServiceSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceSearch.Name = "lblArchiveServiceSearch";
            this.lblArchiveServiceSearch.Size = new System.Drawing.Size(119, 33);
            this.lblArchiveServiceSearch.TabIndex = 53;
            this.lblArchiveServiceSearch.Text = "Search Here";
            this.lblArchiveServiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveServiceFrom
            // 
            this.lblArchiveServiceFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchiveServiceFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFrom.Location = new System.Drawing.Point(81, 75);
            this.lblArchiveServiceFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFrom.Name = "lblArchiveServiceFrom";
            this.lblArchiveServiceFrom.Size = new System.Drawing.Size(113, 26);
            this.lblArchiveServiceFrom.TabIndex = 58;
            this.lblArchiveServiceFrom.Text = "From:";
            // 
            // btnArchiveServiceLoad
            // 
            this.btnArchiveServiceLoad.BackColor = System.Drawing.Color.Pink;
            this.btnArchiveServiceLoad.FlatAppearance.BorderSize = 0;
            this.btnArchiveServiceLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveServiceLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveServiceLoad.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveServiceLoad.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnArchiveServiceLoad.Location = new System.Drawing.Point(888, 68);
            this.btnArchiveServiceLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveServiceLoad.Name = "btnArchiveServiceLoad";
            this.btnArchiveServiceLoad.Size = new System.Drawing.Size(80, 29);
            this.btnArchiveServiceLoad.TabIndex = 55;
            this.btnArchiveServiceLoad.Text = "LOAD";
            this.btnArchiveServiceLoad.UseVisualStyleBackColor = false;
            // 
            // lblArchiveServiceFilteredBy
            // 
            this.lblArchiveServiceFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArchiveServiceFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblArchiveServiceFilteredBy.Location = new System.Drawing.Point(50, 34);
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
            this.lblArchiveServiceFilteredByPanel.Location = new System.Drawing.Point(32, 54);
            this.lblArchiveServiceFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchiveServiceFilteredByPanel.Name = "lblArchiveServiceFilteredByPanel";
            this.lblArchiveServiceFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblArchiveServiceFilteredByPanel.TabIndex = 56;
            // 
            // dtgArchiveServices
            // 
            this.dtgArchiveServices.AllowUserToAddRows = false;
            this.dtgArchiveServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArchiveServices.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgArchiveServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgArchiveServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgArchiveServices.ColumnHeadersHeight = 50;
            this.dtgArchiveServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgArchiveServices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgArchiveServices.EnableHeadersVisualStyles = false;
            this.dtgArchiveServices.Location = new System.Drawing.Point(10, 195);
            this.dtgArchiveServices.Margin = new System.Windows.Forms.Padding(4);
            this.dtgArchiveServices.Name = "dtgArchiveServices";
            this.dtgArchiveServices.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgArchiveServices.RowHeadersWidth = 30;
            this.dtgArchiveServices.RowTemplate.Height = 24;
            this.dtgArchiveServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArchiveServices.Size = new System.Drawing.Size(1118, 234);
            this.dtgArchiveServices.TabIndex = 64;
            this.dtgArchiveServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArchiveServices_CellClick);
            // 
            // dtgArchiveStaffs
            // 
            this.dtgArchiveStaffs.AllowUserToAddRows = false;
            this.dtgArchiveStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArchiveStaffs.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgArchiveStaffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgArchiveStaffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgArchiveStaffs.ColumnHeadersHeight = 50;
            this.dtgArchiveStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgArchiveStaffs.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgArchiveStaffs.EnableHeadersVisualStyles = false;
            this.dtgArchiveStaffs.Location = new System.Drawing.Point(10, 476);
            this.dtgArchiveStaffs.Margin = new System.Windows.Forms.Padding(4);
            this.dtgArchiveStaffs.Name = "dtgArchiveStaffs";
            this.dtgArchiveStaffs.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgArchiveStaffs.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgArchiveStaffs.RowHeadersWidth = 30;
            this.dtgArchiveStaffs.RowTemplate.Height = 24;
            this.dtgArchiveStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArchiveStaffs.Size = new System.Drawing.Size(1118, 268);
            this.dtgArchiveStaffs.TabIndex = 65;
            this.dtgArchiveStaffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArchiveStaffs_CellClick);
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.AutoSize = true;
            this.lblAddStaff.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddStaff.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStaff.ForeColor = System.Drawing.Color.MistyRose;
            this.lblAddStaff.Location = new System.Drawing.Point(15, 165);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(115, 28);
            this.lblAddStaff.TabIndex = 110;
            this.lblAddStaff.Text = "Service List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1145, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(15, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 112;
            this.label1.Text = "Staff List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // MV_ArchiveMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddStaff);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtgArchiveStaffs);
            this.Controls.Add(this.dtgArchiveServices);
            this.Controls.Add(this.lblArchiveServiceSearch);
            this.Controls.Add(this.btnArchiveServiceRestore);
            this.Controls.Add(this.btnArchiveServiceDelete);
            this.Controls.Add(this.dateTimePickerArchiveServiceTo);
            this.Controls.Add(this.txtBoxArchiveServiceSearch);
            this.Controls.Add(this.lblArchiveServiceTo);
            this.Controls.Add(this.lblArchiveServiceSearchPanel);
            this.Controls.Add(this.dateTimePickerArchiveServiceFrom);
            this.Controls.Add(this.lblArchiveServiceFrom);
            this.Controls.Add(this.btnArchiveServiceLoad);
            this.Controls.Add(this.lblArchiveServiceFilteredBy);
            this.Controls.Add(this.lblArchiveServiceFilteredByPanel);
            this.Controls.Add(this.ManagerArchiveTopPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MV_ArchiveMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MV_Archive_Load);
            this.ManagerArchiveTopPanel.ResumeLayout(false);
            this.ManagerArchiveTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchiveStaffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManagerArchiveTopPanel;
        private System.Windows.Forms.Label lblMArchiveTopTitle;
        private System.Windows.Forms.Button btnArchiveServiceRestore;
        private System.Windows.Forms.Button btnArchiveServiceDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveServiceTo;
        private System.Windows.Forms.TextBox txtBoxArchiveServiceSearch;
        private System.Windows.Forms.Label lblArchiveServiceTo;
        private System.Windows.Forms.Label lblArchiveServiceSearchPanel;
        private System.Windows.Forms.DateTimePicker dateTimePickerArchiveServiceFrom;
        private System.Windows.Forms.Label lblArchiveServiceSearch;
        private System.Windows.Forms.Label lblArchiveServiceFrom;
        private System.Windows.Forms.Button btnArchiveServiceLoad;
        private System.Windows.Forms.Label lblArchiveServiceFilteredBy;
        private System.Windows.Forms.Label lblArchiveServiceFilteredByPanel;
        private System.Windows.Forms.DataGridView dtgArchiveServices;
        private System.Windows.Forms.DataGridView dtgArchiveStaffs;
        private System.Windows.Forms.Label lblAddStaff;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}