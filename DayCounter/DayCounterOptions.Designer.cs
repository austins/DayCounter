namespace DayCounter
{
    partial class frmDayCounterOptions
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
            this.lblSinceDate = new System.Windows.Forms.Label();
            this.grpDaysSince = new System.Windows.Forms.GroupBox();
            this.dtpSinceDate = new System.Windows.Forms.DateTimePicker();
            this.grpDateCountdown = new System.Windows.Forms.GroupBox();
            this.dtpCountdownDate = new System.Windows.Forms.DateTimePicker();
            this.lblCountdownDate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpTimeZones = new System.Windows.Forms.GroupBox();
            this.lblTimeZone1 = new System.Windows.Forms.Label();
            this.lblTimeZone2 = new System.Windows.Forms.Label();
            this.cboTimezone1 = new System.Windows.Forms.ComboBox();
            this.cboTimezone2 = new System.Windows.Forms.ComboBox();
            this.chkShowTimeZones = new System.Windows.Forms.CheckBox();
            this.grpDaysSince.SuspendLayout();
            this.grpDateCountdown.SuspendLayout();
            this.grpTimeZones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSinceDate
            // 
            this.lblSinceDate.AutoSize = true;
            this.lblSinceDate.Location = new System.Drawing.Point(6, 19);
            this.lblSinceDate.Name = "lblSinceDate";
            this.lblSinceDate.Size = new System.Drawing.Size(70, 15);
            this.lblSinceDate.TabIndex = 0;
            this.lblSinceDate.Text = "Since Date:";
            // 
            // grpDaysSince
            // 
            this.grpDaysSince.Controls.Add(this.dtpSinceDate);
            this.grpDaysSince.Controls.Add(this.lblSinceDate);
            this.grpDaysSince.Location = new System.Drawing.Point(15, 13);
            this.grpDaysSince.Name = "grpDaysSince";
            this.grpDaysSince.Size = new System.Drawing.Size(365, 50);
            this.grpDaysSince.TabIndex = 1;
            this.grpDaysSince.TabStop = false;
            this.grpDaysSince.Text = "Days Since";
            // 
            // dtpSinceDate
            // 
            this.dtpSinceDate.Location = new System.Drawing.Point(82, 16);
            this.dtpSinceDate.Name = "dtpSinceDate";
            this.dtpSinceDate.Size = new System.Drawing.Size(273, 21);
            this.dtpSinceDate.TabIndex = 1;
            // 
            // grpDateCountdown
            // 
            this.grpDateCountdown.Controls.Add(this.dtpCountdownDate);
            this.grpDateCountdown.Controls.Add(this.lblCountdownDate);
            this.grpDateCountdown.Location = new System.Drawing.Point(15, 69);
            this.grpDateCountdown.Name = "grpDateCountdown";
            this.grpDateCountdown.Size = new System.Drawing.Size(365, 50);
            this.grpDateCountdown.TabIndex = 2;
            this.grpDateCountdown.TabStop = false;
            this.grpDateCountdown.Text = "Date Countdown";
            // 
            // dtpCountdownDate
            // 
            this.dtpCountdownDate.Location = new System.Drawing.Point(113, 19);
            this.dtpCountdownDate.Name = "dtpCountdownDate";
            this.dtpCountdownDate.ShowCheckBox = true;
            this.dtpCountdownDate.Size = new System.Drawing.Size(242, 21);
            this.dtpCountdownDate.TabIndex = 1;
            // 
            // lblCountdownDate
            // 
            this.lblCountdownDate.AutoSize = true;
            this.lblCountdownDate.Location = new System.Drawing.Point(6, 22);
            this.lblCountdownDate.Name = "lblCountdownDate";
            this.lblCountdownDate.Size = new System.Drawing.Size(101, 15);
            this.lblCountdownDate.TabIndex = 0;
            this.lblCountdownDate.Text = "Countdown Date:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(305, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpTimeZones
            // 
            this.grpTimeZones.Controls.Add(this.chkShowTimeZones);
            this.grpTimeZones.Controls.Add(this.cboTimezone2);
            this.grpTimeZones.Controls.Add(this.cboTimezone1);
            this.grpTimeZones.Controls.Add(this.lblTimeZone2);
            this.grpTimeZones.Controls.Add(this.lblTimeZone1);
            this.grpTimeZones.Location = new System.Drawing.Point(15, 125);
            this.grpTimeZones.Name = "grpTimeZones";
            this.grpTimeZones.Size = new System.Drawing.Size(365, 109);
            this.grpTimeZones.TabIndex = 3;
            this.grpTimeZones.TabStop = false;
            this.grpTimeZones.Text = "Time Zones";
            // 
            // lblTimeZone1
            // 
            this.lblTimeZone1.AutoSize = true;
            this.lblTimeZone1.Location = new System.Drawing.Point(6, 48);
            this.lblTimeZone1.Name = "lblTimeZone1";
            this.lblTimeZone1.Size = new System.Drawing.Size(79, 15);
            this.lblTimeZone1.TabIndex = 0;
            this.lblTimeZone1.Text = "Time Zone 1:";
            // 
            // lblTimeZone2
            // 
            this.lblTimeZone2.AutoSize = true;
            this.lblTimeZone2.Location = new System.Drawing.Point(6, 77);
            this.lblTimeZone2.Name = "lblTimeZone2";
            this.lblTimeZone2.Size = new System.Drawing.Size(79, 15);
            this.lblTimeZone2.TabIndex = 1;
            this.lblTimeZone2.Text = "Time Zone 2:";
            // 
            // cboTimezone1
            // 
            this.cboTimezone1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimezone1.FormattingEnabled = true;
            this.cboTimezone1.Location = new System.Drawing.Point(91, 45);
            this.cboTimezone1.Name = "cboTimezone1";
            this.cboTimezone1.Size = new System.Drawing.Size(264, 23);
            this.cboTimezone1.TabIndex = 2;
            // 
            // cboTimezone2
            // 
            this.cboTimezone2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimezone2.FormattingEnabled = true;
            this.cboTimezone2.Location = new System.Drawing.Point(91, 74);
            this.cboTimezone2.Name = "cboTimezone2";
            this.cboTimezone2.Size = new System.Drawing.Size(264, 23);
            this.cboTimezone2.TabIndex = 3;
            // 
            // chkShowTimeZones
            // 
            this.chkShowTimeZones.AutoSize = true;
            this.chkShowTimeZones.Checked = true;
            this.chkShowTimeZones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowTimeZones.Location = new System.Drawing.Point(9, 20);
            this.chkShowTimeZones.Name = "chkShowTimeZones";
            this.chkShowTimeZones.Size = new System.Drawing.Size(132, 19);
            this.chkShowTimeZones.TabIndex = 5;
            this.chkShowTimeZones.Text = "Show Time Zones?";
            this.chkShowTimeZones.UseVisualStyleBackColor = true;
            // 
            // frmDayCounterOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(394, 278);
            this.Controls.Add(this.grpTimeZones);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpDateCountdown);
            this.Controls.Add(this.grpDaysSince);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayCounterOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmDayCounterOptions_Load);
            this.grpDaysSince.ResumeLayout(false);
            this.grpDaysSince.PerformLayout();
            this.grpDateCountdown.ResumeLayout(false);
            this.grpDateCountdown.PerformLayout();
            this.grpTimeZones.ResumeLayout(false);
            this.grpTimeZones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSinceDate;
        private System.Windows.Forms.GroupBox grpDaysSince;
        private System.Windows.Forms.DateTimePicker dtpSinceDate;
        private System.Windows.Forms.GroupBox grpDateCountdown;
        private System.Windows.Forms.DateTimePicker dtpCountdownDate;
        private System.Windows.Forms.Label lblCountdownDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpTimeZones;
        private System.Windows.Forms.ComboBox cboTimezone2;
        private System.Windows.Forms.ComboBox cboTimezone1;
        private System.Windows.Forms.Label lblTimeZone2;
        private System.Windows.Forms.Label lblTimeZone1;
        private System.Windows.Forms.CheckBox chkShowTimeZones;
    }
}