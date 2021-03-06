﻿namespace DataAggregation
{
    partial class AggregationSettingsDialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.paSettings = new System.Windows.Forms.Panel();
            this.lblVariable = new System.Windows.Forms.Label();
            this.cmbVariable = new System.Windows.Forms.ComboBox();
            this.chbCreateNewLayer = new System.Windows.Forms.CheckBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.paSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(153, 273);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(14, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(105, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type of aggregation:";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Location = new System.Drawing.Point(119, 21);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(168, 21);
            this.cmbMode.TabIndex = 3;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(14, 90);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartTime.Location = new System.Drawing.Point(119, 90);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(168, 20);
            this.dtpStartTime.TabIndex = 5;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(14, 124);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End Time:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTime.Location = new System.Drawing.Point(119, 124);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(168, 20);
            this.dtpEndTime.TabIndex = 7;
            // 
            // pbProgress
            // 
            this.pbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgress.Location = new System.Drawing.Point(12, 216);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(297, 23);
            this.pbProgress.TabIndex = 8;
            this.pbProgress.Visible = false;
            // 
            // paSettings
            // 
            this.paSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paSettings.Controls.Add(this.chbCreateNewLayer);
            this.paSettings.Controls.Add(this.lblVariable);
            this.paSettings.Controls.Add(this.cmbVariable);
            this.paSettings.Controls.Add(this.lblType);
            this.paSettings.Controls.Add(this.cmbMode);
            this.paSettings.Controls.Add(this.dtpEndTime);
            this.paSettings.Controls.Add(this.lblStartTime);
            this.paSettings.Controls.Add(this.lblEndTime);
            this.paSettings.Controls.Add(this.dtpStartTime);
            this.paSettings.Location = new System.Drawing.Point(12, 12);
            this.paSettings.Name = "paSettings";
            this.paSettings.Size = new System.Drawing.Size(297, 193);
            this.paSettings.TabIndex = 9;
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(14, 55);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(48, 13);
            this.lblVariable.TabIndex = 8;
            this.lblVariable.Text = "Variable:";
            // 
            // cmbVariable
            // 
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(119, 55);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(168, 21);
            this.cmbVariable.TabIndex = 9;
            // 
            // chbCreateNewLayer
            // 
            this.chbCreateNewLayer.AutoSize = true;
            this.chbCreateNewLayer.Location = new System.Drawing.Point(14, 155);
            this.chbCreateNewLayer.Name = "chbCreateNewLayer";
            this.chbCreateNewLayer.Size = new System.Drawing.Size(105, 17);
            this.chbCreateNewLayer.TabIndex = 10;
            this.chbCreateNewLayer.Text = "Create new layer";
            this.chbCreateNewLayer.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(9, 249);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(93, 13);
            this.lblProgress.TabIndex = 10;
            this.lblProgress.Text = "Current Operation:";
            this.lblProgress.Visible = false;
            // 
            // AggregationSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 318);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.paSettings);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggregationSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggregation Settings";
            this.paSettings.ResumeLayout(false);
            this.paSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Panel paSettings;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.ComboBox cmbVariable;
        private System.Windows.Forms.CheckBox chbCreateNewLayer;
        private System.Windows.Forms.Label lblProgress;
    }
}