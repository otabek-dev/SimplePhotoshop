using System;

namespace MyPhotoshop
{
    public class Pixel
    {
        private double r;
        private double g;
        private double b;
        public double R
        {
            get => r;
            set
            {
                if (value <= 1)
                    r = value;
                else
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
            }
        }
        public double G
        {
            get => g;
            set
            {
                if (value <= 1)
                    g = value;
                else
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value <= 1)
                    b = value;
                else
                    throw new Exception(string.Format("Wrong channel value {0} (the value must be between 0 and 1", value));
            }
        }
    }
}
