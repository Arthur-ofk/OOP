using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public  class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double DistanceTraveled { get; set; }

        public void Drive(double amountOfKm)
        {
            double neededFuel = amountOfKm * FuelConsumptionPerKm;

            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                DistanceTraveled += amountOfKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive of {Model}");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {DistanceTraveled}";
        }   
    }
}
