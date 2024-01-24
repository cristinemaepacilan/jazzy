
namespace Jazzydior
{
    partial class SR_Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_Discount));
            this.DiscountTopPanel = new System.Windows.Forms.Panel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.lblDiscountTopTitle = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.lbTotalSales = new System.Windows.Forms.Label();
            this.btnRemoveDiscount = new System.Windows.Forms.Button();
            this.DiscountTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiscountTopPanel
            // 
            this.DiscountTopPanel.BackColor = System.Drawing.Color.LightPink;
            this.DiscountTopPanel.Controls.Add(this.btnExitForm);
            this.DiscountTopPanel.Controls.Add(this.lblDiscountTopTitle);
            this.DiscountTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscountTopPanel.Location = new System.Drawing.Point(0, 0);
            this.DiscountTopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DiscountTopPanel.Name = "DiscountTopPanel";
            this.DiscountTopPanel.Size = new System.Drawing.Size(517, 35);
            this.DiscountTopPanel.TabIndex = 97;
            // 
            // btnExitForm
            // 
            this.btnExitForm.BackColor = System.Drawing.Color.LightPink;
            this.btnExitForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitForm.BackgroundImage")));
            this.btnExitForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitForm.ForeColor = System.Drawing.Color.LightPink;
            this.btnExitForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitForm.Location = new System.Drawing.Point(476, -5);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(46, 45);
            this.btnExitForm.TabIndex = 75;
            this.btnExitForm.UseVisualStyleBackColor = false;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // lblDiscountTopTitle
            // 
            this.lblDiscountTopTitle.AutoSize = true;
            this.lblDiscountTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTopTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblDiscountTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblDiscountTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountTopTitle.Name = "lblDiscountTopTitle";
            this.lblDiscountTopTitle.Size = new System.Drawing.Size(195, 39);
            this.lblDiscountTopTitle.TabIndex = 0;
            this.lblDiscountTopTitle.Text = "Add Discount";
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.ForeColor = System.Drawing.Color.LightPink;
            this.btnOkay.Location = new System.Drawing.Point(45, 246);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(12);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(411, 60);
            this.btnOkay.TabIndex = 104;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDiscount.Location = new System.Drawing.Point(45, 126);
            this.txtBoxDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDiscount.Multiline = true;
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(411, 72);
            this.txtBoxDiscount.TabIndex = 103;
            this.txtBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiscount.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDiscount.Location = new System.Drawing.Point(118, 208);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(268, 23);
            this.checkBoxDiscount.TabIndex = 105;
            this.checkBoxDiscount.Text = "Convert Percent to Decimal";
            this.checkBoxDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // lbTotalSales
            // 
            this.lbTotalSales.AutoSize = true;
            this.lbTotalSales.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbTotalSales.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSales.ForeColor = System.Drawing.Color.MistyRose;
            this.lbTotalSales.Location = new System.Drawing.Point(42, 105);
            this.lbTotalSales.Name = "lbTotalSales";
            this.lbTotalSales.Size = new System.Drawing.Size(130, 17);
            this.lbTotalSales.TabIndex = 106;
            this.lbTotalSales.Text = "Enter Discount :";
            // 
            // btnRemoveDiscount
            // 
            this.btnRemoveDiscount.Location = new System.Drawing.Point(367, 46);
            this.btnRemoveDiscount.Name = "btnRemoveDiscount";
            this.btnRemoveDiscount.Size = new System.Drawing.Size(138, 29);
            this.btnRemoveDiscount.TabIndex = 107;
            this.btnRemoveDiscount.Text = "Remove Discount";
            this.btnRemoveDiscount.UseVisualStyleBackColor = true;
            this.btnRemoveDiscount.Click += new System.EventHandler(this.btnRemoveDiscount_Click);
            // 
            // SR_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemoveDiscount);
            this.Controls.Add(this.lbTotalSales);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtBoxDiscount);
            this.Controls.Add(this.DiscountTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(450, 250);
            this.Name = "SR_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.DiscountTopPanel.ResumeLayout(false);
            this.DiscountTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DiscountTopPanel;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Label lblDiscountTopTitle;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Label lbTotalSales;
        private System.Windows.Forms.Button btnRemoveDiscount;
    }
}