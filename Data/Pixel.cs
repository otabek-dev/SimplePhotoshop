using System;
using System.Drawing;

namespace MyPhotoshop
{
    public class Pixel
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
