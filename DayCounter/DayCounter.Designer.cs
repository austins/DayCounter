namespace DayCounter
{
    partial class frmDayCounter
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDaysSince = new System.Windows.Forms.Label();
            this.grpDaysSince = new System.Windows.Forms.GroupBox();
            this.grpDateCountdown = new System.Windows.Forms.GroupBox();
            this.lblDateCountdown = new System.Windows.Forms.Label();
            this.grpTimeZones = new System.Windows.Forms.GroupBox();
            this.lblTimeZone1City = new System.Windows.Forms.Label();
            this.lblTimeZone1Time = new System.Windows.Forms.Label();
            this.lblTimeZone1Date = new System.Windows.Forms.Label();
            this.lblTimeZone2Date = new System.Windows.Forms.Label();
            this.lblTimeZone2Time = new System.Windows.Forms.Label();
            this.lblTimeZone2City = new System.Windows.Forms.Label();
            this.tmrTimeZones = new System.Windows.Forms.Timer(this.components);
            this.mnuMain.SuspendLayout();
            this.grpDaysSince.SuspendLayout();
            this.grpDateCountdown.SuspendLayout();
            this.grpTimeZones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(409, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Main Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsOptions});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsOptions
            // 
            this.mnuToolsOptions.Name = "mnuToolsOptions";
            this.mnuToolsOptions.Size = new System.Drawing.Size(116, 22);
            this.mnuToolsOptions.Text = "&Options";
            this.mnuToolsOptions.Click += new System.EventHandler(this.mnuToolsOptions_Click);
            // 
            // lblDaysSince
            // 
            this.lblDaysSince.Location = new System.Drawing.Point(6, 18);
            this.lblDaysSince.Name = "lblDaysSince";
            this.lblDaysSince.Size = new System.Drawing.Size(373, 28);
            this.lblDaysSince.TabIndex = 1;
            this.lblDaysSince.Text = "It\'s been _ days since _.";
            // 
            // grpDaysSince
            // 
            this.grpDaysSince.Controls.Add(this.lblDaysSince);
            this.grpDaysSince.Location = new System.Drawing.Point(12, 27);
            this.grpDaysSince.Name = "grpDaysSince";
            this.grpDaysSince.Size = new System.Drawing.Size(385, 49);
            this.grpDaysSince.TabIndex = 3;
            this.grpDaysSince.TabStop = false;
            this.grpDaysSince.Text = "Days Since";
            // 
            // grpDateCountdown
            // 
            this.grpDateCountdown.Controls.Add(this.lblDateCountdown);
            this.grpDateCountdown.Location = new System.Drawing.Point(12, 82);
            this.grpDateCountdown.Name = "grpDateCountdown";
            this.grpDateCountdown.Size = new System.Drawing.Size(385, 49);
            this.grpDateCountdown.TabIndex = 4;
            this.grpDateCountdown.TabStop = false;
            this.grpDateCountdown.Text = "Date Countdown";
            // 
            // lblDateCountdown
            // 
            this.lblDateCountdown.Location = new System.Drawing.Point(6, 18);
            this.lblDateCountdown.Name = "lblDateCountdown";
            this.lblDateCountdown.Size = new System.Drawing.Size(373, 26);
            this.lblDateCountdown.TabIndex = 1;
            this.lblDateCountdown.Text = "There are _ days left until _.";
            // 
            // grpTimeZones
            // 
            this.grpTimeZones.Controls.Add(this.lblTimeZone2Date);
            this.grpTimeZones.Controls.Add(this.lblTimeZone2Time);
            this.grpTimeZones.Controls.Add(this.lblTimeZone2City);
            this.grpTimeZones.Controls.Add(this.lblTimeZone1Date);
            this.grpTimeZones.Controls.Add(this.lblTimeZone1Time);
            this.grpTimeZones.Controls.Add(this.lblTimeZone1City);
            this.grpTimeZones.Location = new System.Drawing.Point(12, 137);
            this.grpTimeZones.Name = "grpTimeZones";
            this.grpTimeZones.Size = new System.Drawing.Size(385, 128);
            this.grpTimeZones.TabIndex = 5;
            this.grpTimeZones.TabStop = false;
            this.grpTimeZones.Text = "Time Zones";
            // 
            // lblTimeZone1City
            // 
            this.lblTimeZone1City.Location = new System.Drawing.Point(6, 18);
            this.lblTimeZone1City.Name = "lblTimeZone1City";
            this.lblTimeZone1City.Size = new System.Drawing.Size(186, 50);
            this.lblTimeZone1City.TabIndex = 1;
            this.lblTimeZone1City.Text = "City 1";
            this.lblTimeZone1City.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeZone1Time
            // 
            this.lblTimeZone1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZone1Time.Location = new System.Drawing.Point(6, 96);
            this.lblTimeZone1Time.Name = "lblTimeZone1Time";
            this.lblTimeZone1Time.Size = new System.Drawing.Size(186, 26);
            this.lblTimeZone1Time.TabIndex = 2;
            this.lblTimeZone1Time.Text = "Time 1";
            this.lblTimeZone1Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeZone1Date
            // 
            this.lblTimeZone1Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZone1Date.Location = new System.Drawing.Point(6, 70);
            this.lblTimeZone1Date.Name = "lblTimeZone1Date";
            this.lblTimeZone1Date.Size = new System.Drawing.Size(186, 26);
            this.lblTimeZone1Date.TabIndex = 3;
            this.lblTimeZone1Date.Text = "Date 1";
            this.lblTimeZone1Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeZone2Date
            // 
            this.lblTimeZone2Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZone2Date.Location = new System.Drawing.Point(198, 68);
            this.lblTimeZone2Date.Name = "lblTimeZone2Date";
            this.lblTimeZone2Date.Size = new System.Drawing.Size(181, 26);
            this.lblTimeZone2Date.TabIndex = 6;
            this.lblTimeZone2Date.Text = "Date 2";
            this.lblTimeZone2Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeZone2Time
            // 
            this.lblTimeZone2Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeZone2Time.Location = new System.Drawing.Point(198, 96);
            this.lblTimeZone2Time.Name = "lblTimeZone2Time";
            this.lblTimeZone2Time.Size = new System.Drawing.Size(178, 26);
            this.lblTimeZone2Time.TabIndex = 5;
            this.lblTimeZone2Time.Text = "Time 2";
            this.lblTimeZone2Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeZone2City
            // 
            this.lblTimeZone2City.Location = new System.Drawing.Point(198, 18);
            this.lblTimeZone2City.Name = "lblTimeZone2City";
            this.lblTimeZone2City.Size = new System.Drawing.Size(178, 50);
            this.lblTimeZone2City.TabIndex = 4;
            this.lblTimeZone2City.Text = "City 2";
            this.lblTimeZone2City.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTimeZones
            // 
            this.tmrTimeZones.Interval = 1000;
            this.tmrTimeZones.Tick += new System.EventHandler(this.tmrTimeZones_Tick);
            // 
            // frmDayCounter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(409, 278);
            this.Controls.Add(this.grpTimeZones);
            this.Controls.Add(this.grpDateCountdown);
            this.Controls.Add(this.grpDaysSince);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmDayCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Counter";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpDaysSince.ResumeLayout(false);
            this.grpDateCountdown.ResumeLayout(false);
            this.grpTimeZones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsOptions;
        private System.Windows.Forms.Label lblDaysSince;
        private System.Windows.Forms.GroupBox grpDaysSince;
        private System.Windows.Forms.GroupBox grpDateCountdown;
        private System.Windows.Forms.Label lblDateCountdown;
        private System.Windows.Forms.GroupBox grpTimeZones;
        private System.Windows.Forms.Label lblTimeZone2Date;
        private System.Windows.Forms.Label lblTimeZone2Time;
        private System.Windows.Forms.Label lblTimeZone2City;
        private System.Windows.Forms.Label lblTimeZone1Date;
        private System.Windows.Forms.Label lblTimeZone1Time;
        private System.Windows.Forms.Label lblTimeZone1City;
        private System.Windows.Forms.Timer tmrTimeZones;
    }
}

