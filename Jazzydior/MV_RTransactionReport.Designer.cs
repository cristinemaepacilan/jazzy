﻿
namespace Jazzydior
{
    partial class MV_RTransactionReport
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
            this.panelTransactionReportMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionReport)).BeginInit();
            this.SuspendLayout();
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
            this.panelTransactionReportMainPanel.Location = new System.Drawing.Point(17, 24);
            this.panelTransactionReportMainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelTransactionReportMainPanel.Name = "panelTransactionReportMainPanel";
            this.panelTransactionReportMainPanel.Size = new System.Drawing.Size(1115, 649);
            this.panelTransactionReportMainPanel.TabIndex = 5;
            // 
            // txtBoxTransactionSearch
            // 
            this.txtBoxTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTransactionSearch.Location = new System.Drawing.Point(624, 33);
            this.txtBoxTransactionSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxTransactionSearch.Multiline = true;
            this.txtBoxTransactionSearch.Name = "txtBoxTransactionSearch";
            this.txtBoxTransactionSearch.Size = new System.Drawing.Size(293, 30);
            this.txtBoxTransactionSearch.TabIndex = 34;
            this.txtBoxTransactionSearch.TextChanged += new System.EventHandler(this.txtBoxTransactionSearch_TextChanged);
            // 
            // lblTransactionSearch
            // 
            this.lblTransactionSearch.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionSearch.Location = new System.Drawing.Point(593, 5);
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
            this.btnTransactionLoad.Location = new System.Drawing.Point(925, 35);
            this.btnTransactionLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTransactionLoad.Name = "btnTransactionLoad";
            this.btnTransactionLoad.Size = new System.Drawing.Size(78, 29);
            this.btnTransactionLoad.TabIndex = 35;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransactionReport.ColumnHeadersHeight = 50;
            this.dataGridViewTransactionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransactionReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransactionReport.EnableHeadersVisualStyles = false;
            this.dataGridViewTransactionReport.Location = new System.Drawing.Point(-2, 97);
            this.dataGridViewTransactionReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewTransactionReport.Name = "dataGridViewTransactionReport";
            this.dataGridViewTransactionReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransactionReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTransactionReport.RowHeadersWidth = 30;
            this.dataGridViewTransactionReport.RowTemplate.Height = 24;
            this.dataGridViewTransactionReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactionReport.Size = new System.Drawing.Size(1116, 551);
            this.dataGridViewTransactionReport.TabIndex = 42;
            // 
            // dateTimePickerTransactionTo
            // 
            this.dateTimePickerTransactionTo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionTo.Location = new System.Drawing.Point(402, 36);
            this.dateTimePickerTransactionTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionTo.Name = "dateTimePickerTransactionTo";
            this.dateTimePickerTransactionTo.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionTo.TabIndex = 41;
            this.dateTimePickerTransactionTo.ValueChanged += new System.EventHandler(this.dateTimePickerTransactionTo_ValueChanged);
            // 
            // lblTransactionTo
            // 
            this.lblTransactionTo.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTo.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionTo.Location = new System.Drawing.Point(361, 41);
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
            this.dateTimePickerTransactionFrom.Location = new System.Drawing.Point(180, 36);
            this.dateTimePickerTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerTransactionFrom.Name = "dateTimePickerTransactionFrom";
            this.dateTimePickerTransactionFrom.Size = new System.Drawing.Size(164, 29);
            this.dateTimePickerTransactionFrom.TabIndex = 39;
            this.dateTimePickerTransactionFrom.ValueChanged += new System.EventHandler(this.dateTimePickerTransactionFrom_ValueChanged);
            // 
            // lblTransactionFrom
            // 
            this.lblTransactionFrom.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFrom.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFrom.Location = new System.Drawing.Point(116, 41);
            this.lblTransactionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFrom.Name = "lblTransactionFrom";
            this.lblTransactionFrom.Size = new System.Drawing.Size(113, 26);
            this.lblTransactionFrom.TabIndex = 38;
            this.lblTransactionFrom.Text = "From:";
            // 
            // lblTransactionFilteredBy
            // 
            this.lblTransactionFilteredBy.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFilteredBy.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTransactionFilteredBy.Location = new System.Drawing.Point(85, 5);
            this.lblTransactionFilteredBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredBy.Name = "lblTransactionFilteredBy";
            this.lblTransactionFilteredBy.Size = new System.Drawing.Size(119, 33);
            this.lblTransactionFilteredBy.TabIndex = 37;
            this.lblTransactionFilteredBy.Text = "Filtered By";
            this.lblTransactionFilteredBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransactionFilteredByPanel
            // 
            this.lblTransactionFilteredByPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionFilteredByPanel.Location = new System.Drawing.Point(67, 20);
            this.lblTransactionFilteredByPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFilteredByPanel.Name = "lblTransactionFilteredByPanel";
            this.lblTransactionFilteredByPanel.Size = new System.Drawing.Size(507, 56);
            this.lblTransactionFilteredByPanel.TabIndex = 36;
            // 
            // lblTransactionSearchPanel
            // 
            this.lblTransactionSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransactionSearchPanel.Location = new System.Drawing.Point(582, 20);
            this.lblTransactionSearchPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionSearchPanel.Name = "lblTransactionSearchPanel";
            this.lblTransactionSearchPanel.Size = new System.Drawing.Size(442, 56);
            this.lblTransactionSearchPanel.TabIndex = 32;
            // 
            // lblSwitchTransactionConnect
            // 
            this.lblSwitchTransactionConnect.BackColor = System.Drawing.Color.MediumVioletRed;
            this.lblSwitchTransactionConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSwitchTransactionConnect.Location = new System.Drawing.Point(43, -1);
            this.lblSwitchTransactionConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSwitchTransactionConnect.Name = "lblSwitchTransactionConnect";
            this.lblSwitchTransactionConnect.Size = new System.Drawing.Size(210, 25);
            this.lblSwitchTransactionConnect.TabIndex = 4;
            // 
            // MV_RTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1147, 683);
            this.ControlBox = false;
            this.Controls.Add(this.panelTransactionReportMainPanel);
            this.Controls.Add(this.lblSwitchTransactionConnect);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MV_RTransactionReport";
            this.panelTransactionReportMainPanel.ResumeLayout(false);
            this.panelTransactionReportMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTransactionReportMainPanel;
        private System.Windows.Forms.Label lblSwitchTransactionConnect;
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