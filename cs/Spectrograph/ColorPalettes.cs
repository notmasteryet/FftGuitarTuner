using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Spectrograph
{
    public static class ColorPalettes
    {
        public static Color[] GreenValue;
        public static Color[] RedValue;
        public static Color[] GreenSaturation;
        public static Color[] GreenToRed;
        public static Color[] BlueToRedToWhite;
        public static Color[] WhiteToBlack;

        static ColorPalettes()
        {
            const int ColorCount = 256;
            GreenValue = new Color[ColorCount];
            GreenSaturation = new Color[ColorCount];
            RedValue = new Color[ColorCount];
            WhiteToBlack = new Color[ColorCount];

            for (int i = 0; i < ColorCount; i++)
            {
                GreenValue[i] = Color.FromArgb(0, i, 0);
                GreenSaturation[i] = Color.FromArgb(255 - i, 255, 255 - i);
                RedValue[i] = Color.FromArgb(i, 0, 0);
                WhiteToBlack[ColorCount - i - 1] = Color.FromArgb(i, i, i);
            }

            GreenToRed = new Color[ColorCount * 2];
            for (int i = 0; i < ColorCount; i++)
            {
                GreenToRed[i] = Color.FromArgb(i, 255, 0);
                GreenToRed[2 * ColorCount - i - 1] = Color.FromArgb(255, i, 0);
            }

            BlueToRedToWhite = new Color[ColorCount * 4]; 
            // Blue->Purple->Red->Yellow->White
            for (int i = 0; i < ColorCount; i++)
            {
                BlueToRedToWhite[i] = Color.FromArgb(i, 0, 255);
                BlueToRedToWhite[2 * ColorCount - i - 1] = Color.FromArgb(255, 0, i);
                BlueToRedToWhite[2 * ColorCount + i] = Color.FromArgb(255, i, 0);
                BlueToRedToWhite[3 * ColorCount + i] = Color.FromArgb(255, 255, i);
            }
        }
    }
}
