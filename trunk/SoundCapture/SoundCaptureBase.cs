using System;
using System.Threading;
using Microsoft.DirectX.DirectSound;
using Microsoft.Win32.SafeHandles;

namespace SoundCapture
{
    /// <summary>
    /// Base class to capture audio samples.
    /// </summary>
    public abstract class SoundCaptureBase : IDisposable
    {
        const int BufferSeconds = 3;
        const int NotifyPointsInSecond = 2;

        // change in next two will require also code change
        const int BitsPerSample = 16; 
        const int ChannelCount = 1; 

        int sampleRate = 44100;
        bool isCapturing = false;
        bool disposed = false;

        public bool IsCapturing
        {
            get { return isCapturing; }
        }

        public int SampleRate
        {
            get { return sampleRate; }
            set 
            {
                if (sampleRate <= 0) throw new ArgumentOutOfRangeException();

                EnsureIdle();

                sampleRate = value; 
            }
        }
        
        Capture capture;
        CaptureBuffer buffer;
        Notify notify;
        int bufferLength;
        AutoResetEvent positionEvent;
        SafeWaitHandle positionEventHandle;
        ManualResetEvent terminated;
        Thread thread;
        SoundCaptureDevice device;

        public SoundCaptureBase()
            : this(SoundCaptureDevice.GetDefaultDevice())
        {

        }

        public SoundCaptureBase(SoundCaptureDevice device)
        {
            this.device = device;

            positionEvent = new AutoResetEvent(false);
            positionEventHandle = positionEvent.SafeWaitHandle;
            terminated = new ManualResetEvent(true);
        }

        private void EnsureIdle()
        {
            if (IsCapturing)
                throw new SoundCaptureException("Capture is in process");
        }

        /// <summary>
        /// Starts capture process.
        /// </summary>
        public void Start()
        {
            EnsureIdle();

            isCapturing = true;

            WaveFormat format = new WaveFormat();
            format.Channels = ChannelCount;
            format.BitsPerSample = BitsPerSample;
            format.SamplesPerSecond = SampleRate;
            format.FormatTag = WaveFormatTag.Pcm;
            format.BlockAlign = (short)((format.Channels * format.BitsPerSample + 7) / 8);
            format.AverageBytesPerSecond = format.BlockAlign * format.SamplesPerSecond;

            bufferLength = format.AverageBytesPerSecond * BufferSeconds;
            CaptureBufferDescription desciption = new CaptureBufferDescription();
            desciption.Format = format;
            desciption.BufferBytes = bufferLength;

            capture = new Capture(device.Id);
            buffer = new CaptureBuffer(desciption, capture);

            int waitHandleCount = BufferSeconds * NotifyPointsInSecond;
            BufferPositionNotify[] positions = new BufferPositionNotify[waitHandleCount];
            for (int i = 0; i < waitHandleCount; i++)
            {
                BufferPositionNotify position = new BufferPositionNotify();
                position.Offset = (i + 1) * bufferLength / positions.Length - 1;
                position.EventNotifyHandle = positionEventHandle.DangerousGetHandle();
                positions[i] = position;
            }

            notify = new Notify(buffer);
            notify.SetNotificationPositions(positions);

            terminated.Reset();
            thread = new Thread(new ThreadStart(ThreadLoop));
            thread.Name = "Sound capture";
            thread.Start();
        }

        private void ThreadLoop()
        {
            buffer.Start(true);
            try
            {
                int nextCapturePosition = 0;
                WaitHandle[] handles = new WaitHandle[] { terminated, positionEvent };
                while (WaitHandle.WaitAny(handles) > 0)
                {
                    int capturePosition, readPosition;
                    buffer.GetCurrentPosition(out capturePosition, out readPosition);

                    int lockSize = readPosition - nextCapturePosition;
                    if (lockSize < 0) lockSize += bufferLength;
                    if((lockSize & 1) != 0) lockSize--;

                    int itemsCount = lockSize >> 1;

                    short[] data = (short[])buffer.Read(nextCapturePosition, typeof(short), LockFlag.None, itemsCount);
                    ProcessData(data);
                    nextCapturePosition = (nextCapturePosition + lockSize) % bufferLength;
                }
            }
            finally
            {
                buffer.Stop();
            }
        }

        /// <summary>
        /// Processes the captured data.
        /// </summary>
        /// <param name="data">Captured data</param>
        protected abstract void ProcessData(short[] data);

        /// <summary>
        /// Stops capture process.
        /// </summary>
        public void Stop()
        {
            if (isCapturing)
            {
                isCapturing = false;

                terminated.Set();
                thread.Join();

                notify.Dispose();
                buffer.Dispose();
                capture.Dispose();
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        ~SoundCaptureBase()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (disposed) return;

            disposed = true;
            GC.SuppressFinalize(this);
            if (IsCapturing) Stop();
            positionEventHandle.Dispose();
            positionEvent.Close();
            terminated.Close();            
        }
    }
}
