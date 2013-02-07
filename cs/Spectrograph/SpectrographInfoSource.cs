using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectrograph
{
    public abstract class SpectrographInfoSource
    {
        const int DefaultSampleRate = 44100;
        const int DefaultWindow = 1 << 14;
        const int DefaultDelta = DefaultWindow * 3 / 4;

        int sampleRate = DefaultSampleRate;

        public int SampleRate
        {
            get { return sampleRate; }
            set { sampleRate = value; }
        }

        int window = DefaultWindow;

        public int Window
        {
            get { return window; }
            set { window = value; }
        }

        int delta = DefaultDelta;

        public int Delta
        {
            get { return delta; }
            set { delta = value; }
        }

        public abstract void Listen();
        public abstract void Stop();
        public event EventHandler<SpectrographDataEventArgs> SpectrographData;

        protected virtual void OnSpectrographData(SpectrographDataEventArgs e)
        {
            if (SpectrographData != null)
            {
                SpectrographData(this, e);
            }
        }
    }

    public class SpectrographDataEventArgs : EventArgs
    {
        double[] data;

        public double[] Data
        {
            get { return data; }
        }

        public SpectrographDataEventArgs(double[] data)
        {
            this.data = data;
        }
    }
}
