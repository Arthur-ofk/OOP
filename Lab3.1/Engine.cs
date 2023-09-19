using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public double? Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power, double? displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
