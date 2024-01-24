
namespace JazzydiorBeautyLounge_SMSwCR.Forms.Manager_Forms
{
    partial class FormServicesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagerServicesTopPanel = new System.Windows.Forms.Panel();
            this.lblMServicesTopTitle = new System.Windows.Forms.Label();
            this.lblSLSearchPanel = new System.Windows.Forms.Label();
            this.lblSLSearch = new System.Windows.Forms.Label();
            this.txtBoxSLSearch = new System.Windows.Forms.TextBox();
            this.btnSLLoad = new System.Windows.Forms.Button();
            this.btnServicesDelete = new System.Windows.Forms.Button();
            this.btnServicesEdit = new System.Windows.Forms.Button();
            this.btnServicesAdd = new System.Windows.Forms.Button();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.Serv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerServicesTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerServicesTopPanel
            // 
            this.ManagerServicesTopPanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ManagerServicesTopPanel.Controls.Add(this.lblMServicesTopTitle);
            this.ManagerServicesTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerServicesTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerServicesTopPanel.Name = "ManagerServicesTopPanel";
            this.ManagerServicesTopPanel.Size = new System.Drawing.Size(1540, 61);
            this.ManagerServicesTopPanel.TabIndex = 1;
            // 
            // lblMServicesTopTitle
            // 
            this.lblMServicesTopTitle.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMServicesTopTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMServicesTopTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMServicesTopTitle.Name = "lblMServicesTopTitle";
            this.lblMServicesTopTitle.Size = new System.Drawing.Size(264, 43);
            this.lblMServicesTopTitle.TabIndex = 0;
            this.lblMServicesTopTitle.Text = "Services List";
            // 
            // lblSLSearchPanel
            // 
            this.lblSLSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSLSearchPanel.Location = new System.Drawing.Point(49, 82);
            this.lblSLSearchPanel.Name = "lblSLSearchPanel";
            this.lblSLSearchPanel.Size = new System.Drawing.Size(713, 73);
            this.lblSLSearchPanel.TabIndex = 2;
            // 
            // lblSLSearch
            // 
            this.lblSLSearch.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblSLSearch.Location = new System.Drawing.Point(89, 70);
            this.lblSLSearch.Name = "lblSLSearch";
            this.lblSLSearch.Size = new System.Drawing.Size(134, 23);
            this.lblSLSearch.TabIndex = 3;
            this.lblSLSearch.Text = "Search Here";
            // 
            // txtBoxSLSearch
            // 
            this.txtBoxSLSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSLSearch.Location = new System.Drawing.Point(124, 100);
            this.txtBoxSLSearch.Multiline = true;
            this.txtBoxSLSearch.Name = "txtBoxSLSearch";
            this.txtBoxSLSearch.Size = new System.Drawing.Size(518, 37);
            this.txtBoxSLSearch.TabIndex = 4;
            // 
            // btnSLLoad
            // 
            this.btnSLLoad.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnSLLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnSLLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSLLoad.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLLoad.ForeColor = System.Drawing.Color.MistyRose;
            this.btnSLLoad.Location = new System.Drawing.Point(654, 101);
            this.btnSLLoad.Name = "btnSLLoad";
            this.btnSLLoad.Size = new System.Drawing.Size(94, 36);
            this.btnSLLoad.TabIndex = 5;
            this.btnSLLoad.Text = "LOAD";
            this.btnSLLoad.UseVisualStyleBackColor = false;
            // 
            // btnServicesDelete
            // 
            this.btnServicesDelete.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnServicesDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServicesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesDelete.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.btnServicesDelete.ForeColor = System.Drawing.Color.MistyRose;
            this.btnServicesDelete.Location = new System.Drawing.Point(1390, 82);
            this.btnServicesDelete.Name = "btnServicesDelete";
            this.btnServicesDelete.Size = new System.Drawing.Size(138, 73);
            this.btnServicesDelete.TabIndex = 6;
            this.btnServicesDelete.Text = "Delete";
            this.btnServicesDelete.UseVisualStyleBackColor = false;
            // 
            // btnServicesEdit
            // 
            this.btnServicesEdit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnServicesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServicesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesEdit.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.btnServicesEdit.ForeColor = System.Drawing.Color.MistyRose;
            this.btnServicesEdit.Location = new System.Drawing.Point(1235, 82);
            this.btnServicesEdit.Name = "btnServicesEdit";
            this.btnServicesEdit.Size = new System.Drawing.Size(138, 73);
            this.btnServicesEdit.TabIndex = 7;
            this.btnServicesEdit.Text = "Edit";
            this.btnServicesEdit.UseVisualStyleBackColor = false;
            // 
            // btnServicesAdd
            // 
            this.btnServicesAdd.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnServicesAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnServicesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesAdd.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesAdd.ForeColor = System.Drawing.Color.MistyRose;
            this.btnServicesAdd.Location = new System.Drawing.Point(1080, 82);
            this.btnServicesAdd.Name = "btnServicesAdd";
            this.btnServicesAdd.Size = new System.Drawing.Size(138, 73);
            this.btnServicesAdd.TabIndex = 8;
            this.btnServicesAdd.Text = "Add";
            this.btnServicesAdd.UseVisualStyleBackColor = false;
            this.btnServicesAdd.Click += new System.EventHandler(this.btnServicesAdd_Click);
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewServices.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewServices.ColumnHeadersHeight = 35;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serv_ID,
            this.Description,
            this.Category,
            this.Time,
            this.Price});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewServices.EnableHeadersVisualStyles = false;
            this.dataGridViewServices.Location = new System.Drawing.Point(12, 181);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewServices.RowHeadersWidth = 30;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServices.Size = new System.Drawing.Size(1516, 662);
            this.dataGridViewServices.TabIndex = 9;
            // 
            // Serv_ID
            // 
            this.Serv_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serv_ID.DefaultCellStyle = dataGridViewCellStyle12;
            this.Serv_ID.HeaderText = "Service ID No";
            this.Serv_ID.MinimumWidth = 6;
            this.Serv_ID.Name = "Serv_ID";
            this.Serv_ID.ReadOnly = true;
            this.Serv_ID.Width = 167;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            this.Description.DefaultCellStyle = dataGridViewCellStyle13;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 148;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            this.Category.DefaultCellStyle = dataGridViewCellStyle14;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 123;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            this.Time.DefaultCellStyle = dataGridViewCellStyle15;
            this.Time.HeaderText = "Lead Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 138;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            this.Price.DefaultCellStyle = dataGridViewCellStyle16;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 88;
            // 
            // FormServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1540, 855);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.btnServicesAdd);
            this.Controls.Add(this.btnServicesEdit);
            this.Controls.Add(this.btnServicesDelete);
            this.Controls.Add(this.btnSLLoad);
            this.Controls.Add(this.txtBoxSLSearch);
            this.Controls.Add(this.lblSLSearch);
            this.Controls.Add(this.lblSLSearchPanel);
            this.Controls.Add(this.ManagerServicesTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormServicesList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ManagerServicesTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManagerServicesTopPanel;
        private System.Windows.Forms.Label lblMServicesTopTitle;
        private System.Windows.Forms.Label lblSLSearchPanel;
        private System.Windows.Forms.Label lblSLSearch;
        private System.Windows.Forms.TextBox txtBoxSLSearch;
        private System.Windows.Forms.Button btnSLLoad;
        private System.Windows.Forms.Button btnServicesDelete;
        private System.Windows.Forms.Button btnServicesEdit;
        private System.Windows.Forms.Button btnServicesAdd;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}