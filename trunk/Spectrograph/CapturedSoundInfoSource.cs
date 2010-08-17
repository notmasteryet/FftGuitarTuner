using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoundCapture;
using SoundAnalysis;

namespace Spectrograph
{

    class CapturedSoundInfoSource : SpectrographInfoSource
    {
        SoundCaptureDevice device;
        Adapter adapter;

        internal CapturedSoundInfoSource(SoundCaptureDevice device)
        {
            this.device = device;
        }

        const int DefaultNotifyPointsInSecond = 8;

        public override void Listen()
        {
            if (Window < Delta) throw new InvalidOperationException("Window is less than Delta");

            adapter = new Adapter(this, device, Window, Delta);
            adapter.SampleRate = this.SampleRate;
            adapter.NotifyPointsInSecond = DefaultNotifyPointsInSecond;
            adapter.Start();
        }

        public override void Stop()
        {
            adapter.Stop();
        }

        class Adapter : SoundCaptureBase
        {
            CapturedSoundInfoSource owner;

            SlidingWindowBuffer windowBuffer;
            double[] buffer;

            internal Adapter(CapturedSoundInfoSource owner, SoundCaptureDevice device, int window, int delta)
                : base(device)
            {
                this.owner = owner;
                this.windowBuffer = new SlidingWindowBuffer(window, delta);
                this.buffer = new double[window];
            }

            protected override void ProcessData(short[] data)
            {
                foreach (short[] portion in windowBuffer.Process(data))
                {
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = portion[i];
                    }

                    double[] spectr = FftAlgorithm.Calculate(buffer);

                    owner.OnSpectrographData(new SpectrographDataEventArgs(spectr));
                }
            }
        }
    }
}
