
namespace Jazzydior
{
    partial class MV_RSalesPrintReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MV_RSalesPrintReview));
            this.ManagerPrintReviewTopPanel = new System.Windows.Forms.Panel();
            this.btnExitPrintReviewForm = new System.Windows.Forms.Button();
            this.lblMPrintReviewTopTitle = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionTo = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionTo = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionFrom = new System.Windows.Forms.Label();
            this.lblTransactionFilteredBy = new System.Windows.Forms.Label();
            this.lblTransactionFilteredByPanel = new System.Windows.Forms.Label();
            this.ManagerPrintReviewTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerPrintReviewTopPanel
            // 
            this.ManagerPrintReviewTopPanel.BackColor = System.Drawing.Color.LightPink;
            this.ManagerPrintReviewTopPanel.Controls.Add(this.btnExitPrintReviewForm);
            this.ManagerPrintReviewTopPanel.Controls.Add(this.lblMPrintReviewTopTitle);
            this.ManagerPrintReviewTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagerPrintReviewTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagerPrintReviewTopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ManagerPrintReviewTopPanel.Name = "ManagerPrintReviewTopPanel";
            this.ManagerPrintReviewTopPanel.Size = new System.Drawing.Size(1145, 35);
            this.ManagerPrintReviewTopPanel.TabIndex = 4;
            // 
            // btnExitPrintReviewForm
            // 
            this.btnExitPrintReviewForm.BackColor = System.Drawing.Color.LightPink;
            this.btnExitPrintReviewForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitPrintReviewForm.BackgroundImage")));
            this.btnExitPrintReviewForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitPrintReviewForm.FlatAppearance.BorderSize = 0;
            this.btnExitPrintReviewForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnExitPrintReviewForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPrintReviewForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitPrintReviewForm.ForeColor = System.Drawing.Color.MistyRose;
            this.btnExitPrintReviewForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExitPrintReviewForm.Location = new System.Drawing.Point(1103, -4);
            this.btnExitPrintReviewForm.Name = "btnExitPrintReviewForm";
            this.btnExitPrintReviewForm.Size = new System.Drawing.Size(46, 43);
            this.btnExitPrintReviewForm.TabIndex = 18;
            this.btnExitPrintReviewForm.UseVisualStyleBackColor = false;
            this.btnExitPrintReviewForm.Click += new System.EventHandler(this.btnExitPrintReviewForm_Click);
            // 
            // lblMPrintReviewTopTitle
            // 
            this.lblMPrintReviewTopTitle.AutoSize = true;
            this.lblMPrintReviewTopTitle.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMPrintReviewTopTitle.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblMPrintReviewTopTitle.Location = new System.Drawing.Point(3, -1);
            this.lblMPrintReviewTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPrintReviewTopTitle.Name = "lblMPrintReviewTopTitle";
            this.lblMPrintReviewTopTitle.Size = new System.Drawing.Size(186, 39);
            this.lblMPrintReviewTopTitle.TabIndex = 1;
            this.lblMPrintReviewTopTitle.Text = "Print Review";
            // 
            // dateTimePickerTransactionTo
            // 
            this.dateTimePickerTransactionTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionTo.Location = new System.Drawing.Point(373, 75);
            this.dateTimePickerTransactionTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionTo.Name = "dateTimePickerTransactionTo";
            this.dateTimePickerTransactionTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionTo.TabIndex = 31;
            // 
            // lblTransactionTo
            // 
            this.lblTransactionTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTo.ForeColor = System.Drawing.Color.MistyRose;
            this.lblTransactionTo.Location = new System.Drawing.Point(332, 80);
            this.lblTransactionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionTo.Name = "lblTransactionTo";
            this.lblTransactionTo.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionTo.TabIndex = 30;
            this.lblTransactionTo.Tag = "";
            this.lblTransactionTo.Text = "To:";
            // 
            // dateTimePickerTransactionFrom
            // 
            this.dateTimePickerTransactionFrom.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionFrom.Location = new System.Drawing.Point(151, 75);
            this.dateTimePickerTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionFrom.Name = "dateTimePickerTransactionFrom";
            this.dateTimePickerTransactionFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionFrom.TabIndex = 29;
            // 
            // lblTransactionFrom
            // 
            this.lblTransactionFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFrom.ForeColor = System.Drawing.Color.MistyRose;
            this.lblTransactionFrom.Location = new System.Drawing.Point(87, 80);
            this.lblTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFrom.Name = "lblTransactionFrom";
            this.lblTransactionFrom.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionFrom.TabIndex = 28;
            this.lblTransactionFrom.Text = "From:";
            // 
            // lblTransactionFilteredBy
            // 
            this.lblTransactionFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFilteredBy.ForeColor = System.Drawing.Color.MistyRose;
            this.lblTransactionFilteredBy.Location = new System.Drawing.Point(56, 44);
            this.lblTransactionFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredBy.Name = "lblTransactionFilteredBy";
            this.lblTransactionFilteredBy.Size = new System.Drawing.Size(119, 33);
            this.lblTransactionFilteredBy.TabIndex = 27;
            this.lblTransactionFilteredBy.Text = "Filtered By";
            this.lblTransactionFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionFilteredByPanel
            // 
            this.lblTransactionFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionFilteredByPanel.Location = new System.Drawing.Point(38, 59);
            this.lblTransactionFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredByPanel.Name = "lblTransactionFilteredByPanel";
            this.lblTransactionFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblTransactionFilteredByPanel.TabIndex = 26;
            // 
            // MV_RSalesPrintReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1145, 754);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePickerTransactionTo);
            this.Controls.Add(this.lblTransactionTo);
            this.Controls.Add(this.dateTimePickerTransactionFrom);
            this.Controls.Add(this.lblTransactionFrom);
            this.Controls.Add(this.lblTransactionFilteredBy);
            this.Controls.Add(this.lblTransactionFilteredByPanel);
            this.Controls.Add(this.ManagerPrintReviewTopPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MV_RSalesPrintReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ManagerPrintReviewTopPanel.ResumeLayout(false);
            this.ManagerPrintReviewTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagerPrintReviewTopPanel;
        private System.Windows.Forms.Button btnExitPrintReviewForm;
        private System.Windows.Forms.Label lblMPrintReviewTopTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionTo;
        private System.Windows.Forms.Label lblTransactionTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFrom;
        private System.Windows.Forms.Label lblTransactionFilteredBy;
        private System.Windows.Forms.Label lblTransactionFilteredByPanel;
    }
}