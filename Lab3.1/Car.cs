using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, double? weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
    }
}
