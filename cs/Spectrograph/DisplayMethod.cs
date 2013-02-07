using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spectrograph
{
    public abstract class DisplayMethod
    {
        public abstract void Quiantize(double[] data, int maxValue, int[] result);
    }

    public abstract class DisplayMethodFactory
    {
        public abstract DisplayMethod CreateDisplayMethod();
    }

    public class Log10DisplayMethodFactory : DisplayMethodFactory
    {
        public double MinOrder = 9.0;
        public double MaxOrder = 12.0;

        public override DisplayMethod CreateDisplayMethod()
        {
            return new Log10Method(MinOrder, MaxOrder - MinOrder);
        }

        class Log10Method : DisplayMethod
        {
            double start;
            double length;

            internal Log10Method(double start, double length)
            {
                this.start = start;
                this.length = length;
            }

            public override void Quiantize(double[] data, int maxValue, int[] result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    double logValue = Math.Log10(data[i]);
                    if (logValue < 0) logValue = 0;
                    double value = (logValue - start) / length;
                    if (value < 0) value = 0; else if(value > 1) value = 1;
                    result[i] = (int)Math.Round(value * maxValue);
                }
            }
        }
    }

    public class LinearDisplayMethodFactory : DisplayMethodFactory
    {
        public double Offset = 0.0;
        public double Scale = 1e+11;

        public override DisplayMethod CreateDisplayMethod()
        {
            return new LinearMethod(Offset, Scale);
        }

        class LinearMethod : DisplayMethod
        {
            double offset;
            double scale;

            internal LinearMethod(double offset, double scale)
            {
                this.offset = offset;
                this.scale = scale;
            }

            public override void Quiantize(double[] data, int maxValue, int[] result)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    double value = (data[i] - offset) / scale;
                    if (value < 0) value = 0; else if (value > 1) value = 1;
                    result[i] = (int)Math.Round(value * maxValue);
                }
            }
        }
    }
}
