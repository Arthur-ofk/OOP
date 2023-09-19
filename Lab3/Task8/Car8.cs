using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Task8
{
    public class Car8
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car8(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, List<Tire> tires)
        {
            Model = model;
            Engine = new Engine { EngineSpeed = engineSpeed, EnginePower = enginePower };
            Cargo = new Cargo { CargoWeight = cargoWeight, CargoType = cargoType };
            Tires = tires;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}
