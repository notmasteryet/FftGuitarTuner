using System;
using System.Collections.Generic;
using System.Text;

namespace Spectrograph
{
    sealed class SlidingWindowBuffer
    {
        int window;

        public int Window
        {
            get { return window; }
        }

        int delta;

        public int Delta
        {
            get { return delta; }
        }

        short[] buffer;
        int bufferSize;

        public SlidingWindowBuffer(int window)
            : this(window, window)
        {
        }

        public SlidingWindowBuffer(int window, int delta)
        {
            if (window <= 0) throw new ArgumentOutOfRangeException("window");
            if (delta <= 0) throw new ArgumentOutOfRangeException("delta");
            if (delta > window) throw new ArgumentOutOfRangeException("delta", "shall be less than or equal to window size");

            this.window = window;
            this.delta = delta;
            this.buffer = new short[window];
            this.bufferSize = 0;
        }

        public IEnumerable<short[]> Process(short[] data)
        {
            if (bufferSize + data.Length < window)
            {
                // simple append
                for (int i = 0; i < data.Length; i++)
                {
                    buffer[bufferSize++] = data[i];
                }
                yield break;
            }

            int j = 0;

            do
            {
                while (bufferSize < window)
                {
                    buffer[bufferSize++] = data[j++];
                }

                yield return buffer;

                Array.Copy(buffer, delta, buffer, 0, window - delta);
                bufferSize -= delta;
            } while (bufferSize + (data.Length - j) >= window);

            // append tail
            while (j < data.Length)
            {
                buffer[bufferSize++] = data[j++];
            }
        }
    }
}
