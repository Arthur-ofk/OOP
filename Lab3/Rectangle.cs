using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; } 
        public double Y { get; set; } 

        public double Right => X + Width; 
        public double Bottom => Y + Height; 

        public bool IntersectsWith(Rectangle other)
        {
            return !(Right < other.X || other.Right < X || Bottom < other.Y || other.Bottom < Y);
        }
    }
}
