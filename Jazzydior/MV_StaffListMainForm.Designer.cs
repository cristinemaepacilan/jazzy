
namespace Jazzydior
{
    partial class MV_StaffListMainForm
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
            this.ManagerStaffsTopPanel = new System.Windows.Forms.Panel();
            this.lblMStaffsTopTitle = new System.Windows.Forms.Label();
            this.dtgStaffs = new System.Windows.Forms.DataGridView();
            this.lblStaffsSearch = new System.Windows.Forms.Label();
            this.txtBoxStaffsSearch = new System.Windows.Forms.TextBox();
            this.lblStaffForm = new System.Windows.Forms.Label();
            this.StaffsFormPanel = new System.Windows.Forms.Panel();
            this.rbStaffUnemployed = new System.Windows.Forms.RadioButton();
            this.rbStatusEmployed = new System.Windows.Forms.RadioButton();
            this.rbStaffsMale = new System.Windows.Forms.RadioButton();
            this.rbStaffsFemale = new System.Windows.Forms.RadioButton();
            this.lblStaffsSex = new System.Windows.Forms.Label();
            this.txtBoxStaffsID = new System.Windows.Forms.TextBox();
            this.txtBoxStaffsCity = new System.Windows.Forms.TextBox();
            this.lblStaffsCity = new System.Windows.Forms.Label();
            this.cmbCreateAcctPosition = new System.Windows.Forms.ComboBox();
            this.lblStaffsStatus = new System.Windows.Forms.Label();
            this.txtBoxStaffsCountry = new System.Windows.Forms.TextBox();
            this.lblStaffsCountry = new System.Windows.Forms.Label();
            this.txtBoxStaffsProvince = new System.Windows.Forms.TextBox();
            this.lblStaffsFullname = new System.Windows.Forms.Label();
            this.lblStaffsProvince = new System.Windows.Forms.Label();
            this.txtBoxStaffsFirstname = new System.Windows.Forms.TextBox();
            this.lblStaffsFirstname = new System.Windows.Forms.Label();
            this.txtBoxStaffsBrgy = new System.Windows.Forms.TextBox();
            this.lblStaffsBrgy = new System.Windows.Forms.Label();
            this.txtBoxStaffsPurok = new System.Windows.Forms.TextBox();
            this.lblStaffsPurok = new System.Windows.Forms.Label();
            this.txtBoxStaffsHouse = new System.Windows.Forms.TextBox();
            this.lblStaffsHouse = new System.Windows.Forms.Label();
            this.txtBoxStaffsBuilding = new System.Windows.Forms.TextBox();
            this.lblStaffsBuilding = new System.Windows.Forms.Label();
            this.lblStaffsAddress = new System.Windows.Forms.Label();
            this.lblStaffsEmail = new System.Windows.Forms.Label();
            this.txtBoxStaffsStreet = new System.Windows.Forms.TextBox();
            this.txtBoxStaffsEmail = new System.Windows.Forms.TextBox();
            this.lblStaffsStreet = new System.Windows.Forms.Label();
            this.lblStaffsPosition = new System.Windows.Forms.Label();
            this.btnStaffsCancel = new System.Windows.Forms.Button();
            this.btnStaffsDelete = new System.Windows.Forms.Button();
            this.btnStaffsUpdate = new System.Windows.Forms.Button();
            this.txtBoxStaffsContact = new System.Windows.Forms.TextBox();
            this.txtBoxStaffsLastname = new System.Windows.Forms.TextBox();
            this.lblStaffsContact = new System.Windows.Forms.Label();
            this.lblStaffsLastname = new System.Windows.Forms.Label();
            this.btnStaffsAdd = new System.Windows.Forms.Button();
            this.ManagerStaffsTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffs)).BeginInit();
            this.StaffsFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerStaffsTopPanel
            // 
            this.ManagerStaffsTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerStaffsTopPanel.Controls.Add(this.lblMStaffsTopTitle);
            this.ManagerStaffsTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerStaffsTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerStaffsTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerStaffsTopPanel.Name = "ManagerStaffsTopPanel";
            this.ManagerStaffsTopPanel.Size = new System.Drawing.Size(1145, 35);
            this.ManagerStaffsTopPanel.TabIndex = 2;
            // 
            // lblMStaffsTopTitle
            // 
            this.lblMStaffsTopTitle.AutoSize = true;
            this.lblMStaffsTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMStaffsTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMStaffsTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMStaffsTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMStaffsTopTitle.Name = "lblMStaffsTopTitle";
            this.lblMStaffsTopTitle.Size = new System.Drawing.Size(160, 39);
            this.lblMStaffsTopTitle.TabIndex = 1;
            this.lblMStaffsTopTitle.Text = "Staffs List";
            // 
            // dtgStaffs
            // 
            this.dtgStaffs.AllowUserToAddRows = false;
            this.dtgStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgStaffs.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgStaffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgStaffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgStaffs.ColumnHeadersHeight = 50;
            this.dtgStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgStaffs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgStaffs.EnableHeadersVisualStyles = false;
            this.dtgStaffs.Location = new System.Drawing.Point(349, 96);
            this.dtgStaffs.Margin = new System.Windows.Forms.Padding(4);
            this.dtgStaffs.Name = "dtgStaffs";
            this.dtgStaffs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgStaffs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgStaffs.RowHeadersWidth = 30;
            this.dtgStaffs.RowTemplate.Height = 24;
            this.dtgStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStaffs.Size = new System.Drawing.Size(783, 645);
            this.dtgStaffs.TabIndex = 19;
            this.dtgStaffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStaffs_CellClick);
            // 
            // lblStaffsSearch
            // 
            this.lblStaffsSearch.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblStaffsSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsSearch.Location = new System.Drawing.Point(755, 56);
            this.lblStaffsSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffsSearch.Name = "lblStaffsSearch";
            this.lblStaffsSearch.Size = new System.Drawing.Size(94, 33);
            this.lblStaffsSearch.TabIndex = 72;
            this.lblStaffsSearch.Text = "Search :";
            this.lblStaffsSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxStaffsSearch
            // 
            this.txtBoxStaffsSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStaffsSearch.Location = new System.Drawing.Point(842, 58);
            this.txtBoxStaffsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxStaffsSearch.Multiline = true;
            this.txtBoxStaffsSearch.Name = "txtBoxStaffsSearch";
            this.txtBoxStaffsSearch.Size = new System.Drawing.Size(290, 30);
            this.txtBoxStaffsSearch.TabIndex = 73;
            this.txtBoxStaffsSearch.TextChanged += new System.EventHandler(this.SearchStaffRecord);
            // 
            // lblStaffForm
            // 
            this.lblStaffForm.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblStaffForm.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffForm.Location = new System.Drawing.Point(91, 55);
            this.lblStaffForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffForm.Name = "lblStaffForm";
            this.lblStaffForm.Size = new System.Drawing.Size(158, 24);
            this.lblStaffForm.TabIndex = 48;
            this.lblStaffForm.Text = "Staff Details";
            this.lblStaffForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffsFormPanel
            // 
            this.StaffsFormPanel.AutoScroll = true;
            this.StaffsFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffsFormPanel.Controls.Add(this.rbStaffUnemployed);
            this.StaffsFormPanel.Controls.Add(this.rbStatusEmployed);
            this.StaffsFormPanel.Controls.Add(this.rbStaffsMale);
            this.StaffsFormPanel.Controls.Add(this.rbStaffsFemale);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsSex);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsID);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsCity);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsCity);
            this.StaffsFormPanel.Controls.Add(this.cmbCreateAcctPosition);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsStatus);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsCountry);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsCountry);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsProvince);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsFullname);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsProvince);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsFirstname);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsFirstname);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsBrgy);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsBrgy);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsPurok);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsPurok);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsHouse);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsHouse);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsBuilding);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsBuilding);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsAddress);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsEmail);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsStreet);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsEmail);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsStreet);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsPosition);
            this.StaffsFormPanel.Controls.Add(this.btnStaffsCancel);
            this.StaffsFormPanel.Controls.Add(this.btnStaffsDelete);
            this.StaffsFormPanel.Controls.Add(this.btnStaffsUpdate);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsContact);
            this.StaffsFormPanel.Controls.Add(this.txtBoxStaffsLastname);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsContact);
            this.StaffsFormPanel.Controls.Add(this.lblStaffsLastname);
            this.StaffsFormPanel.Location = new System.Drawing.Point(12, 69);
            this.StaffsFormPanel.Name = "StaffsFormPanel";
            this.StaffsFormPanel.Size = new System.Drawing.Size(330, 672);
            this.StaffsFormPanel.TabIndex = 47;
            // 
            // rbStaffUnemployed
            // 
            this.rbStaffUnemployed.AutoSize = true;
            this.rbStaffUnemployed.BackColor = System.Drawing.Color.MistyRose;
            this.rbStaffUnemployed.Enabled = false;
            this.rbStaffUnemployed.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.rbStaffUnemployed.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbStaffUnemployed.Location = new System.Drawing.Point(63, 926);
            this.rbStaffUnemployed.Name = "rbStaffUnemployed";
            this.rbStaffUnemployed.Size = new System.Drawing.Size(145, 24);
            this.rbStaffUnemployed.TabIndex = 114;
            this.rbStaffUnemployed.Text = "Unemployed";
            this.rbStaffUnemployed.UseVisualStyleBackColor = false;
            // 
            // rbStatusEmployed
            // 
            this.rbStatusEmployed.AutoSize = true;
            this.rbStatusEmployed.BackColor = System.Drawing.Color.MistyRose;
            this.rbStatusEmployed.Enabled = false;
            this.rbStatusEmployed.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.rbStatusEmployed.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbStatusEmployed.Location = new System.Drawing.Point(63, 896);
            this.rbStatusEmployed.Name = "rbStatusEmployed";
            this.rbStatusEmployed.Size = new System.Drawing.Size(118, 24);
            this.rbStatusEmployed.TabIndex = 113;
            this.rbStatusEmployed.Text = "Employed";
            this.rbStatusEmployed.UseVisualStyleBackColor = false;
            // 
            // rbStaffsMale
            // 
            this.rbStaffsMale.AutoSize = true;
            this.rbStaffsMale.BackColor = System.Drawing.Color.MistyRose;
            this.rbStaffsMale.Enabled = false;
            this.rbStaffsMale.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.rbStaffsMale.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbStaffsMale.Location = new System.Drawing.Point(79, 168);
            this.rbStaffsMale.Name = "rbStaffsMale";
            this.rbStaffsMale.Size = new System.Drawing.Size(75, 24);
            this.rbStaffsMale.TabIndex = 54;
            this.rbStaffsMale.Text = "Male";
            this.rbStaffsMale.UseVisualStyleBackColor = false;
            // 
            // rbStaffsFemale
            // 
            this.rbStaffsFemale.AutoSize = true;
            this.rbStaffsFemale.BackColor = System.Drawing.Color.MistyRose;
            this.rbStaffsFemale.Enabled = false;
            this.rbStaffsFemale.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.rbStaffsFemale.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbStaffsFemale.Location = new System.Drawing.Point(170, 168);
            this.rbStaffsFemale.Name = "rbStaffsFemale";
            this.rbStaffsFemale.Size = new System.Drawing.Size(97, 24);
            this.rbStaffsFemale.TabIndex = 53;
            this.rbStaffsFemale.Text = "Female";
            this.rbStaffsFemale.UseVisualStyleBackColor = false;
            // 
            // lblStaffsSex
            // 
            this.lblStaffsSex.AutoSize = true;
            this.lblStaffsSex.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsSex.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsSex.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsSex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsSex.Location = new System.Drawing.Point(28, 145);
            this.lblStaffsSex.Name = "lblStaffsSex";
            this.lblStaffsSex.Size = new System.Drawing.Size(51, 20);
            this.lblStaffsSex.TabIndex = 112;
            this.lblStaffsSex.Text = "Sex :";
            // 
            // txtBoxStaffsID
            // 
            this.txtBoxStaffsID.AccessibleName = "";
            this.txtBoxStaffsID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsID.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsID.Enabled = false;
            this.txtBoxStaffsID.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsID.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsID.Location = new System.Drawing.Point(201, 8);
            this.txtBoxStaffsID.Multiline = true;
            this.txtBoxStaffsID.Name = "txtBoxStaffsID";
            this.txtBoxStaffsID.Size = new System.Drawing.Size(54, 30);
            this.txtBoxStaffsID.TabIndex = 50;
            this.txtBoxStaffsID.Visible = false;
            // 
            // txtBoxStaffsCity
            // 
            this.txtBoxStaffsCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsCity.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsCity.Enabled = false;
            this.txtBoxStaffsCity.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsCity.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsCity.Location = new System.Drawing.Point(48, 704);
            this.txtBoxStaffsCity.Multiline = true;
            this.txtBoxStaffsCity.Name = "txtBoxStaffsCity";
            this.txtBoxStaffsCity.Size = new System.Drawing.Size(254, 30);
            this.txtBoxStaffsCity.TabIndex = 63;
            // 
            // lblStaffsCity
            // 
            this.lblStaffsCity.AutoSize = true;
            this.lblStaffsCity.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsCity.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsCity.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsCity.Location = new System.Drawing.Point(44, 684);
            this.lblStaffsCity.Name = "lblStaffsCity";
            this.lblStaffsCity.Size = new System.Drawing.Size(59, 20);
            this.lblStaffsCity.TabIndex = 111;
            this.lblStaffsCity.Text = "City :";
            // 
            // cmbCreateAcctPosition
            // 
            this.cmbCreateAcctPosition.BackColor = System.Drawing.Color.Ivory;
            this.cmbCreateAcctPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreateAcctPosition.Enabled = false;
            this.cmbCreateAcctPosition.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.cmbCreateAcctPosition.ForeColor = System.Drawing.Color.Black;
            this.cmbCreateAcctPosition.FormattingEnabled = true;
            this.cmbCreateAcctPosition.Location = new System.Drawing.Point(43, 221);
            this.cmbCreateAcctPosition.Name = "cmbCreateAcctPosition";
            this.cmbCreateAcctPosition.Size = new System.Drawing.Size(259, 34);
            this.cmbCreateAcctPosition.TabIndex = 55;
            // 
            // lblStaffsStatus
            // 
            this.lblStaffsStatus.AutoSize = true;
            this.lblStaffsStatus.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsStatus.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsStatus.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsStatus.Location = new System.Drawing.Point(26, 869);
            this.lblStaffsStatus.Name = "lblStaffsStatus";
            this.lblStaffsStatus.Size = new System.Drawing.Size(79, 20);
            this.lblStaffsStatus.TabIndex = 109;
            this.lblStaffsStatus.Text = "Status :";
            // 
            // txtBoxStaffsCountry
            // 
            this.txtBoxStaffsCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsCountry.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsCountry.Enabled = false;
            this.txtBoxStaffsCountry.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsCountry.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsCountry.Location = new System.Drawing.Point(48, 821);
            this.txtBoxStaffsCountry.Multiline = true;
            this.txtBoxStaffsCountry.Name = "txtBoxStaffsCountry";
            this.txtBoxStaffsCountry.Size = new System.Drawing.Size(254, 30);
            this.txtBoxStaffsCountry.TabIndex = 65;
            // 
            // lblStaffsCountry
            // 
            this.lblStaffsCountry.AutoSize = true;
            this.lblStaffsCountry.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsCountry.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsCountry.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsCountry.Location = new System.Drawing.Point(47, 801);
            this.lblStaffsCountry.Name = "lblStaffsCountry";
            this.lblStaffsCountry.Size = new System.Drawing.Size(97, 20);
            this.lblStaffsCountry.TabIndex = 104;
            this.lblStaffsCountry.Text = "Country :";
            // 
            // txtBoxStaffsProvince
            // 
            this.txtBoxStaffsProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsProvince.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsProvince.Enabled = false;
            this.txtBoxStaffsProvince.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsProvince.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsProvince.Location = new System.Drawing.Point(49, 760);
            this.txtBoxStaffsProvince.Multiline = true;
            this.txtBoxStaffsProvince.Name = "txtBoxStaffsProvince";
            this.txtBoxStaffsProvince.Size = new System.Drawing.Size(253, 30);
            this.txtBoxStaffsProvince.TabIndex = 64;
            // 
            // lblStaffsFullname
            // 
            this.lblStaffsFullname.AutoSize = true;
            this.lblStaffsFullname.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsFullname.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsFullname.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsFullname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsFullname.Location = new System.Drawing.Point(28, 18);
            this.lblStaffsFullname.Name = "lblStaffsFullname";
            this.lblStaffsFullname.Size = new System.Drawing.Size(111, 20);
            this.lblStaffsFullname.TabIndex = 57;
            this.lblStaffsFullname.Text = "Fullname :";
            // 
            // lblStaffsProvince
            // 
            this.lblStaffsProvince.AutoSize = true;
            this.lblStaffsProvince.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsProvince.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsProvince.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsProvince.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsProvince.Location = new System.Drawing.Point(44, 740);
            this.lblStaffsProvince.Name = "lblStaffsProvince";
            this.lblStaffsProvince.Size = new System.Drawing.Size(102, 20);
            this.lblStaffsProvince.TabIndex = 102;
            this.lblStaffsProvince.Text = "Province :";
            // 
            // txtBoxStaffsFirstname
            // 
            this.txtBoxStaffsFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsFirstname.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsFirstname.Enabled = false;
            this.txtBoxStaffsFirstname.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsFirstname.Location = new System.Drawing.Point(41, 61);
            this.txtBoxStaffsFirstname.Multiline = true;
            this.txtBoxStaffsFirstname.Name = "txtBoxStaffsFirstname";
            this.txtBoxStaffsFirstname.Size = new System.Drawing.Size(261, 30);
            this.txtBoxStaffsFirstname.TabIndex = 51;
            // 
            // lblStaffsFirstname
            // 
            this.lblStaffsFirstname.AutoSize = true;
            this.lblStaffsFirstname.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsFirstname.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsFirstname.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsFirstname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsFirstname.Location = new System.Drawing.Point(43, 43);
            this.lblStaffsFirstname.Name = "lblStaffsFirstname";
            this.lblStaffsFirstname.Size = new System.Drawing.Size(116, 20);
            this.lblStaffsFirstname.TabIndex = 47;
            this.lblStaffsFirstname.Text = "Firstname :";
            // 
            // txtBoxStaffsBrgy
            // 
            this.txtBoxStaffsBrgy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsBrgy.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsBrgy.Enabled = false;
            this.txtBoxStaffsBrgy.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsBrgy.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsBrgy.Location = new System.Drawing.Point(47, 651);
            this.txtBoxStaffsBrgy.Multiline = true;
            this.txtBoxStaffsBrgy.Name = "txtBoxStaffsBrgy";
            this.txtBoxStaffsBrgy.Size = new System.Drawing.Size(255, 30);
            this.txtBoxStaffsBrgy.TabIndex = 62;
            // 
            // lblStaffsBrgy
            // 
            this.lblStaffsBrgy.AutoSize = true;
            this.lblStaffsBrgy.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsBrgy.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsBrgy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsBrgy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsBrgy.Location = new System.Drawing.Point(42, 631);
            this.lblStaffsBrgy.Name = "lblStaffsBrgy";
            this.lblStaffsBrgy.Size = new System.Drawing.Size(116, 20);
            this.lblStaffsBrgy.TabIndex = 100;
            this.lblStaffsBrgy.Text = "Barangay :";
            // 
            // txtBoxStaffsPurok
            // 
            this.txtBoxStaffsPurok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsPurok.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsPurok.Enabled = false;
            this.txtBoxStaffsPurok.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsPurok.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsPurok.Location = new System.Drawing.Point(47, 596);
            this.txtBoxStaffsPurok.Multiline = true;
            this.txtBoxStaffsPurok.Name = "txtBoxStaffsPurok";
            this.txtBoxStaffsPurok.Size = new System.Drawing.Size(255, 30);
            this.txtBoxStaffsPurok.TabIndex = 61;
            // 
            // lblStaffsPurok
            // 
            this.lblStaffsPurok.AutoSize = true;
            this.lblStaffsPurok.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsPurok.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsPurok.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsPurok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsPurok.Location = new System.Drawing.Point(45, 576);
            this.lblStaffsPurok.Name = "lblStaffsPurok";
            this.lblStaffsPurok.Size = new System.Drawing.Size(76, 20);
            this.lblStaffsPurok.TabIndex = 98;
            this.lblStaffsPurok.Text = "Purok :";
            // 
            // txtBoxStaffsHouse
            // 
            this.txtBoxStaffsHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsHouse.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsHouse.Enabled = false;
            this.txtBoxStaffsHouse.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsHouse.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsHouse.Location = new System.Drawing.Point(47, 541);
            this.txtBoxStaffsHouse.Multiline = true;
            this.txtBoxStaffsHouse.Name = "txtBoxStaffsHouse";
            this.txtBoxStaffsHouse.Size = new System.Drawing.Size(255, 30);
            this.txtBoxStaffsHouse.TabIndex = 60;
            this.txtBoxStaffsHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStaffsHouse_KeyPress);
            // 
            // lblStaffsHouse
            // 
            this.lblStaffsHouse.AutoSize = true;
            this.lblStaffsHouse.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsHouse.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsHouse.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsHouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsHouse.Location = new System.Drawing.Point(43, 522);
            this.lblStaffsHouse.Name = "lblStaffsHouse";
            this.lblStaffsHouse.Size = new System.Drawing.Size(106, 20);
            this.lblStaffsHouse.TabIndex = 96;
            this.lblStaffsHouse.Text = "House No :";
            // 
            // txtBoxStaffsBuilding
            // 
            this.txtBoxStaffsBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsBuilding.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsBuilding.Enabled = false;
            this.txtBoxStaffsBuilding.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsBuilding.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsBuilding.Location = new System.Drawing.Point(47, 486);
            this.txtBoxStaffsBuilding.Multiline = true;
            this.txtBoxStaffsBuilding.Name = "txtBoxStaffsBuilding";
            this.txtBoxStaffsBuilding.Size = new System.Drawing.Size(255, 30);
            this.txtBoxStaffsBuilding.TabIndex = 59;
            this.txtBoxStaffsBuilding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStaffsBuilding_KeyPress);
            // 
            // lblStaffsBuilding
            // 
            this.lblStaffsBuilding.AutoSize = true;
            this.lblStaffsBuilding.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsBuilding.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsBuilding.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsBuilding.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsBuilding.Location = new System.Drawing.Point(44, 466);
            this.lblStaffsBuilding.Name = "lblStaffsBuilding";
            this.lblStaffsBuilding.Size = new System.Drawing.Size(137, 20);
            this.lblStaffsBuilding.TabIndex = 94;
            this.lblStaffsBuilding.Text = "Building No :";
            // 
            // lblStaffsAddress
            // 
            this.lblStaffsAddress.AutoSize = true;
            this.lblStaffsAddress.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsAddress.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsAddress.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsAddress.Location = new System.Drawing.Point(28, 386);
            this.lblStaffsAddress.Name = "lblStaffsAddress";
            this.lblStaffsAddress.Size = new System.Drawing.Size(92, 20);
            this.lblStaffsAddress.TabIndex = 93;
            this.lblStaffsAddress.Text = "Address :";
            // 
            // lblStaffsEmail
            // 
            this.lblStaffsEmail.AutoSize = true;
            this.lblStaffsEmail.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsEmail.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsEmail.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsEmail.Location = new System.Drawing.Point(28, 321);
            this.lblStaffsEmail.Name = "lblStaffsEmail";
            this.lblStaffsEmail.Size = new System.Drawing.Size(153, 20);
            this.lblStaffsEmail.TabIndex = 92;
            this.lblStaffsEmail.Text = "Email Address :";
            // 
            // txtBoxStaffsStreet
            // 
            this.txtBoxStaffsStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsStreet.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsStreet.Enabled = false;
            this.txtBoxStaffsStreet.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsStreet.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsStreet.Location = new System.Drawing.Point(48, 429);
            this.txtBoxStaffsStreet.Multiline = true;
            this.txtBoxStaffsStreet.Name = "txtBoxStaffsStreet";
            this.txtBoxStaffsStreet.Size = new System.Drawing.Size(254, 30);
            this.txtBoxStaffsStreet.TabIndex = 58;
            // 
            // txtBoxStaffsEmail
            // 
            this.txtBoxStaffsEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsEmail.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsEmail.Enabled = false;
            this.txtBoxStaffsEmail.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStaffsEmail.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsEmail.Location = new System.Drawing.Point(42, 341);
            this.txtBoxStaffsEmail.Multiline = true;
            this.txtBoxStaffsEmail.Name = "txtBoxStaffsEmail";
            this.txtBoxStaffsEmail.Size = new System.Drawing.Size(260, 30);
            this.txtBoxStaffsEmail.TabIndex = 57;
            // 
            // lblStaffsStreet
            // 
            this.lblStaffsStreet.AutoSize = true;
            this.lblStaffsStreet.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsStreet.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsStreet.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsStreet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsStreet.Location = new System.Drawing.Point(43, 410);
            this.lblStaffsStreet.Name = "lblStaffsStreet";
            this.lblStaffsStreet.Size = new System.Drawing.Size(75, 20);
            this.lblStaffsStreet.TabIndex = 89;
            this.lblStaffsStreet.Text = "Street :";
            // 
            // lblStaffsPosition
            // 
            this.lblStaffsPosition.AutoSize = true;
            this.lblStaffsPosition.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsPosition.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsPosition.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsPosition.Location = new System.Drawing.Point(28, 200);
            this.lblStaffsPosition.Name = "lblStaffsPosition";
            this.lblStaffsPosition.Size = new System.Drawing.Size(98, 20);
            this.lblStaffsPosition.TabIndex = 88;
            this.lblStaffsPosition.Text = "Position :";
            // 
            // btnStaffsCancel
            // 
            this.btnStaffsCancel.BackColor = System.Drawing.Color.Pink;
            this.btnStaffsCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffsCancel.FlatAppearance.BorderSize = 0;
            this.btnStaffsCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnStaffsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffsCancel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffsCancel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnStaffsCancel.Location = new System.Drawing.Point(204, 996);
            this.btnStaffsCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffsCancel.Name = "btnStaffsCancel";
            this.btnStaffsCancel.Size = new System.Drawing.Size(88, 32);
            this.btnStaffsCancel.TabIndex = 70;
            this.btnStaffsCancel.Text = "Cancel";
            this.btnStaffsCancel.UseVisualStyleBackColor = false;
            this.btnStaffsCancel.Click += new System.EventHandler(this.btnStaffsCancel_Click);
            // 
            // btnStaffsDelete
            // 
            this.btnStaffsDelete.BackColor = System.Drawing.Color.Pink;
            this.btnStaffsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffsDelete.FlatAppearance.BorderSize = 0;
            this.btnStaffsDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnStaffsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffsDelete.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffsDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnStaffsDelete.Location = new System.Drawing.Point(108, 996);
            this.btnStaffsDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffsDelete.Name = "btnStaffsDelete";
            this.btnStaffsDelete.Size = new System.Drawing.Size(88, 32);
            this.btnStaffsDelete.TabIndex = 69;
            this.btnStaffsDelete.Text = "Delete";
            this.btnStaffsDelete.UseVisualStyleBackColor = false;
            this.btnStaffsDelete.Click += new System.EventHandler(this.btnStaffsDelete_Click);
            // 
            // btnStaffsUpdate
            // 
            this.btnStaffsUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnStaffsUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffsUpdate.FlatAppearance.BorderSize = 0;
            this.btnStaffsUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnStaffsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffsUpdate.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffsUpdate.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnStaffsUpdate.Location = new System.Drawing.Point(12, 996);
            this.btnStaffsUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffsUpdate.Name = "btnStaffsUpdate";
            this.btnStaffsUpdate.Size = new System.Drawing.Size(88, 32);
            this.btnStaffsUpdate.TabIndex = 68;
            this.btnStaffsUpdate.Text = "Edit";
            this.btnStaffsUpdate.UseVisualStyleBackColor = false;
            this.btnStaffsUpdate.Click += new System.EventHandler(this.btnStaffsUpdate_Click);
            // 
            // txtBoxStaffsContact
            // 
            this.txtBoxStaffsContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsContact.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsContact.Enabled = false;
            this.txtBoxStaffsContact.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsContact.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsContact.Location = new System.Drawing.Point(42, 281);
            this.txtBoxStaffsContact.Multiline = true;
            this.txtBoxStaffsContact.Name = "txtBoxStaffsContact";
            this.txtBoxStaffsContact.Size = new System.Drawing.Size(260, 30);
            this.txtBoxStaffsContact.TabIndex = 56;
            this.txtBoxStaffsContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxStaffsContact_KeyPress);
            // 
            // txtBoxStaffsLastname
            // 
            this.txtBoxStaffsLastname.AccessibleName = "";
            this.txtBoxStaffsLastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxStaffsLastname.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxStaffsLastname.Enabled = false;
            this.txtBoxStaffsLastname.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.txtBoxStaffsLastname.ForeColor = System.Drawing.Color.Black;
            this.txtBoxStaffsLastname.Location = new System.Drawing.Point(42, 112);
            this.txtBoxStaffsLastname.Multiline = true;
            this.txtBoxStaffsLastname.Name = "txtBoxStaffsLastname";
            this.txtBoxStaffsLastname.Size = new System.Drawing.Size(260, 30);
            this.txtBoxStaffsLastname.TabIndex = 52;
            // 
            // lblStaffsContact
            // 
            this.lblStaffsContact.AutoSize = true;
            this.lblStaffsContact.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsContact.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsContact.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsContact.Location = new System.Drawing.Point(28, 262);
            this.lblStaffsContact.Name = "lblStaffsContact";
            this.lblStaffsContact.Size = new System.Drawing.Size(126, 20);
            this.lblStaffsContact.TabIndex = 50;
            this.lblStaffsContact.Text = "Contact No :";
            // 
            // lblStaffsLastname
            // 
            this.lblStaffsLastname.AutoSize = true;
            this.lblStaffsLastname.BackColor = System.Drawing.Color.MistyRose;
            this.lblStaffsLastname.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaffsLastname.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblStaffsLastname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStaffsLastname.Location = new System.Drawing.Point(44, 94);
            this.lblStaffsLastname.Name = "lblStaffsLastname";
            this.lblStaffsLastname.Size = new System.Drawing.Size(112, 20);
            this.lblStaffsLastname.TabIndex = 48;
            this.lblStaffsLastname.Text = "Lastname :";
            // 
            // btnStaffsAdd
            // 
            this.btnStaffsAdd.BackColor = System.Drawing.Color.LightPink;
            this.btnStaffsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStaffsAdd.FlatAppearance.BorderSize = 0;
            this.btnStaffsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnStaffsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffsAdd.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStaffsAdd.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnStaffsAdd.Location = new System.Drawing.Point(349, 67);
            this.btnStaffsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffsAdd.Name = "btnStaffsAdd";
            this.btnStaffsAdd.Size = new System.Drawing.Size(225, 25);
            this.btnStaffsAdd.TabIndex = 74;
            this.btnStaffsAdd.Text = "Add New Staff Details";
            this.btnStaffsAdd.UseVisualStyleBackColor = false;
            this.btnStaffsAdd.Click += new System.EventHandler(this.btnStaffsAdd_Click);
            // 
            // MV_StaffListMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.btnStaffsAdd);
            this.Controls.Add(this.lblStaffForm);
            this.Controls.Add(this.StaffsFormPanel);
            this.Controls.Add(this.lblStaffsSearch);
            this.Controls.Add(this.txtBoxStaffsSearch);
            this.Controls.Add(this.dtgStaffs);
            this.Controls.Add(this.ManagerStaffsTopPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MV_StaffListMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MV_StaffList_Load);
            this.ManagerStaffsTopPanel.ResumeLayout(false);
            this.ManagerStaffsTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaffs)).EndInit();
            this.StaffsFormPanel.ResumeLayout(false);
            this.StaffsFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManagerStaffsTopPanel;
        private System.Windows.Forms.Label lblMStaffsTopTitle;
        private System.Windows.Forms.DataGridView dtgStaffs;
        private System.Windows.Forms.Label lblStaffsSearch;
        private System.Windows.Forms.TextBox txtBoxStaffsSearch;
        private System.Windows.Forms.Label lblStaffForm;
        private System.Windows.Forms.Panel StaffsFormPanel;
        private System.Windows.Forms.Button btnStaffsCancel;
        private System.Windows.Forms.Button btnStaffsDelete;
        private System.Windows.Forms.Button btnStaffsUpdate;
        private System.Windows.Forms.TextBox txtBoxStaffsContact;
        private System.Windows.Forms.TextBox txtBoxStaffsLastname;
        private System.Windows.Forms.TextBox txtBoxStaffsFirstname;
        private System.Windows.Forms.Label lblStaffsContact;
        private System.Windows.Forms.Label lblStaffsFirstname;
        private System.Windows.Forms.Label lblStaffsLastname;
        private System.Windows.Forms.Label lblStaffsFullname;
        private System.Windows.Forms.RadioButton rbStaffsMale;
        private System.Windows.Forms.RadioButton rbStaffsFemale;
        private System.Windows.Forms.Label lblStaffsPosition;
        private System.Windows.Forms.Label lblStaffsAddress;
        private System.Windows.Forms.Label lblStaffsEmail;
        private System.Windows.Forms.TextBox txtBoxStaffsStreet;
        private System.Windows.Forms.TextBox txtBoxStaffsEmail;
        private System.Windows.Forms.Label lblStaffsStreet;
        private System.Windows.Forms.TextBox txtBoxStaffsCountry;
        private System.Windows.Forms.Label lblStaffsCountry;
        private System.Windows.Forms.TextBox txtBoxStaffsProvince;
        private System.Windows.Forms.Label lblStaffsProvince;
        private System.Windows.Forms.TextBox txtBoxStaffsBrgy;
        private System.Windows.Forms.Label lblStaffsBrgy;
        private System.Windows.Forms.TextBox txtBoxStaffsPurok;
        private System.Windows.Forms.Label lblStaffsPurok;
        private System.Windows.Forms.TextBox txtBoxStaffsHouse;
        private System.Windows.Forms.Label lblStaffsHouse;
        private System.Windows.Forms.TextBox txtBoxStaffsBuilding;
        private System.Windows.Forms.Label lblStaffsBuilding;
        private System.Windows.Forms.Button btnStaffsAdd;
        private System.Windows.Forms.Label lblStaffsStatus;
        private System.Windows.Forms.ComboBox cmbCreateAcctPosition;
        private System.Windows.Forms.TextBox txtBoxStaffsCity;
        private System.Windows.Forms.Label lblStaffsCity;
        private System.Windows.Forms.TextBox txtBoxStaffsID;
        private System.Windows.Forms.Label lblStaffsSex;
        private System.Windows.Forms.RadioButton rbStaffUnemployed;
        private System.Windows.Forms.RadioButton rbStatusEmployed;
    }
}