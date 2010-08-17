using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundCapture;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace Spectrograph
{
    public partial class MainForm : Form
    {
        const string FormTitle = "Spectrograph";
        const int MarkOpacity = 64;
 
        CachedImageCollection cachedImages;
        CapturedSoundInfoSource source;
        CaptureProperties properties;
        DisplayMethod displayMethod;
        Color[] colors;

        string filename = null;
        bool modified = true;
        bool startCaptioning = false;

        public MainForm()
        {
            InitializeComponent();

            cachedImages = new CachedImageCollection();
            UpdateMenu();

            ParseArguments();
            this.Icon = Properties.Resources.app;
        }

        bool isCapturing = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDevices();

            InitializeCaptureProperties();

            SetupDisplay();

            if (startCaptioning)
            {
                StartCapture();
            }
        }

        private void InitializeCaptureProperties()
        {
            properties = CapturePropertiesUtils.CreateDefaultCaptureProperties();
            if (!String.IsNullOrEmpty(filename))
            {
                LoadProperties(filename);
            }

            UpdateTitle();
        }

        private void StartCapture()
        {
            welcomeLabel.Visible = false;

            try
            {
                SetupDisplay();

                SoundCaptureDevice device = GetSelectedCaptureDevice();

                source = new CapturedSoundInfoSource(device);
                source.SampleRate = properties.SampleRate;
                source.Window = properties.Window;
                source.Delta = properties.Delta;
                source.SpectrographData += new EventHandler<SpectrographDataEventArgs>(source_SpectrographData);
                source.Listen();
                
                isCapturing = true;

                UpdateMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to start capture: " + ex.Message);
            }
        }

        private void SetupDisplay()
        {
            cachedImages.Clear();
            displayMethod = properties.DisplayMethod.CreateDisplayMethod();

            switch (properties.Palette)
            {
                case DisplayPalette.BlueReadWhite:
                    colors = ColorPalettes.BlueToRedToWhite;
                    break;
                case DisplayPalette.Red:
                    colors = ColorPalettes.RedValue;
                    break;
                case DisplayPalette.Black:
                    colors = ColorPalettes.WhiteToBlack;
                    break;
                default:
                case DisplayPalette.Green:
                    colors = ColorPalettes.GreenValue;
                    break;
            }

            Refresh();
        }

        private void UpdateMenu()
        {
            // file

            // capture
            deviceToolStripMenuItem.Enabled = !isCapturing;
            startToolStripMenuItem.Enabled = !isCapturing;
            stopToolStripMenuItem.Enabled = isCapturing;
            propertiesToolStripMenuItem.Enabled = !isCapturing;

            // misc
            activityToolStripProgressBar.Visible = isCapturing;
        }

        private void LoadDevices()
        {
            deviceToolStripMenuItem.DropDownItems.Clear();

            SoundCaptureDevice[] devices = SoundCaptureDevice.GetDevices();
            // LoaderLock?!  
            //   Goto Debug->Exceptions... 
            //   then find Managed Debugging Assistants->LoaderLock and uncheck it

            foreach (SoundCaptureDevice device in devices)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = device.Name;
                item.Checked = device.IsDefault;
                item.Tag = device;
                item.Click += new EventHandler(deviceToolStripItem_Click);
                deviceToolStripMenuItem.DropDownItems.Add(item);
            }

            UpdateDeviceView();
        }

        void deviceToolStripItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in deviceToolStripMenuItem.DropDownItems)
            {
                item.Checked = item == sender;
            }
            UpdateDeviceView();
        }

        private SoundCaptureDevice GetSelectedCaptureDevice()
        {
            foreach (ToolStripMenuItem item in deviceToolStripMenuItem.DropDownItems)
            {
                return (SoundCaptureDevice)item.Tag;
            }
            return null;
        }

        private void UpdateDeviceView()
        {
            foreach (ToolStripMenuItem item in deviceToolStripMenuItem.DropDownItems)
            {
                if (item.Checked)
                {
                    deviceToolStripStatusLabel.Text = item.Text;
                }
            }
        }

        void source_SpectrographData(object sender, SpectrographDataEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<SpectrographDataEventArgs>(source_SpectrographData), sender, e);
                return;
            }

            cachedImages.Add(CreateImage(e.Data));

            spectrPictureBox.Invalidate();

            if (activityToolStripProgressBar.Value < activityToolStripProgressBar.Maximum)
                activityToolStripProgressBar.Value++;
            else
                activityToolStripProgressBar.Value = 0;
        }

        private Bitmap CreateImage(double[] data)
        {
            int halfHeight = (data.Length + 1) / 2;
            Bitmap image;
            using (Graphics g = CreateGraphics())
                image = new Bitmap(1, halfHeight, g);

            int[] colorIndices = new int[halfHeight];
            displayMethod.Quiantize(data, colors.Length - 1, colorIndices); 

            for (int j = 0; j < colorIndices.Length; j++)
            {
                image.SetPixel(0, j, colors[colorIndices[j]]);
            }
            return image;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!EnsureNotBusy())
            //{
            //    e.Cancel = true;
            //    return;
            //}

            if (isCapturing)
            {
                StopCapture();
            }

            cachedImages.Dispose();
        }

        private void StopCapture()
        {
            source.Stop();
            source.SpectrographData -= new EventHandler<SpectrographDataEventArgs>(source_SpectrographData);
            source = null;

            isCapturing = false;
            UpdateMenu();
        }

        private double BacketToFrequencyMultiplier
        {
            get { return (double)properties.SampleRate / properties.Window; }
        }

        private void GetMinAndMaxFrequencyBacket(out int minFreqBacket, out int maxFreqBacket)
        {
            minFreqBacket = (int)Math.Floor(properties.MinFrequency / BacketToFrequencyMultiplier);
            maxFreqBacket = (int)Math.Ceiling(properties.MaxFrequency / BacketToFrequencyMultiplier);
        }

        private Bitmap GenerateView(int width, int height, Graphics g)
        {
            int minFreqBacket, maxFreqBacket;
            GetMinAndMaxFrequencyBacket(out minFreqBacket, out maxFreqBacket);

            Bitmap bmp;
            if(g == null)
                bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            else
                bmp = new Bitmap(width, height, g);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.FillRectangle(new SolidBrush(colors[0]), 0, 0, bmp.Width, bmp.Height);
                int position = bmp.Width;
                foreach (Bitmap image in cachedImages.GetImages())
                {
                    position -= image.Width;
                    Rectangle r = new Rectangle(position, 0, image.Width, bmp.Height);

                    graphics.DrawImage(image, r,
                        0, minFreqBacket, image.Width, maxFreqBacket - minFreqBacket + 1,
                        GraphicsUnit.Pixel);

                    if (position < 0) break;
                }

                foreach (FrequencyMark mark in properties.FrequencyMarks)
                {
                    int y = (int)Math.Round((mark.Frequency - properties.MinFrequency) *
                        bmp.Height / (properties.MaxFrequency - properties.MinFrequency));
                    Color markColor = Color.FromName(mark.ColorName);
                    graphics.DrawLine(new Pen(Color.FromArgb(MarkOpacity, markColor)), 0, y, bmp.Width, y);
                }

                if (properties.IsSecondsMarked)
                {
                    int secondMarkCount = (int)(bmp.Width * PixelsToSecondsCoefficient);
                    Color markColor = Color.FromArgb(MarkOpacity, Color.Cyan);
                    Pen markPen = new Pen(markColor);
                    for (int i = 0; i < secondMarkCount; i++)
                    {
                        int x = (int)(bmp.Width - (i + 1) / PixelsToSecondsCoefficient);
                        graphics.DrawLine(markPen, x, 0, x, bmp.Height);
                    }
                }
            }
            return bmp;
        }

        private void spectrPictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (Bitmap bmp = GenerateView(spectrPictureBox.Width, spectrPictureBox.Height, e.Graphics))
            {
                e.Graphics.DrawImageUnscaled(bmp, 0, 0);
            }
        }

        private double PixelsToSecondsCoefficient
        {
            get { return (double)properties.Delta / properties.SampleRate; }
        }

        private void spectrPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            int seconds = (spectrPictureBox.ClientRectangle.Right - e.X) * 
                properties.Delta / properties.SampleRate;
            secondsToolStripStatusLabel.Text = String.Format("-{0}:{1:00}",
                seconds / 60, seconds % 60);


            int minFreqBacket, maxFreqBacket;
            GetMinAndMaxFrequencyBacket(out minFreqBacket, out maxFreqBacket);

            int backet = e.Y * (maxFreqBacket - minFreqBacket + 1) / spectrPictureBox.Height + minFreqBacket;
            double freq = backet * BacketToFrequencyMultiplier;

            freqToolStripStatusLabel.Text = String.Format("{0:f2} Hz", freq);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox form = new AboutBox())
                form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProperties();
        }

        private void EditProperties()
        {
            using (PropertiesForm form = new PropertiesForm())
            {
                form.CaptureProperties = properties;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    properties = form.CaptureProperties;

                    modified = true;
                    UpdateTitle();

                    SetupDisplay();
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap spectr = GenerateView(spectrPictureBox.Width, spectrPictureBox.Height, null);
            Clipboard.SetDataObject(spectr);
        }

        private void copyToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap spectr = GenerateView(spectrPictureBox.Width, spectrPictureBox.Height, null))
            {
                if (copySaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    spectr.Save(copySaveFileDialog.FileName, ImageFormat.Png);
                }
                
            }
        }

        private bool EnsureNotBusy()
        {
            if (isCapturing)
            {
                if(MessageBox.Show("The sound capture and analysis is in process.\r\nDo you want to stop the capture?",
                    "Capture is in process",  MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StopCapture();
                    return true;
                }
                else
                    return false;
            }
            else
                return true;
        }

        private void newSpectrogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureNotBusy()) return;

            properties = CapturePropertiesUtils.CreateDefaultCaptureProperties();
            EditProperties();

            modified = true;
            filename = null;

            UpdateTitle();
        }

        private void UpdateTitle()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FormTitle);
            if (!String.IsNullOrEmpty(filename))
            {
                sb.Append(" - ").Append(Path.GetFileName(filename));
            }
            if (modified)
                sb.Append(" *");
            this.Text = sb.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EnsureNotBusy()) return;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadProperties(openFileDialog.FileName);

                UpdateTitle();
            }
        }

        private void LoadProperties(string filename)
        {
            try
            {
                properties = CapturePropertiesUtils.LoadCaptureProperties(filename);

                this.filename = filename;
                modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == null)
            {
                saveAsToolStripMenuItem_Click(sender, e); return;
            }

            SaveProperties();
            UpdateTitle();
        }

        private void SaveProperties()
        {
            try
            {
                CapturePropertiesUtils.SaveCaptureProperties(filename, properties);

                modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;

                SaveProperties();
                UpdateTitle();
            }
        }

        private void ParseArguments()
        {
            List<string> arguments = new List<string>();
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                switch (arg.ToLowerInvariant())
                {
                    case "-start":
                        startCaptioning = true;
                        break;
                    default:
                        arguments.Add(arg);
                        break;
                }
            }

            arguments.RemoveAt(0);
            if (arguments.Count > 0)
            {
                filename = arguments[0];
            }
        }

        private void spectrPictureBox_ClientSizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void volumeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("sndvol32.exe", "/R");
        }

        private void webSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.codeplex.com/livefft");
        }
    }
}
