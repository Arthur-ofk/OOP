using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Problem5
{
    public class Topping
    {
        private string type;
        private double weight;
        private double caloriesPerGram;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
            SetCaloriesPerGram();
        }

        public string Type
        {
            get { return type; }
            private set
            {
                string lowerValue = value.ToLower();
                if (lowerValue != "meat" && lowerValue != "veggies" && lowerValue != "cheese" && lowerValue != "sauce")
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                type = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get { return caloriesPerGram; }
        }

        private void SetCaloriesPerGram()
        {
            switch (Type.ToLower())
            {
                case "meat":
                    caloriesPerGram = 1.2;
                    break;
                case "veggies":
                    caloriesPerGram = 0.8;
                    break;
                case "cheese":
                    caloriesPerGram = 1.1;
                    break;
                case "sauce":
                    caloriesPerGram = 0.9;
                    break;
                default:
                    throw new ArgumentException($"Cannot place {Type} on top of your pizza.");
            }
        }
    }
}
