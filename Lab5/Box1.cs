using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Box1
    {
        
        private double length;
        private double width;
        private double height;

        
        public double Length
    {
        get { return length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length must be a positive number.");
            }
            length = value;
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width must be a positive number.");
            }
            width = value;
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height must be a positive number.");
            }
            height = value;
        }
    }
        public Box1(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        
        public double CalculateSurfaceArea()
        {
            return 2 * (length * width + length * height + width * height);
        }

        
        public double CalculateLateralSurfaceArea()
        {
            return 2 * (length * height + width * height);
        }

        
        public double CalculateVolume()
        {
            return length * width * height;
        }
    }
}
