namespace Spectrograph
{
    partial class PropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.minFreqTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxFreqTextBox = new System.Windows.Forms.TextBox();
            this.log10RadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.log10MinOrderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.log10MaxOrderTextBox = new System.Windows.Forms.TextBox();
            this.linearRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.linearScaleTextBox = new System.Windows.Forms.TextBox();
            this.propertiesTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.markIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.timeMarksCheckBox = new System.Windows.Forms.CheckBox();
            this.valueDisplayTabPage = new System.Windows.Forms.TabPage();
            this.paletteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linearOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.marksTabPage = new System.Windows.Forms.TabPage();
            this.deleteFreqButton = new System.Windows.Forms.Button();
            this.addFreqButton = new System.Windows.Forms.Button();
            this.marksListView = new System.Windows.Forms.ListView();
            this.freqColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.colorColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.labelColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.captureTabPage = new System.Windows.Forms.TabPage();
            this.captureInfoLabel = new System.Windows.Forms.Label();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.windowTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sampleRateComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.propertiesTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markIntervalUpDown)).BeginInit();
            this.valueDisplayTabPage.SuspendLayout();
            this.marksTabPage.SuspendLayout();
            this.captureTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimal Frequency: ";
            // 
            // minFreqTextBox
            // 
            this.minFreqTextBox.Location = new System.Drawing.Point(123, 10);
            this.minFreqTextBox.Name = "minFreqTextBox";
            this.minFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.minFreqTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Frequency:";
            // 
            // maxFreqTextBox
            // 
            this.maxFreqTextBox.Location = new System.Drawing.Point(123, 39);
            this.maxFreqTextBox.Name = "maxFreqTextBox";
            this.maxFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxFreqTextBox.TabIndex = 3;
            // 
            // log10RadioButton
            // 
            this.log10RadioButton.AutoSize = true;
            this.log10RadioButton.Location = new System.Drawing.Point(9, 51);
            this.log10RadioButton.Name = "log10RadioButton";
            this.log10RadioButton.Size = new System.Drawing.Size(58, 17);
            this.log10RadioButton.TabIndex = 2;
            this.log10RadioButton.TabStop = true;
            this.log10RadioButton.Text = "Log 10";
            this.log10RadioButton.UseVisualStyleBackColor = true;
            this.log10RadioButton.CheckedChanged += new System.EventHandler(this.log10RadioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Order:";
            // 
            // log10MinOrderTextBox
            // 
            this.log10MinOrderTextBox.Location = new System.Drawing.Point(88, 68);
            this.log10MinOrderTextBox.Name = "log10MinOrderTextBox";
            this.log10MinOrderTextBox.Size = new System.Drawing.Size(40, 20);
            this.log10MinOrderTextBox.TabIndex = 4;
            this.log10MinOrderTextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Order:";
            // 
            // log10MaxOrderTextBox
            // 
            this.log10MaxOrderTextBox.Location = new System.Drawing.Point(199, 68);
            this.log10MaxOrderTextBox.Name = "log10MaxOrderTextBox";
            this.log10MaxOrderTextBox.Size = new System.Drawing.Size(40, 20);
            this.log10MaxOrderTextBox.TabIndex = 6;
            this.log10MaxOrderTextBox.Text = "15";
            // 
            // linearRadioButton
            // 
            this.linearRadioButton.AutoSize = true;
            this.linearRadioButton.Location = new System.Drawing.Point(9, 100);
            this.linearRadioButton.Name = "linearRadioButton";
            this.linearRadioButton.Size = new System.Drawing.Size(54, 17);
            this.linearRadioButton.TabIndex = 7;
            this.linearRadioButton.TabStop = true;
            this.linearRadioButton.Text = "Linear";
            this.linearRadioButton.UseVisualStyleBackColor = true;
            this.linearRadioButton.CheckedChanged += new System.EventHandler(this.linearRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Scale:";
            // 
            // linearScaleTextBox
            // 
            this.linearScaleTextBox.Location = new System.Drawing.Point(69, 118);
            this.linearScaleTextBox.Name = "linearScaleTextBox";
            this.linearScaleTextBox.Size = new System.Drawing.Size(100, 20);
            this.linearScaleTextBox.TabIndex = 9;
            this.linearScaleTextBox.Text = "1.0e+15";
            // 
            // propertiesTabControl
            // 
            this.propertiesTabControl.Controls.Add(this.generalTabPage);
            this.propertiesTabControl.Controls.Add(this.valueDisplayTabPage);
            this.propertiesTabControl.Controls.Add(this.marksTabPage);
            this.propertiesTabControl.Controls.Add(this.captureTabPage);
            this.propertiesTabControl.Location = new System.Drawing.Point(10, 12);
            this.propertiesTabControl.Name = "propertiesTabControl";
            this.propertiesTabControl.SelectedIndex = 0;
            this.propertiesTabControl.Size = new System.Drawing.Size(341, 181);
            this.propertiesTabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.markIntervalUpDown);
            this.generalTabPage.Controls.Add(this.label6);
            this.generalTabPage.Controls.Add(this.timeMarksCheckBox);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Controls.Add(this.minFreqTextBox);
            this.generalTabPage.Controls.Add(this.label2);
            this.generalTabPage.Controls.Add(this.maxFreqTextBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(333, 155);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // markIntervalUpDown
            // 
            this.markIntervalUpDown.Location = new System.Drawing.Point(123, 88);
            this.markIntervalUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.markIntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markIntervalUpDown.Name = "markIntervalUpDown";
            this.markIntervalUpDown.Size = new System.Drawing.Size(100, 20);
            this.markIntervalUpDown.TabIndex = 6;
            this.markIntervalUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mark Every (seconds)";
            // 
            // timeMarksCheckBox
            // 
            this.timeMarksCheckBox.AutoSize = true;
            this.timeMarksCheckBox.Location = new System.Drawing.Point(9, 70);
            this.timeMarksCheckBox.Name = "timeMarksCheckBox";
            this.timeMarksCheckBox.Size = new System.Drawing.Size(111, 17);
            this.timeMarksCheckBox.TabIndex = 4;
            this.timeMarksCheckBox.Text = "Show Time Marks";
            this.timeMarksCheckBox.UseVisualStyleBackColor = true;
            // 
            // valueDisplayTabPage
            // 
            this.valueDisplayTabPage.Controls.Add(this.paletteComboBox);
            this.valueDisplayTabPage.Controls.Add(this.label8);
            this.valueDisplayTabPage.Controls.Add(this.linearOffsetTextBox);
            this.valueDisplayTabPage.Controls.Add(this.label7);
            this.valueDisplayTabPage.Controls.Add(this.linearScaleTextBox);
            this.valueDisplayTabPage.Controls.Add(this.log10RadioButton);
            this.valueDisplayTabPage.Controls.Add(this.label5);
            this.valueDisplayTabPage.Controls.Add(this.label3);
            this.valueDisplayTabPage.Controls.Add(this.linearRadioButton);
            this.valueDisplayTabPage.Controls.Add(this.label4);
            this.valueDisplayTabPage.Controls.Add(this.log10MaxOrderTextBox);
            this.valueDisplayTabPage.Controls.Add(this.log10MinOrderTextBox);
            this.valueDisplayTabPage.Location = new System.Drawing.Point(4, 22);
            this.valueDisplayTabPage.Name = "valueDisplayTabPage";
            this.valueDisplayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.valueDisplayTabPage.Size = new System.Drawing.Size(333, 155);
            this.valueDisplayTabPage.TabIndex = 1;
            this.valueDisplayTabPage.Text = "Value Display";
            this.valueDisplayTabPage.UseVisualStyleBackColor = true;
            // 
            // paletteComboBox
            // 
            this.paletteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paletteComboBox.FormattingEnabled = true;
            this.paletteComboBox.Items.AddRange(new object[] {
            "Green Value",
            "Red Value",
            "Blue/Red/White",
            "White/Black"});
            this.paletteComboBox.Location = new System.Drawing.Point(97, 14);
            this.paletteComboBox.Name = "paletteComboBox";
            this.paletteComboBox.Size = new System.Drawing.Size(121, 21);
            this.paletteComboBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Color Palette:";
            // 
            // linearOffsetTextBox
            // 
            this.linearOffsetTextBox.Location = new System.Drawing.Point(219, 118);
            this.linearOffsetTextBox.Name = "linearOffsetTextBox";
            this.linearOffsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.linearOffsetTextBox.TabIndex = 11;
            this.linearOffsetTextBox.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Offset:";
            // 
            // marksTabPage
            // 
            this.marksTabPage.Controls.Add(this.deleteFreqButton);
            this.marksTabPage.Controls.Add(this.addFreqButton);
            this.marksTabPage.Controls.Add(this.marksListView);
            this.marksTabPage.Location = new System.Drawing.Point(4, 22);
            this.marksTabPage.Name = "marksTabPage";
            this.marksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.marksTabPage.Size = new System.Drawing.Size(333, 155);
            this.marksTabPage.TabIndex = 2;
            this.marksTabPage.Text = "Frequency Marks";
            this.marksTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteFreqButton
            // 
            this.deleteFreqButton.Location = new System.Drawing.Point(89, 6);
            this.deleteFreqButton.Name = "deleteFreqButton";
            this.deleteFreqButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFreqButton.TabIndex = 1;
            this.deleteFreqButton.Text = "Delete";
            this.deleteFreqButton.UseVisualStyleBackColor = true;
            this.deleteFreqButton.Click += new System.EventHandler(this.deleteFreqButton_Click);
            // 
            // addFreqButton
            // 
            this.addFreqButton.Location = new System.Drawing.Point(7, 7);
            this.addFreqButton.Name = "addFreqButton";
            this.addFreqButton.Size = new System.Drawing.Size(75, 23);
            this.addFreqButton.TabIndex = 0;
            this.addFreqButton.Text = "Add...";
            this.addFreqButton.UseVisualStyleBackColor = true;
            this.addFreqButton.Click += new System.EventHandler(this.addFreqButton_Click);
            // 
            // marksListView
            // 
            this.marksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.freqColumnHeader,
            this.colorColumnHeader,
            this.labelColumnHeader});
            this.marksListView.Location = new System.Drawing.Point(7, 39);
            this.marksListView.Name = "marksListView";
            this.marksListView.Size = new System.Drawing.Size(320, 110);
            this.marksListView.TabIndex = 2;
            this.marksListView.UseCompatibleStateImageBehavior = false;
            this.marksListView.View = System.Windows.Forms.View.Details;
            // 
            // freqColumnHeader
            // 
            this.freqColumnHeader.Text = "Frequency";
            this.freqColumnHeader.Width = 100;
            // 
            // colorColumnHeader
            // 
            this.colorColumnHeader.Text = "Color";
            this.colorColumnHeader.Width = 73;
            // 
            // labelColumnHeader
            // 
            this.labelColumnHeader.Text = "Label";
            this.labelColumnHeader.Width = 81;
            // 
            // captureTabPage
            // 
            this.captureTabPage.Controls.Add(this.captureInfoLabel);
            this.captureTabPage.Controls.Add(this.intervalTextBox);
            this.captureTabPage.Controls.Add(this.label11);
            this.captureTabPage.Controls.Add(this.windowTextBox);
            this.captureTabPage.Controls.Add(this.label10);
            this.captureTabPage.Controls.Add(this.sampleRateComboBox);
            this.captureTabPage.Controls.Add(this.label9);
            this.captureTabPage.Location = new System.Drawing.Point(4, 22);
            this.captureTabPage.Name = "captureTabPage";
            this.captureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.captureTabPage.Size = new System.Drawing.Size(333, 155);
            this.captureTabPage.TabIndex = 3;
            this.captureTabPage.Text = "Capture";
            this.captureTabPage.UseVisualStyleBackColor = true;
            // 
            // captureInfoLabel
            // 
            this.captureInfoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.captureInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureInfoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.captureInfoLabel.Location = new System.Drawing.Point(12, 103);
            this.captureInfoLabel.Name = "captureInfoLabel";
            this.captureInfoLabel.Size = new System.Drawing.Size(305, 38);
            this.captureInfoLabel.TabIndex = 6;
            this.captureInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(134, 70);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.intervalTextBox.TabIndex = 5;
            this.intervalTextBox.TextChanged += new System.EventHandler(this.intervalTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Interval (samples):";
            // 
            // windowTextBox
            // 
            this.windowTextBox.Location = new System.Drawing.Point(134, 42);
            this.windowTextBox.Name = "windowTextBox";
            this.windowTextBox.Size = new System.Drawing.Size(100, 20);
            this.windowTextBox.TabIndex = 3;
            this.windowTextBox.TextChanged += new System.EventHandler(this.windowTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Window Size (samples):";
            // 
            // sampleRateComboBox
            // 
            this.sampleRateComboBox.FormattingEnabled = true;
            this.sampleRateComboBox.Items.AddRange(new object[] {
            "8000",
            "11025",
            "12000",
            "16000",
            "22050",
            "24000",
            "32000",
            "44100",
            "48000"});
            this.sampleRateComboBox.Location = new System.Drawing.Point(134, 12);
            this.sampleRateComboBox.Name = "sampleRateComboBox";
            this.sampleRateComboBox.Size = new System.Drawing.Size(100, 21);
            this.sampleRateComboBox.TabIndex = 1;
            this.sampleRateComboBox.TextChanged += new System.EventHandler(this.sampleRateComboBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sample Rate:";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(92, 206);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(195, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PropertiesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(358, 241);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.propertiesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capture Properties...";
            this.propertiesTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markIntervalUpDown)).EndInit();
            this.valueDisplayTabPage.ResumeLayout(false);
            this.valueDisplayTabPage.PerformLayout();
            this.marksTabPage.ResumeLayout(false);
            this.captureTabPage.ResumeLayout(false);
            this.captureTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minFreqTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxFreqTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton linearRadioButton;
        private System.Windows.Forms.TextBox log10MaxOrderTextBox;
        private System.Windows.Forms.TextBox log10MinOrderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton log10RadioButton;
        private System.Windows.Forms.TextBox linearScaleTextBox;
        private System.Windows.Forms.TabControl propertiesTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage valueDisplayTabPage;
        private System.Windows.Forms.CheckBox timeMarksCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox paletteComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox linearOffsetTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown markIntervalUpDown;
        private System.Windows.Forms.TabPage marksTabPage;
        private System.Windows.Forms.TabPage captureTabPage;
        private System.Windows.Forms.ComboBox sampleRateComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox windowTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteFreqButton;
        private System.Windows.Forms.Button addFreqButton;
        private System.Windows.Forms.ListView marksListView;
        private System.Windows.Forms.ColumnHeader freqColumnHeader;
        private System.Windows.Forms.ColumnHeader colorColumnHeader;
        private System.Windows.Forms.ColumnHeader labelColumnHeader;
        private System.Windows.Forms.Label captureInfoLabel;
    }
}