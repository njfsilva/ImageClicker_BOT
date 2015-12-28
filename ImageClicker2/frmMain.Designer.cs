namespace ImageClicker2
{
    partial class frmMain
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
            this.grpDesktopArea = new System.Windows.Forms.GroupBox();
            this.btnSetRectangle = new System.Windows.Forms.Button();
            this.txtYend = new System.Windows.Forms.Label();
            this.txtYstart = new System.Windows.Forms.Label();
            this.txtXend = new System.Windows.Forms.Label();
            this.lblYend = new System.Windows.Forms.Label();
            this.txtXstart = new System.Windows.Forms.Label();
            this.lblXend = new System.Windows.Forms.Label();
            this.lblYstart = new System.Windows.Forms.Label();
            this.lblXstart = new System.Windows.Forms.Label();
            this.grpAreaPreview = new System.Windows.Forms.GroupBox();
            this.btnResetGroup = new System.Windows.Forms.Button();
            this.chkScreens = new System.Windows.Forms.CheckBox();
            this.chkClick = new System.Windows.Forms.CheckBox();
            this.txtSpeed = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbMonitorSpeed = new System.Windows.Forms.TrackBar();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.grpReferenceImages = new System.Windows.Forms.GroupBox();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lstImageList = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.tmrClicker = new System.Windows.Forms.Timer(this.components);
            this.grpDesktopArea.SuspendLayout();
            this.grpAreaPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorSpeed)).BeginInit();
            this.grpReferenceImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDesktopArea
            // 
            this.grpDesktopArea.Controls.Add(this.btnSetRectangle);
            this.grpDesktopArea.Controls.Add(this.txtYend);
            this.grpDesktopArea.Controls.Add(this.txtYstart);
            this.grpDesktopArea.Controls.Add(this.txtXend);
            this.grpDesktopArea.Controls.Add(this.lblYend);
            this.grpDesktopArea.Controls.Add(this.txtXstart);
            this.grpDesktopArea.Controls.Add(this.lblXend);
            this.grpDesktopArea.Controls.Add(this.lblYstart);
            this.grpDesktopArea.Controls.Add(this.lblXstart);
            this.grpDesktopArea.Location = new System.Drawing.Point(12, 12);
            this.grpDesktopArea.Name = "grpDesktopArea";
            this.grpDesktopArea.Size = new System.Drawing.Size(626, 82);
            this.grpDesktopArea.TabIndex = 0;
            this.grpDesktopArea.TabStop = false;
            this.grpDesktopArea.Text = "Desktop Area";
            // 
            // btnSetRectangle
            // 
            this.btnSetRectangle.Location = new System.Drawing.Point(412, 21);
            this.btnSetRectangle.Name = "btnSetRectangle";
            this.btnSetRectangle.Size = new System.Drawing.Size(75, 41);
            this.btnSetRectangle.TabIndex = 4;
            this.btnSetRectangle.Text = "Select Area";
            this.btnSetRectangle.UseVisualStyleBackColor = true;
            this.btnSetRectangle.Click += new System.EventHandler(this.btnSetRectangle_Click);
            // 
            // txtYend
            // 
            this.txtYend.AutoSize = true;
            this.txtYend.Location = new System.Drawing.Point(330, 49);
            this.txtYend.Name = "txtYend";
            this.txtYend.Size = new System.Drawing.Size(41, 13);
            this.txtYend.TabIndex = 3;
            this.txtYend.Text = "YYYYb";
            // 
            // txtYstart
            // 
            this.txtYstart.AutoSize = true;
            this.txtYstart.Location = new System.Drawing.Point(330, 21);
            this.txtYstart.Name = "txtYstart";
            this.txtYstart.Size = new System.Drawing.Size(40, 13);
            this.txtYstart.TabIndex = 3;
            this.txtYstart.Text = "YYYYs";
            // 
            // txtXend
            // 
            this.txtXend.AutoSize = true;
            this.txtXend.Location = new System.Drawing.Point(188, 49);
            this.txtXend.Name = "txtXend";
            this.txtXend.Size = new System.Drawing.Size(41, 13);
            this.txtXend.TabIndex = 2;
            this.txtXend.Text = "XXXXb";
            // 
            // lblYend
            // 
            this.lblYend.AutoSize = true;
            this.lblYend.Location = new System.Drawing.Point(285, 49);
            this.lblYend.Name = "lblYend";
            this.lblYend.Size = new System.Drawing.Size(39, 13);
            this.lblYend.TabIndex = 1;
            this.lblYend.Text = "End Y:";
            // 
            // txtXstart
            // 
            this.txtXstart.AutoSize = true;
            this.txtXstart.Location = new System.Drawing.Point(188, 21);
            this.txtXstart.Name = "txtXstart";
            this.txtXstart.Size = new System.Drawing.Size(40, 13);
            this.txtXstart.TabIndex = 2;
            this.txtXstart.Text = "XXXXs";
            // 
            // lblXend
            // 
            this.lblXend.AutoSize = true;
            this.lblXend.Location = new System.Drawing.Point(143, 49);
            this.lblXend.Name = "lblXend";
            this.lblXend.Size = new System.Drawing.Size(39, 13);
            this.lblXend.TabIndex = 0;
            this.lblXend.Text = "End X:";
            // 
            // lblYstart
            // 
            this.lblYstart.AutoSize = true;
            this.lblYstart.Location = new System.Drawing.Point(282, 21);
            this.lblYstart.Name = "lblYstart";
            this.lblYstart.Size = new System.Drawing.Size(42, 13);
            this.lblYstart.TabIndex = 1;
            this.lblYstart.Text = "Start Y:";
            // 
            // lblXstart
            // 
            this.lblXstart.AutoSize = true;
            this.lblXstart.Location = new System.Drawing.Point(140, 21);
            this.lblXstart.Name = "lblXstart";
            this.lblXstart.Size = new System.Drawing.Size(42, 13);
            this.lblXstart.TabIndex = 0;
            this.lblXstart.Text = "Start X:";
            // 
            // grpAreaPreview
            // 
            this.grpAreaPreview.Controls.Add(this.btnResetGroup);
            this.grpAreaPreview.Controls.Add(this.chkScreens);
            this.grpAreaPreview.Controls.Add(this.chkClick);
            this.grpAreaPreview.Controls.Add(this.txtSpeed);
            this.grpAreaPreview.Controls.Add(this.lblSpeed);
            this.grpAreaPreview.Controls.Add(this.tbMonitorSpeed);
            this.grpAreaPreview.Controls.Add(this.btnStopMonitoring);
            this.grpAreaPreview.Controls.Add(this.btnStartMonitoring);
            this.grpAreaPreview.Location = new System.Drawing.Point(12, 100);
            this.grpAreaPreview.Name = "grpAreaPreview";
            this.grpAreaPreview.Size = new System.Drawing.Size(393, 202);
            this.grpAreaPreview.TabIndex = 1;
            this.grpAreaPreview.TabStop = false;
            this.grpAreaPreview.Text = "Area Preview";
            // 
            // btnResetGroup
            // 
            this.btnResetGroup.Location = new System.Drawing.Point(288, 19);
            this.btnResetGroup.Name = "btnResetGroup";
            this.btnResetGroup.Size = new System.Drawing.Size(75, 57);
            this.btnResetGroup.TabIndex = 12;
            this.btnResetGroup.Text = "Reset Group (for new game)";
            this.btnResetGroup.UseVisualStyleBackColor = true;
            this.btnResetGroup.Click += new System.EventHandler(this.btnResetGroup_Click);
            // 
            // chkScreens
            // 
            this.chkScreens.AutoSize = true;
            this.chkScreens.Location = new System.Drawing.Point(191, 42);
            this.chkScreens.Name = "chkScreens";
            this.chkScreens.Size = new System.Drawing.Size(87, 17);
            this.chkScreens.TabIndex = 8;
            this.chkScreens.Text = "AutoScreens";
            this.chkScreens.UseVisualStyleBackColor = true;
            // 
            // chkClick
            // 
            this.chkClick.AutoSize = true;
            this.chkClick.Checked = true;
            this.chkClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClick.Location = new System.Drawing.Point(191, 19);
            this.chkClick.Name = "chkClick";
            this.chkClick.Size = new System.Drawing.Size(71, 17);
            this.chkClick.TabIndex = 7;
            this.chkClick.Text = "AutoClick";
            this.chkClick.UseVisualStyleBackColor = true;
            // 
            // txtSpeed
            // 
            this.txtSpeed.AutoSize = true;
            this.txtSpeed.Location = new System.Drawing.Point(77, 87);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(49, 13);
            this.txtSpeed.TabIndex = 6;
            this.txtSpeed.Text = "txtSpeed";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(8, 87);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed (ms):";
            // 
            // tbMonitorSpeed
            // 
            this.tbMonitorSpeed.LargeChange = 10;
            this.tbMonitorSpeed.Location = new System.Drawing.Point(11, 103);
            this.tbMonitorSpeed.Maximum = 200;
            this.tbMonitorSpeed.Minimum = 1;
            this.tbMonitorSpeed.Name = "tbMonitorSpeed";
            this.tbMonitorSpeed.Size = new System.Drawing.Size(156, 45);
            this.tbMonitorSpeed.TabIndex = 4;
            this.tbMonitorSpeed.Value = 200;
            this.tbMonitorSpeed.ValueChanged += new System.EventHandler(this.tbMonitorSpeed_ValueChanged);
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.Location = new System.Drawing.Point(92, 19);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(75, 57);
            this.btnStopMonitoring.TabIndex = 3;
            this.btnStopMonitoring.Text = "Stop monitoring (F10)";
            this.btnStopMonitoring.UseVisualStyleBackColor = true;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.Location = new System.Drawing.Point(11, 19);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(75, 57);
            this.btnStartMonitoring.TabIndex = 2;
            this.btnStartMonitoring.Text = "Start monitoring (F9)";
            this.btnStartMonitoring.UseVisualStyleBackColor = true;
            this.btnStartMonitoring.Click += new System.EventHandler(this.btnStartMonitoring_Click);
            // 
            // grpReferenceImages
            // 
            this.grpReferenceImages.Controls.Add(this.btnRefreshList);
            this.grpReferenceImages.Controls.Add(this.lstImageList);
            this.grpReferenceImages.Controls.Add(this.btnSelectFolder);
            this.grpReferenceImages.Controls.Add(this.txtFolder);
            this.grpReferenceImages.Controls.Add(this.lblFolder);
            this.grpReferenceImages.Location = new System.Drawing.Point(411, 100);
            this.grpReferenceImages.Name = "grpReferenceImages";
            this.grpReferenceImages.Size = new System.Drawing.Size(227, 202);
            this.grpReferenceImages.TabIndex = 2;
            this.grpReferenceImages.TabStop = false;
            this.grpReferenceImages.Text = "Reference Images";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(191, 14);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(30, 23);
            this.btnRefreshList.TabIndex = 4;
            this.btnRefreshList.Text = "R";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lstImageList
            // 
            this.lstImageList.FormattingEnabled = true;
            this.lstImageList.Location = new System.Drawing.Point(6, 57);
            this.lstImageList.Name = "lstImageList";
            this.lstImageList.Size = new System.Drawing.Size(215, 134);
            this.lstImageList.TabIndex = 3;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(134, 14);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(51, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.AutoSize = true;
            this.txtFolder.Location = new System.Drawing.Point(10, 41);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(35, 13);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Text = "label1";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(10, 19);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(118, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Reference Image folder";
            // 
            // tmrClicker
            // 
            this.tmrClicker.Tick += new System.EventHandler(this.tmrClicker_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 314);
            this.Controls.Add(this.grpReferenceImages);
            this.Controls.Add(this.grpAreaPreview);
            this.Controls.Add(this.grpDesktopArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "ImageClicker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDesktopArea.ResumeLayout(false);
            this.grpDesktopArea.PerformLayout();
            this.grpAreaPreview.ResumeLayout(false);
            this.grpAreaPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorSpeed)).EndInit();
            this.grpReferenceImages.ResumeLayout(false);
            this.grpReferenceImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDesktopArea;
        private System.Windows.Forms.Label txtYstart;
        private System.Windows.Forms.Label txtXstart;
        private System.Windows.Forms.Label lblYstart;
        private System.Windows.Forms.Label lblXstart;
        private System.Windows.Forms.Label txtYend;
        private System.Windows.Forms.Label txtXend;
        private System.Windows.Forms.Label lblYend;
        private System.Windows.Forms.Label lblXend;
        private System.Windows.Forms.Button btnSetRectangle;
        private System.Windows.Forms.GroupBox grpAreaPreview;
        private System.Windows.Forms.Button btnStopMonitoring;
        private System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.TrackBar tbMonitorSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label txtSpeed;
        private System.Windows.Forms.GroupBox grpReferenceImages;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label txtFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ListBox lstImageList;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.CheckBox chkClick;
        private System.Windows.Forms.CheckBox chkScreens;
        private System.Windows.Forms.Timer tmrClicker;
        private System.Windows.Forms.Button btnResetGroup;
    }
}

