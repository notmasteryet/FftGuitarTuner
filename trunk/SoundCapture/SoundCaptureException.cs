using System;

namespace SoundCapture
{
    public class SoundCaptureException : Exception
    {
        public SoundCaptureException(string message)
            : base(message)
        {
        }
    }
}
