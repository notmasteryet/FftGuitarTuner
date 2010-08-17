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
    public partial class AddFrequencyForm : Form
    {
        public double Frequency
        {
            get
            {
                double value;
                double.TryParse(freqTextBox.Text, out value);
                return value;
            }
        }

        public string MarkLabel
        {
            get { return labelTextBox.Text; }
        }

        public Color MarkColor
        {
            get
            {
                try
                {
                    return Color.FromName(colorComboBox.Text);
                }
                catch
                {
                    return colorDialog.Color;
                }
            }
        }

        public AddFrequencyForm()
        {
            InitializeComponent();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog.Color = Color.FromName(colorComboBox.Text);
            }
            catch 
            {
                colorComboBox.Text = colorDialog.Color.Name;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorComboBox.Text = colorDialog.Color.Name;
            }
        }
    }
}
