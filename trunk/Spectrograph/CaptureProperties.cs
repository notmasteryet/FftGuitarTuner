using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Spectrograph
{
    [XmlInclude(typeof(Log10DisplayMethodFactory))]
    [XmlInclude(typeof(LinearDisplayMethodFactory))]
    public class CaptureProperties
    {
        public double MinFrequency = 20.0;
        public double MaxFrequency = 20000.0;

        public int Window = 4096;
        public int Delta = 4096;
        public int SampleRate = 44100;

        public List<FrequencyMark> FrequencyMarks = new List<FrequencyMark>();

        public DisplayMethodFactory DisplayMethod = new Log10DisplayMethodFactory();

        public DisplayPalette Palette = DisplayPalette.Green;

        public bool IsSecondsMarked = false;
        public int SecondMarkEvery = 60;
    }

    public class FrequencyMark
    {
        public double Frequency;
        public string Label;
        public string ColorName;
    }

    public enum DisplayPalette
    {
        Green,
        Red,
        Black,
        BlueReadWhite
    }
}
