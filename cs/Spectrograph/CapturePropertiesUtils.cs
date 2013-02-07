using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Spectrograph
{
    static class CapturePropertiesUtils
    {
        internal static void SaveCaptureProperties(string filename, CaptureProperties properties)
        {
            XmlSerializer ser = new XmlSerializer(typeof(CaptureProperties));
            using (FileStream fs = File.Create(filename))
            {
                ser.Serialize(fs, properties);
            }
        }

        internal static CaptureProperties LoadCaptureProperties(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(CaptureProperties));
            using (FileStream fs = File.OpenRead(filename))
            {
                return (CaptureProperties)ser.Deserialize(fs);
            }
        }

        internal static CaptureProperties CreateDefaultCaptureProperties()
        {
            CaptureProperties prop = new CaptureProperties();
            prop.MinFrequency = 40;
            prop.MaxFrequency = 2000;
            prop.Palette = DisplayPalette.Green;
            prop.FrequencyMarks.Add(
                new FrequencyMark() { Frequency = 440, ColorName = "Blue", Label = "A4" }
            );
            return prop;
        }
    }
}
