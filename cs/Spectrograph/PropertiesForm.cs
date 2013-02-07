using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spectrograph
{
    public partial class PropertiesForm : Form
    {
        static DisplayPalette[] PaletteComboBoxItems = { DisplayPalette.Green, DisplayPalette.Red, DisplayPalette.BlueReadWhite, DisplayPalette.Black };

        public CaptureProperties CaptureProperties
        {
            get { return GetFields(); }
            set { SetFields(value); }
        }

        private void SetFields(CaptureProperties props)
        {
            // general
            minFreqTextBox.Text = props.MinFrequency.ToString();
            maxFreqTextBox.Text = props.MaxFrequency.ToString();

            timeMarksCheckBox.Checked = props.IsSecondsMarked;
            markIntervalUpDown.Value = props.SecondMarkEvery;

            // values
            paletteComboBox.SelectedIndex = Array.IndexOf(
                PaletteComboBoxItems, props.Palette);

            if (props.DisplayMethod is LinearDisplayMethodFactory)
            {
                LinearDisplayMethodFactory dm = (LinearDisplayMethodFactory)props.DisplayMethod;
                linearRadioButton.Checked = true;
                linearScaleTextBox.Text = dm.Scale.ToString();
                linearOffsetTextBox.Text = dm.Offset.ToString();
            }
            else
            {
                Log10DisplayMethodFactory dm = props.DisplayMethod as Log10DisplayMethodFactory;
                if (dm == null) dm = new Log10DisplayMethodFactory();

                log10RadioButton.Checked = true;
                log10MinOrderTextBox.Text = dm.MinOrder.ToString();
                log10MaxOrderTextBox.Text = dm.MaxOrder.ToString();
            }
            UpdateValueMethodView();

            // marks
            marksListView.Items.Clear();
            foreach (FrequencyMark mark in props.FrequencyMarks)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mark.Frequency.ToString();
                item.SubItems.Add(mark.ColorName);
                item.SubItems.Add(mark.Label);
                marksListView.Items.Add(item);
            }

            // capture
            sampleRateComboBox.Text = props.SampleRate.ToString();
            windowTextBox.Text = props.Window.ToString();
            intervalTextBox.Text = props.Delta.ToString();
        }

        private void UpdateValueMethodView()
        {
            log10MinOrderTextBox.Enabled = log10RadioButton.Checked;
            log10MaxOrderTextBox.Enabled = log10RadioButton.Checked;
            linearScaleTextBox.Enabled = linearRadioButton.Checked;
            linearOffsetTextBox.Enabled = linearRadioButton.Checked;
        }

        private CaptureProperties GetFields()
        {
            CaptureProperties props = new CaptureProperties();
            // general
            Double.TryParse(minFreqTextBox.Text, out props.MinFrequency);
            Double.TryParse(maxFreqTextBox.Text, out props.MaxFrequency);
            props.IsSecondsMarked = timeMarksCheckBox.Checked;
            props.SecondMarkEvery = (int)markIntervalUpDown.Value;

            // values
            props.Palette = PaletteComboBoxItems[paletteComboBox.SelectedIndex];
            if (linearRadioButton.Checked)
            {
                LinearDisplayMethodFactory dm = new LinearDisplayMethodFactory();
                Double.TryParse(linearScaleTextBox.Text, out dm.Scale);
                Double.TryParse(linearOffsetTextBox.Text, out dm.Offset);
                props.DisplayMethod = dm;
            }
            else
            {
                Log10DisplayMethodFactory dm = new Log10DisplayMethodFactory();
                Double.TryParse(log10MinOrderTextBox.Text, out dm.MinOrder);
                Double.TryParse(log10MaxOrderTextBox.Text, out dm.MaxOrder);
                props.DisplayMethod = dm;
            }

            // marks
            foreach (ListViewItem item in marksListView.Items)
            {
                FrequencyMark mark = new FrequencyMark();
                Double.TryParse(item.Text, out mark.Frequency);
                mark.ColorName = item.SubItems[1].Text;
                mark.Label = item.SubItems[2].Text;
                props.FrequencyMarks.Add(mark);
            }

            // capture
            Int32.TryParse(sampleRateComboBox.Text, out props.SampleRate);
            Int32.TryParse(windowTextBox.Text, out props.Window);
            Int32.TryParse(intervalTextBox.Text, out props.Delta);

            return props;
        }

        public PropertiesForm()
        {
            InitializeComponent();
            InitializeValueDisplayMethods();
        }

        private void addFreqButton_Click(object sender, EventArgs e)
        {
            using (AddFrequencyForm form = new AddFrequencyForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = form.Frequency.ToString();
                    item.SubItems.Add(form.MarkColor.Name);
                    item.SubItems.Add(form.MarkLabel);
                    marksListView.Items.Add(item);
                }
            }
        }

        private void log10RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateValueMethodView();
        }

        private void linearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateValueMethodView();
        }

        private void deleteFreqButton_Click(object sender, EventArgs e)
        {
            int[] indices = new int[marksListView.SelectedIndices.Count];
            marksListView.SelectedIndices.CopyTo(indices, 0);
            Array.Sort(indices);

            for (int i = indices.Length - 1; i >= 0; i--)
            {
                marksListView.Items.RemoveAt(indices[i]);
            }
        }

        private void sampleRateComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCaptureInfo();
        }

        private void windowTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCaptureInfo();
        }

        private void intervalTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCaptureInfo();
        }

        private void UpdateCaptureInfo()
        {
            int sampleRate, window, delta;
            Int32.TryParse(sampleRateComboBox.Text, out sampleRate);
            Int32.TryParse(windowTextBox.Text, out window);
            Int32.TryParse(intervalTextBox.Text, out delta);

            double rateSec = (double)delta / sampleRate;
            double maxFreq = sampleRate;
            int nextWindowPowerOfTwo = 1;
            while (window > nextWindowPowerOfTwo) 
                nextWindowPowerOfTwo <<= 1;
            double acc = (double)sampleRate / nextWindowPowerOfTwo;

            captureInfoLabel.Text = String.Format("FFT will analize data every {0:f2}s with resolution {2:f2} Hz and covers frequencies from 0 to {1:n1} Hz ",
                rateSec, maxFreq / 2, acc);
        }

        private void InitializeValueDisplayMethods()
        {
            Log10DisplayMethodFactory log10 = new Log10DisplayMethodFactory();
            log10MinOrderTextBox.Text = log10.MinOrder.ToString();
            log10MaxOrderTextBox.Text = log10.MaxOrder.ToString();
            LinearDisplayMethodFactory linear = new LinearDisplayMethodFactory();
            linearScaleTextBox.Text = linear.Scale.ToString("g");
            linearScaleTextBox.Text = linear.Offset.ToString("g");
        }
    }
}
