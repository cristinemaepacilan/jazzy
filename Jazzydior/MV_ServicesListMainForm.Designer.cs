
namespace Jazzydior
{
    partial class MV_ServicesListMainForm
    {
        private const string V = "MV_ServicesList";

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
            this.lblMServicesTopTitle = new System.Windows.Forms.Label();
            this.ManagerServicesTopPanel = new System.Windows.Forms.Panel();
            this.dtgServices = new System.Windows.Forms.DataGridView();
            this.btnServicesAdd = new System.Windows.Forms.Button();
            this.btnServiceCategory = new System.Windows.Forms.Button();
            this.btnServicePackageList = new System.Windows.Forms.Button();
            this.lblServiceSearch = new System.Windows.Forms.Label();
            this.ServiceFormPanel = new System.Windows.Forms.Panel();
            this.cmbServiceCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxServID = new System.Windows.Forms.TextBox();
            this.btnServiceCancel = new System.Windows.Forms.Button();
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.btnServiceUpdate = new System.Windows.Forms.Button();
            this.txtBoxAddServicePrice = new System.Windows.Forms.TextBox();
            this.txtBoxAddServiceLeadTime = new System.Windows.Forms.TextBox();
            this.txtBoxAddServicesName = new System.Windows.Forms.TextBox();
            this.lblAddServicePrice = new System.Windows.Forms.Label();
            this.lblAddServiceName = new System.Windows.Forms.Label();
            this.lblAddServiceLeadTime = new System.Windows.Forms.Label();
            this.lblAddServiceCategory = new System.Windows.Forms.Label();
            this.lblServiceForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSearchServices = new System.Windows.Forms.TextBox();
            this.ManagerServicesTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServices)).BeginInit();
            this.ServiceFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMServicesTopTitle
            // 
            this.lblMServicesTopTitle.AutoSize = true;
            this.lblMServicesTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMServicesTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMServicesTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMServicesTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMServicesTopTitle.Name = "lblMServicesTopTitle";
            this.lblMServicesTopTitle.Size = new System.Drawing.Size(178, 39);
            this.lblMServicesTopTitle.TabIndex = 0;
            this.lblMServicesTopTitle.Text = "Services List";
            // 
            // ManagerServicesTopPanel
            // 
            this.ManagerServicesTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerServicesTopPanel.Controls.Add(this.lblMServicesTopTitle);
            this.ManagerServicesTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerServicesTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerServicesTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerServicesTopPanel.Name = "ManagerServicesTopPanel";
            this.ManagerServicesTopPanel.Size = new System.Drawing.Size(1145, 35);
            this.ManagerServicesTopPanel.TabIndex = 1;
            // 
            // dtgServices
            // 
            this.dtgServices.AllowUserToAddRows = false;
            this.dtgServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgServices.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServices.ColumnHeadersHeight = 50;
            this.dtgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgServices.EnableHeadersVisualStyles = false;
            this.dtgServices.Location = new System.Drawing.Point(360, 104);
            this.dtgServices.Margin = new System.Windows.Forms.Padding(4);
            this.dtgServices.Name = "dtgServices";
            this.dtgServices.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgServices.RowHeadersWidth = 30;
            this.dtgServices.RowTemplate.Height = 24;
            this.dtgServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgServices.Size = new System.Drawing.Size(777, 637);
            this.dtgServices.TabIndex = 2;
            this.dtgServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgServices_CellClick);
            // 
            // btnServicesAdd
            // 
            this.btnServicesAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnServicesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnServicesAdd.FlatAppearance.BorderSize = 0;
            this.btnServicesAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnServicesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesAdd.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnServicesAdd.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServicesAdd.Location = new System.Drawing.Point(358, 44);
            this.btnServicesAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnServicesAdd.Name = "btnServicesAdd";
            this.btnServicesAdd.Size = new System.Drawing.Size(225, 45);
            this.btnServicesAdd.TabIndex = 10;
            this.btnServicesAdd.Text = "Add New Service Details";
            this.btnServicesAdd.UseVisualStyleBackColor = false;
            this.btnServicesAdd.Click += new System.EventHandler(this.btnServicesAdd_Click);
            // 
            // btnServiceCategory
            // 
            this.btnServiceCategory.BackColor = System.Drawing.Color.MistyRose;
            this.btnServiceCategory.FlatAppearance.BorderSize = 0;
            this.btnServiceCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnServiceCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceCategory.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceCategory.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServiceCategory.Location = new System.Drawing.Point(181, 44);
            this.btnServiceCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnServiceCategory.Name = "btnServiceCategory";
            this.btnServiceCategory.Size = new System.Drawing.Size(157, 45);
            this.btnServiceCategory.TabIndex = 2;
            this.btnServiceCategory.Text = "Category List";
            this.btnServiceCategory.UseVisualStyleBackColor = false;
            this.btnServiceCategory.Click += new System.EventHandler(this.btnServiceCategory_Click);
            // 
            // btnServicePackageList
            // 
            this.btnServicePackageList.BackColor = System.Drawing.Color.MistyRose;
            this.btnServicePackageList.FlatAppearance.BorderSize = 0;
            this.btnServicePackageList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnServicePackageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicePackageList.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicePackageList.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServicePackageList.Location = new System.Drawing.Point(4, 44);
            this.btnServicePackageList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnServicePackageList.Name = "btnServicePackageList";
            this.btnServicePackageList.Size = new System.Drawing.Size(157, 45);
            this.btnServicePackageList.TabIndex = 1;
            this.btnServicePackageList.Text = "Package List";
            this.btnServicePackageList.UseVisualStyleBackColor = false;
            this.btnServicePackageList.Click += new System.EventHandler(this.btnServicePackageList_Click);
            // 
            // lblServiceSearch
            // 
            this.lblServiceSearch.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblServiceSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblServiceSearch.Location = new System.Drawing.Point(750, 53);
            this.lblServiceSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceSearch.Name = "lblServiceSearch";
            this.lblServiceSearch.Size = new System.Drawing.Size(94, 33);
            this.lblServiceSearch.TabIndex = 0;
            this.lblServiceSearch.Text = "Search :";
            this.lblServiceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceFormPanel
            // 
            this.ServiceFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServiceFormPanel.Controls.Add(this.cmbServiceCategory);
            this.ServiceFormPanel.Controls.Add(this.txtBoxServID);
            this.ServiceFormPanel.Controls.Add(this.btnServiceCancel);
            this.ServiceFormPanel.Controls.Add(this.btnServiceDelete);
            this.ServiceFormPanel.Controls.Add(this.btnServiceUpdate);
            this.ServiceFormPanel.Controls.Add(this.txtBoxAddServicePrice);
            this.ServiceFormPanel.Controls.Add(this.txtBoxAddServiceLeadTime);
            this.ServiceFormPanel.Controls.Add(this.txtBoxAddServicesName);
            this.ServiceFormPanel.Controls.Add(this.lblAddServicePrice);
            this.ServiceFormPanel.Controls.Add(this.lblAddServiceName);
            this.ServiceFormPanel.Controls.Add(this.lblAddServiceLeadTime);
            this.ServiceFormPanel.Controls.Add(this.lblAddServiceCategory);
            this.ServiceFormPanel.Location = new System.Drawing.Point(11, 178);
            this.ServiceFormPanel.Name = "ServiceFormPanel";
            this.ServiceFormPanel.Size = new System.Drawing.Size(330, 429);
            this.ServiceFormPanel.TabIndex = 0;
            // 
            // cmbServiceCategory
            // 
            this.cmbServiceCategory.BackColor = System.Drawing.Color.Ivory;
            this.cmbServiceCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceCategory.Enabled = false;
            this.cmbServiceCategory.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.cmbServiceCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbServiceCategory.FormattingEnabled = true;
            this.cmbServiceCategory.Location = new System.Drawing.Point(42, 146);
            this.cmbServiceCategory.Name = "cmbServiceCategory";
            this.cmbServiceCategory.Size = new System.Drawing.Size(241, 34);
            this.cmbServiceCategory.TabIndex = 64;
            // 
            // txtBoxServID
            // 
            this.txtBoxServID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxServID.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxServID.Enabled = false;
            this.txtBoxServID.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxServID.ForeColor = System.Drawing.Color.Black;
            this.txtBoxServID.Location = new System.Drawing.Point(42, 28);
            this.txtBoxServID.Multiline = true;
            this.txtBoxServID.Name = "txtBoxServID";
            this.txtBoxServID.Size = new System.Drawing.Size(241, 30);
            this.txtBoxServID.TabIndex = 10;
            this.txtBoxServID.Visible = false;
            // 
            // btnServiceCancel
            // 
            this.btnServiceCancel.BackColor = System.Drawing.Color.Pink;
            this.btnServiceCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnServiceCancel.FlatAppearance.BorderSize = 0;
            this.btnServiceCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServiceCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceCancel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceCancel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServiceCancel.Location = new System.Drawing.Point(214, 361);
            this.btnServiceCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceCancel.Name = "btnServiceCancel";
            this.btnServiceCancel.Size = new System.Drawing.Size(88, 32);
            this.btnServiceCancel.TabIndex = 9;
            this.btnServiceCancel.Text = "Cancel";
            this.btnServiceCancel.UseVisualStyleBackColor = false;
            this.btnServiceCancel.Click += new System.EventHandler(this.btnServiceCancel_Click);
            // 
            // btnServiceDelete
            // 
            this.btnServiceDelete.BackColor = System.Drawing.Color.Pink;
            this.btnServiceDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnServiceDelete.FlatAppearance.BorderSize = 0;
            this.btnServiceDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceDelete.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServiceDelete.Location = new System.Drawing.Point(119, 361);
            this.btnServiceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(88, 32);
            this.btnServiceDelete.TabIndex = 8;
            this.btnServiceDelete.Text = "Delete";
            this.btnServiceDelete.UseVisualStyleBackColor = false;
            this.btnServiceDelete.Click += new System.EventHandler(this.btnServiceDelete_Click);
            // 
            // btnServiceUpdate
            // 
            this.btnServiceUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnServiceUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnServiceUpdate.FlatAppearance.BorderSize = 0;
            this.btnServiceUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServiceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceUpdate.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceUpdate.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnServiceUpdate.Location = new System.Drawing.Point(24, 361);
            this.btnServiceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceUpdate.Name = "btnServiceUpdate";
            this.btnServiceUpdate.Size = new System.Drawing.Size(88, 32);
            this.btnServiceUpdate.TabIndex = 7;
            this.btnServiceUpdate.Text = "Edit";
            this.btnServiceUpdate.UseVisualStyleBackColor = false;
            this.btnServiceUpdate.Click += new System.EventHandler(this.btnServiceUpdate_Click);
            // 
            // txtBoxAddServicePrice
            // 
            this.txtBoxAddServicePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAddServicePrice.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxAddServicePrice.Enabled = false;
            this.txtBoxAddServicePrice.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxAddServicePrice.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAddServicePrice.Location = new System.Drawing.Point(42, 270);
            this.txtBoxAddServicePrice.Multiline = true;
            this.txtBoxAddServicePrice.Name = "txtBoxAddServicePrice";
            this.txtBoxAddServicePrice.Size = new System.Drawing.Size(241, 30);
            this.txtBoxAddServicePrice.TabIndex = 6;
            this.txtBoxAddServicePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAddServicePrice_KeyPress);
            // 
            // txtBoxAddServiceLeadTime
            // 
            this.txtBoxAddServiceLeadTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAddServiceLeadTime.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxAddServiceLeadTime.Enabled = false;
            this.txtBoxAddServiceLeadTime.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxAddServiceLeadTime.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAddServiceLeadTime.Location = new System.Drawing.Point(42, 208);
            this.txtBoxAddServiceLeadTime.Multiline = true;
            this.txtBoxAddServiceLeadTime.Name = "txtBoxAddServiceLeadTime";
            this.txtBoxAddServiceLeadTime.Size = new System.Drawing.Size(241, 30);
            this.txtBoxAddServiceLeadTime.TabIndex = 5;
            // 
            // txtBoxAddServicesName
            // 
            this.txtBoxAddServicesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAddServicesName.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxAddServicesName.Enabled = false;
            this.txtBoxAddServicesName.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxAddServicesName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAddServicesName.Location = new System.Drawing.Point(42, 79);
            this.txtBoxAddServicesName.Multiline = true;
            this.txtBoxAddServicesName.Name = "txtBoxAddServicesName";
            this.txtBoxAddServicesName.Size = new System.Drawing.Size(241, 30);
            this.txtBoxAddServicesName.TabIndex = 3;
            // 
            // lblAddServicePrice
            // 
            this.lblAddServicePrice.AutoSize = true;
            this.lblAddServicePrice.BackColor = System.Drawing.Color.MistyRose;
            this.lblAddServicePrice.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddServicePrice.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddServicePrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddServicePrice.Location = new System.Drawing.Point(38, 251);
            this.lblAddServicePrice.Name = "lblAddServicePrice";
            this.lblAddServicePrice.Size = new System.Drawing.Size(69, 20);
            this.lblAddServicePrice.TabIndex = 0;
            this.lblAddServicePrice.Text = "Price :";
            // 
            // lblAddServiceName
            // 
            this.lblAddServiceName.AutoSize = true;
            this.lblAddServiceName.BackColor = System.Drawing.Color.MistyRose;
            this.lblAddServiceName.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddServiceName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddServiceName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddServiceName.Location = new System.Drawing.Point(38, 61);
            this.lblAddServiceName.Name = "lblAddServiceName";
            this.lblAddServiceName.Size = new System.Drawing.Size(74, 20);
            this.lblAddServiceName.TabIndex = 0;
            this.lblAddServiceName.Text = "Name :";
            // 
            // lblAddServiceLeadTime
            // 
            this.lblAddServiceLeadTime.AutoSize = true;
            this.lblAddServiceLeadTime.BackColor = System.Drawing.Color.MistyRose;
            this.lblAddServiceLeadTime.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddServiceLeadTime.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddServiceLeadTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddServiceLeadTime.Location = new System.Drawing.Point(39, 190);
            this.lblAddServiceLeadTime.Name = "lblAddServiceLeadTime";
            this.lblAddServiceLeadTime.Size = new System.Drawing.Size(119, 20);
            this.lblAddServiceLeadTime.TabIndex = 0;
            this.lblAddServiceLeadTime.Text = "Lead Time :";
            // 
            // lblAddServiceCategory
            // 
            this.lblAddServiceCategory.AutoSize = true;
            this.lblAddServiceCategory.BackColor = System.Drawing.Color.MistyRose;
            this.lblAddServiceCategory.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddServiceCategory.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddServiceCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddServiceCategory.Location = new System.Drawing.Point(38, 123);
            this.lblAddServiceCategory.Name = "lblAddServiceCategory";
            this.lblAddServiceCategory.Size = new System.Drawing.Size(106, 20);
            this.lblAddServiceCategory.TabIndex = 0;
            this.lblAddServiceCategory.Text = "Category :";
            // 
            // lblServiceForm
            // 
            this.lblServiceForm.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblServiceForm.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblServiceForm.Location = new System.Drawing.Point(89, 167);
            this.lblServiceForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceForm.Name = "lblServiceForm";
            this.lblServiceForm.Size = new System.Drawing.Size(158, 22);
            this.lblServiceForm.TabIndex = 0;
            this.lblServiceForm.Text = "Service Details";
            this.lblServiceForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(161, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "l";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(338, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "l";
            // 
            // txtBoxSearchServices
            // 
            this.txtBoxSearchServices.Location = new System.Drawing.Point(841, 52);
            this.txtBoxSearchServices.Name = "txtBoxSearchServices";
            this.txtBoxSearchServices.Size = new System.Drawing.Size(296, 33);
            this.txtBoxSearchServices.TabIndex = 55;
            this.txtBoxSearchServices.TextChanged += new System.EventHandler(this.SearchServiceRecord);
            // 
            // MV_ServicesListMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxSearchServices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServiceForm);
            this.Controls.Add(this.lblServiceSearch);
            this.Controls.Add(this.btnServicePackageList);
            this.Controls.Add(this.btnServiceCategory);
            this.Controls.Add(this.btnServicesAdd);
            this.Controls.Add(this.dtgServices);
            this.Controls.Add(this.ManagerServicesTopPanel);
            this.Controls.Add(this.ServiceFormPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MV_ServicesListMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MV_ServicesList_Load);
            this.ManagerServicesTopPanel.ResumeLayout(false);
            this.ManagerServicesTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServices)).EndInit();
            this.ServiceFormPanel.ResumeLayout(false);
            this.ServiceFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMServicesTopTitle;
        private System.Windows.Forms.Panel ManagerServicesTopPanel;
        private System.Windows.Forms.Button btnServicesAdd;
        private System.Windows.Forms.Button btnServiceCategory;
        private System.Windows.Forms.Button btnServicePackageList;
        private System.Windows.Forms.Label lblServiceSearch;
        public System.Windows.Forms.DataGridView dtgServices;
        private System.Windows.Forms.Panel ServiceFormPanel;
        private System.Windows.Forms.Label lblServiceForm;
        private System.Windows.Forms.Label lblAddServicePrice;
        private System.Windows.Forms.Label lblAddServiceName;
        private System.Windows.Forms.Label lblAddServiceLeadTime;
        private System.Windows.Forms.Label lblAddServiceCategory;
        private System.Windows.Forms.TextBox txtBoxAddServicePrice;
        private System.Windows.Forms.TextBox txtBoxAddServiceLeadTime;
        private System.Windows.Forms.TextBox txtBoxAddServicesName;
        private System.Windows.Forms.Button btnServiceCancel;
        private System.Windows.Forms.Button btnServiceDelete;
        private System.Windows.Forms.Button btnServiceUpdate;
        private System.Windows.Forms.TextBox txtBoxServID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServiceCategory;
        private System.Windows.Forms.TextBox txtBoxSearchServices;
    }
}