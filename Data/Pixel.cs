using System;
using System.Drawing;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        public double R
        {
            get => r;
            set
            {
                r = Check(value);
            }
        }

        private double g;
        public double G
        {
            get => g;
            set
            {
                g = Check(value);
            }
        }

        private double b;
        public double B
        {
            get => b;
            set
            {
                b = Check(value);
            }
        }

        public static double Trim(double val)
        {
            if (val < 0) return 0;
            if (val > 1) return 1;
            return val;
        }

        public double Check(double val)
        {
            if (val < 0 || val > 1) 
                throw new ArgumentException();
            return val;
        }

        public static Pixel operator *(Pixel pixel, double value)
        {
            return new Pixel()
            {
                r = Trim(pixel.r * value),
                g = Trim(pixel.g * value),
                b = Trim(pixel.b * value)
            };
        }

        public static Pixel operator *(double value, Pixel pixel) => pixel * value;
    }
}
