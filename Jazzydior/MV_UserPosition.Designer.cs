namespace Jazzydior
{
    partial class MV_UserPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MV_UserPosition));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanelUserPosition = new System.Windows.Forms.Panel();
            this.btnExitUserPosition = new System.Windows.Forms.Button();
            this.lbluserPosition = new System.Windows.Forms.Label();
            this.btnPositionSave = new System.Windows.Forms.Button();
            this.txtBoxPositionName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.dtgPosition = new System.Windows.Forms.DataGridView();
            this.btnPositionCancel = new System.Windows.Forms.Button();
            this.btnPositionDelete = new System.Windows.Forms.Button();
            this.btnPositionUpdate = new System.Windows.Forms.Button();
            this.txtBoxPositionID = new System.Windows.Forms.TextBox();
            this.TopPanelUserPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanelUserPosition
            // 
            this.TopPanelUserPosition.BackColor = System.Drawing.Color.LightPink;
            this.TopPanelUserPosition.Controls.Add(this.btnExitUserPosition);
            this.TopPanelUserPosition.Controls.Add(this.lbluserPosition);
            this.TopPanelUserPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelUserPosition.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold);
            this.TopPanelUserPosition.Location = new System.Drawing.Point(0, 0);
            this.TopPanelUserPosition.Name = "TopPanelUserPosition";
            this.TopPanelUserPosition.Size = new System.Drawing.Size(744, 52);
            this.TopPanelUserPosition.TabIndex = 3;
            // 
            // btnExitUserPosition
            // 
            this.btnExitUserPosition.BackColor = System.Drawing.Color.LightPink;
            this.btnExitUserPosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitUserPosition.BackgroundImage")));
            this.btnExitUserPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitUserPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnExitUserPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitUserPosition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitUserPosition.ForeColor = System.Drawing.Color.LightPink;
            this.btnExitUserPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitUserPosition.Location = new System.Drawing.Point(698, 0);
            this.btnExitUserPosition.Name = "btnExitUserPosition";
            this.btnExitUserPosition.Size = new System.Drawing.Size(46, 48);
            this.btnExitUserPosition.TabIndex = 63;
            this.btnExitUserPosition.UseVisualStyleBackColor = false;
            this.btnExitUserPosition.Click += new System.EventHandler(this.btnExitUserPosition_Click);
            // 
            // lbluserPosition
            // 
            this.lbluserPosition.AutoSize = true;
            this.lbluserPosition.Font = new System.Drawing.Font("Script MT Bold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserPosition.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbluserPosition.Location = new System.Drawing.Point(9, 2);
            this.lbluserPosition.Name = "lbluserPosition";
            this.lbluserPosition.Size = new System.Drawing.Size(384, 46);
            this.lbluserPosition.TabIndex = 1;
            this.lbluserPosition.Text = "Add New User Position";
            // 
            // btnPositionSave
            // 
            this.btnPositionSave.BackColor = System.Drawing.Color.Pink;
            this.btnPositionSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPositionSave.FlatAppearance.BorderSize = 0;
            this.btnPositionSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnPositionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionSave.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnPositionSave.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnPositionSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPositionSave.Location = new System.Drawing.Point(399, 153);
            this.btnPositionSave.Name = "btnPositionSave";
            this.btnPositionSave.Size = new System.Drawing.Size(88, 32);
            this.btnPositionSave.TabIndex = 35;
            this.btnPositionSave.Text = "Add";
            this.btnPositionSave.UseVisualStyleBackColor = false;
            this.btnPositionSave.Click += new System.EventHandler(this.btnPositionSave_Click);
            // 
            // txtBoxPositionName
            // 
            this.txtBoxPositionName.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxPositionName.Enabled = false;
            this.txtBoxPositionName.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.txtBoxPositionName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.txtBoxPositionName.Location = new System.Drawing.Point(284, 105);
            this.txtBoxPositionName.Multiline = true;
            this.txtBoxPositionName.Name = "txtBoxPositionName";
            this.txtBoxPositionName.Size = new System.Drawing.Size(417, 41);
            this.txtBoxPositionName.TabIndex = 31;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.lblPosition.ForeColor = System.Drawing.Color.MistyRose;
            this.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPosition.Location = new System.Drawing.Point(32, 109);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(242, 31);
            this.lblPosition.TabIndex = 28;
            this.lblPosition.Text = "Position Name :";
            // 
            // dtgPosition
            // 
            this.dtgPosition.AllowUserToAddRows = false;
            this.dtgPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPosition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPosition.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dtgPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPosition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPosition.ColumnHeadersHeight = 50;
            this.dtgPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPosition.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPosition.EnableHeadersVisualStyles = false;
            this.dtgPosition.Location = new System.Drawing.Point(13, 208);
            this.dtgPosition.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPosition.Name = "dtgPosition";
            this.dtgPosition.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPosition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPosition.RowHeadersWidth = 30;
            this.dtgPosition.RowTemplate.Height = 24;
            this.dtgPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPosition.Size = new System.Drawing.Size(718, 221);
            this.dtgPosition.TabIndex = 37;
            this.dtgPosition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPosition_CellClick);
            // 
            // btnPositionCancel
            // 
            this.btnPositionCancel.BackColor = System.Drawing.Color.Thistle;
            this.btnPositionCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPositionCancel.FlatAppearance.BorderSize = 0;
            this.btnPositionCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnPositionCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionCancel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositionCancel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnPositionCancel.Location = new System.Drawing.Point(303, 153);
            this.btnPositionCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositionCancel.Name = "btnPositionCancel";
            this.btnPositionCancel.Size = new System.Drawing.Size(88, 32);
            this.btnPositionCancel.TabIndex = 39;
            this.btnPositionCancel.Text = "Cancel";
            this.btnPositionCancel.UseVisualStyleBackColor = false;
            this.btnPositionCancel.Click += new System.EventHandler(this.btnPositionCancel_Click);
            // 
            // btnPositionDelete
            // 
            this.btnPositionDelete.BackColor = System.Drawing.Color.Pink;
            this.btnPositionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPositionDelete.FlatAppearance.BorderSize = 0;
            this.btnPositionDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnPositionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionDelete.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnPositionDelete.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnPositionDelete.Location = new System.Drawing.Point(591, 153);
            this.btnPositionDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositionDelete.Name = "btnPositionDelete";
            this.btnPositionDelete.Size = new System.Drawing.Size(88, 32);
            this.btnPositionDelete.TabIndex = 41;
            this.btnPositionDelete.Text = "Delete";
            this.btnPositionDelete.UseVisualStyleBackColor = false;
            this.btnPositionDelete.Click += new System.EventHandler(this.btnPositionDelete_Click);
            // 
            // btnPositionUpdate
            // 
            this.btnPositionUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnPositionUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPositionUpdate.FlatAppearance.BorderSize = 0;
            this.btnPositionUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnPositionUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionUpdate.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnPositionUpdate.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnPositionUpdate.Location = new System.Drawing.Point(495, 153);
            this.btnPositionUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositionUpdate.Name = "btnPositionUpdate";
            this.btnPositionUpdate.Size = new System.Drawing.Size(88, 32);
            this.btnPositionUpdate.TabIndex = 40;
            this.btnPositionUpdate.Text = "Edit";
            this.btnPositionUpdate.UseVisualStyleBackColor = false;
            this.btnPositionUpdate.Click += new System.EventHandler(this.btnPositionUpdate_Click);
            // 
            // txtBoxPositionID
            // 
            this.txtBoxPositionID.BackColor = System.Drawing.Color.Ivory;
            this.txtBoxPositionID.Enabled = false;
            this.txtBoxPositionID.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.txtBoxPositionID.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.txtBoxPositionID.Location = new System.Drawing.Point(283, 54);
            this.txtBoxPositionID.Multiline = true;
            this.txtBoxPositionID.Name = "txtBoxPositionID";
            this.txtBoxPositionID.Size = new System.Drawing.Size(417, 41);
            this.txtBoxPositionID.TabIndex = 42;
            this.txtBoxPositionID.Visible = false;
            // 
            // MV_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxPositionID);
            this.Controls.Add(this.btnPositionCancel);
            this.Controls.Add(this.btnPositionDelete);
            this.Controls.Add(this.btnPositionUpdate);
            this.Controls.Add(this.dtgPosition);
            this.Controls.Add(this.btnPositionSave);
            this.Controls.Add(this.txtBoxPositionName);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.TopPanelUserPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(669, 308);
            this.Name = "MV_Position";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MV_Position_Load);
            this.TopPanelUserPosition.ResumeLayout(false);
            this.TopPanelUserPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanelUserPosition;
        private System.Windows.Forms.Label lbluserPosition;
        private System.Windows.Forms.Button btnPositionSave;
        private System.Windows.Forms.TextBox txtBoxPositionName;
        private System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.DataGridView dtgPosition;
        private System.Windows.Forms.Button btnExitUserPosition;
        private System.Windows.Forms.Button btnPositionCancel;
        private System.Windows.Forms.Button btnPositionDelete;
        private System.Windows.Forms.Button btnPositionUpdate;
        private System.Windows.Forms.TextBox txtBoxPositionID;
    }
}