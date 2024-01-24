namespace Jazzydior
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginPass = new System.Windows.Forms.TextBox();
            this.txtBoxLoginUser = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.panelformcreate = new System.Windows.Forms.Panel();
            this.panelJazzyLogoLogin = new System.Windows.Forms.Panel();
            this.TopPanelLogin = new System.Windows.Forms.Panel();
            this.btnExitLoginAcct = new System.Windows.Forms.Button();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.TopPanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Pink;
            this.btnLogin.Location = new System.Drawing.Point(532, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(303, 66);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxLoginPass
            // 
            this.txtBoxLoginPass.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginPass.Location = new System.Drawing.Point(532, 287);
            this.txtBoxLoginPass.Multiline = true;
            this.txtBoxLoginPass.Name = "txtBoxLoginPass";
            this.txtBoxLoginPass.PasswordChar = '*';
            this.txtBoxLoginPass.Size = new System.Drawing.Size(303, 42);
            this.txtBoxLoginPass.TabIndex = 17;
            // 
            // txtBoxLoginUser
            // 
            this.txtBoxLoginUser.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginUser.Location = new System.Drawing.Point(532, 188);
            this.txtBoxLoginUser.Multiline = true;
            this.txtBoxLoginUser.Name = "txtBoxLoginUser";
            this.txtBoxLoginUser.Size = new System.Drawing.Size(303, 42);
            this.txtBoxLoginUser.TabIndex = 16;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Lucida Handwriting", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPass.ForeColor = System.Drawing.Color.MistyRose;
            this.lblLoginPass.Location = new System.Drawing.Point(527, 255);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(132, 28);
            this.lblLoginPass.TabIndex = 15;
            this.lblLoginPass.Text = "Password";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Lucida Handwriting", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.MistyRose;
            this.lblLoginUsername.Location = new System.Drawing.Point(527, 156);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(145, 28);
            this.lblLoginUsername.TabIndex = 14;
            this.lblLoginUsername.Text = "Username";
            // 
            // panelformcreate
            // 
            this.panelformcreate.Location = new System.Drawing.Point(0, 0);
            this.panelformcreate.Name = "panelformcreate";
            this.panelformcreate.Size = new System.Drawing.Size(200, 100);
            this.panelformcreate.TabIndex = 0;
            // 
            // panelJazzyLogoLogin
            // 
            this.panelJazzyLogoLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelJazzyLogoLogin.BackgroundImage")));
            this.panelJazzyLogoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelJazzyLogoLogin.Location = new System.Drawing.Point(3, 44);
            this.panelJazzyLogoLogin.Name = "panelJazzyLogoLogin";
            this.panelJazzyLogoLogin.Size = new System.Drawing.Size(446, 474);
            this.panelJazzyLogoLogin.TabIndex = 33;
            // 
            // TopPanelLogin
            // 
            this.TopPanelLogin.BackColor = System.Drawing.Color.DeepPink;
            this.TopPanelLogin.Controls.Add(this.btnExitLoginAcct);
            this.TopPanelLogin.Controls.Add(this.lblSystemTitle);
            this.TopPanelLogin.Location = new System.Drawing.Point(-6, -3);
            this.TopPanelLogin.Name = "TopPanelLogin";
            this.TopPanelLogin.Size = new System.Drawing.Size(936, 49);
            this.TopPanelLogin.TabIndex = 35;
            // 
            // btnExitLoginAcct
            // 
            this.btnExitLoginAcct.BackColor = System.Drawing.Color.DeepPink;
            this.btnExitLoginAcct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitLoginAcct.BackgroundImage")));
            this.btnExitLoginAcct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitLoginAcct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnExitLoginAcct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLoginAcct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitLoginAcct.ForeColor = System.Drawing.Color.DeepPink;
            this.btnExitLoginAcct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitLoginAcct.Location = new System.Drawing.Point(887, -1);
            this.btnExitLoginAcct.Name = "btnExitLoginAcct";
            this.btnExitLoginAcct.Size = new System.Drawing.Size(48, 55);
            this.btnExitLoginAcct.TabIndex = 63;
            this.btnExitLoginAcct.UseVisualStyleBackColor = false;
            this.btnExitLoginAcct.Click += new System.EventHandler(this.btnExitLoginAcct_Click);
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblSystemTitle.Location = new System.Drawing.Point(8, 11);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(766, 29);
            this.lblSystemTitle.TabIndex = 36;
            this.lblSystemTitle.Text = "Jazzydior Beauty Lounge Sales Management System with Customers Receipt";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.MistyRose;
            this.lblTime.Location = new System.Drawing.Point(799, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 22);
            this.lblTime.TabIndex = 37;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.MistyRose;
            this.lblDate.Location = new System.Drawing.Point(453, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 22);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date";
            // 
            // btnHidePass
            // 
            this.btnHidePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHidePass.BackgroundImage")));
            this.btnHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHidePass.FlatAppearance.BorderSize = 0;
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.Location = new System.Drawing.Point(841, 287);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(45, 42);
            this.btnHidePass.TabIndex = 38;
            this.btnHidePass.UseVisualStyleBackColor = true;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePassw_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass.BackgroundImage")));
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Location = new System.Drawing.Point(841, 287);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(45, 42);
            this.btnShowPass.TabIndex = 39;
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.TopPanelLogin);
            this.Controls.Add(this.panelJazzyLogoLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxLoginPass);
            this.Controls.Add(this.txtBoxLoginUser);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.lblLoginUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.TopPanelLogin.ResumeLayout(false);
            this.TopPanelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxLoginPass;
        private System.Windows.Forms.TextBox txtBoxLoginUser;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Panel panelformcreate;
        private System.Windows.Forms.Panel panelJazzyLogoLogin;
        private System.Windows.Forms.Panel TopPanelLogin;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Button btnExitLoginAcct;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.Button btnShowPass;
    }
}