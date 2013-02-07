namespace Spectrograph
{
    partial class MainForm
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
            this.spectrPictureBox = new System.Windows.Forms.PictureBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.secondsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.freqToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.deviceToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activityToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSpectrogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.volumeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spectrPictureBox)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // spectrPictureBox
            // 
            this.spectrPictureBox.BackColor = System.Drawing.Color.Black;
            this.spectrPictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.spectrPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrPictureBox.Location = new System.Drawing.Point(0, 24);
            this.spectrPictureBox.Name = "spectrPictureBox";
            this.spectrPictureBox.Size = new System.Drawing.Size(432, 227);
            this.spectrPictureBox.TabIndex = 0;
            this.spectrPictureBox.TabStop = false;
            this.spectrPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spectrPictureBox_MouseMove);
            this.spectrPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.spectrPictureBox_Paint);
            this.spectrPictureBox.ClientSizeChanged += new System.EventHandler(this.spectrPictureBox_ClientSizeChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondsToolStripStatusLabel,
            this.freqToolStripStatusLabel,
            this.deviceToolStripStatusLabel,
            this.activityToolStripProgressBar});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 251);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(432, 22);
            this.mainStatusStrip.TabIndex = 1;
            // 
            // secondsToolStripStatusLabel
            // 
            this.secondsToolStripStatusLabel.AutoSize = false;
            this.secondsToolStripStatusLabel.Name = "secondsToolStripStatusLabel";
            this.secondsToolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
            this.secondsToolStripStatusLabel.ToolTipText = "Time";
            // 
            // freqToolStripStatusLabel
            // 
            this.freqToolStripStatusLabel.AutoSize = false;
            this.freqToolStripStatusLabel.Name = "freqToolStripStatusLabel";
            this.freqToolStripStatusLabel.Size = new System.Drawing.Size(75, 17);
            this.freqToolStripStatusLabel.ToolTipText = "Frequency";
            // 
            // deviceToolStripStatusLabel
            // 
            this.deviceToolStripStatusLabel.AutoSize = false;
            this.deviceToolStripStatusLabel.Name = "deviceToolStripStatusLabel";
            this.deviceToolStripStatusLabel.Size = new System.Drawing.Size(200, 17);
            this.deviceToolStripStatusLabel.ToolTipText = "Selected Capture Device";
            // 
            // activityToolStripProgressBar
            // 
            this.activityToolStripProgressBar.Name = "activityToolStripProgressBar";
            this.activityToolStripProgressBar.Size = new System.Drawing.Size(50, 16);
            this.activityToolStripProgressBar.ToolTipText = "Activity indicator";
            this.activityToolStripProgressBar.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.captureToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(432, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSpectrogramToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newSpectrogramToolStripMenuItem
            // 
            this.newSpectrogramToolStripMenuItem.Name = "newSpectrogramToolStripMenuItem";
            this.newSpectrogramToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newSpectrogramToolStripMenuItem.Text = "&New...";
            this.newSpectrogramToolStripMenuItem.Click += new System.EventHandler(this.newSpectrogramToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyToToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyToToolStripMenuItem
            // 
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            this.copyToToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.copyToToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToToolStripMenuItem.Text = "Copy to...";
            this.copyToToolStripMenuItem.Click += new System.EventHandler(this.copyToToolStripMenuItem_Click);
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem3,
            this.propertiesToolStripMenuItem});
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.captureToolStripMenuItem.Text = "&Capture";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deviceToolStripMenuItem.Text = "&Device";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.stopToolStripMenuItem.Text = "S&top";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.propertiesToolStripMenuItem.Text = "&Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webSiteToolStripMenuItem,
            this.toolStripMenuItem5,
            this.volumeControlToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // webSiteToolStripMenuItem
            // 
            this.webSiteToolStripMenuItem.Name = "webSiteToolStripMenuItem";
            this.webSiteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.webSiteToolStripMenuItem.Text = "Web Site...";
            this.webSiteToolStripMenuItem.Click += new System.EventHandler(this.webSiteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(166, 6);
            // 
            // volumeControlToolStripMenuItem
            // 
            this.volumeControlToolStripMenuItem.Name = "volumeControlToolStripMenuItem";
            this.volumeControlToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.volumeControlToolStripMenuItem.Text = "Volume Control...";
            this.volumeControlToolStripMenuItem.Click += new System.EventHandler(this.volumeControlToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // copySaveFileDialog
            // 
            this.copySaveFileDialog.DefaultExt = "png";
            this.copySaveFileDialog.Filter = "PNG files|*.png|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Spectr files|*.spectr|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "spectr";
            this.saveFileDialog.Filter = "Spectr files|*.spectr|All files|*.*";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.welcomeLabel.Location = new System.Drawing.Point(77, 117);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(294, 34);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Press \'F5\' or select Capture->Start to start sound capture.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 273);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.spectrPictureBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spectrPictureBox)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spectrPictureBox;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel secondsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel freqToolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSpectrogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel deviceToolStripStatusLabel;
        private System.Windows.Forms.SaveFileDialog copySaveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripProgressBar activityToolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem webSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem volumeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Label welcomeLabel;

    }
}

