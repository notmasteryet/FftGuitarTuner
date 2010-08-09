using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundCapture;

namespace FftGuitarTuner
{
    public partial class SelectDeviceForm : Form
    {
        SoundCaptureDevice[] devices;

        public SoundCaptureDevice SelectedDevice
        {
            get { return devices[deviceNamesListBox.SelectedIndex]; }
        }

        public SelectDeviceForm()
        {
            InitializeComponent();
        }

        private void SelectDeviceForm_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            deviceNamesListBox.Items.Clear();

            int defaultDeviceIndex = 0;
            
            devices = SoundCaptureDevice.GetDevices();
            for (int i = 0; i < devices.Length; i++)
            {
                deviceNamesListBox.Items.Add(devices[i].Name);
                if (devices[i].IsDefault)
                    defaultDeviceIndex = i;
            }

            deviceNamesListBox.SelectedIndex = defaultDeviceIndex;
        }

        private void deviceNamesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (deviceNamesListBox.SelectedIndex < 0) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
