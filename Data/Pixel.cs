using System;
using System.Drawing;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        private double g;
        private double b;

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
            var result = new Pixel()
            {
                r = Trim(pixel.r * value),
                g = Trim(pixel.g * value),
                b = Trim(pixel.b * value)
            };
            
            return result;
        }

        public double R
        {
            get => r;
            set
            {
                r = Check(value);
            }
        }

        public double G
        {
            get => g;
            set
            {
               g = Check(value);
            }
        }

        public double B
        {
            get => b;
            set
            {
                b = Check(value);
            }
        }
    }
}
