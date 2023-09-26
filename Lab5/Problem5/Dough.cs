using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Problem5
{
    public  class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double caloriesPerGram;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
            SetCaloriesPerGram();
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                    throw new ArgumentException("Invalid type of dough.");
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                string lowerValue = value.ToLower();
                if (lowerValue != "crispy" && lowerValue != "chewy" && lowerValue != "homemade")
                    throw new ArgumentException("Invalid type of dough.");
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get { return caloriesPerGram; }
        }

        private void SetCaloriesPerGram()
        {
            switch (flourType.ToLower())
            {
                case "white":
                    caloriesPerGram = 1.5;
                    break;
                case "wholegrain":
                    caloriesPerGram = 1.0;
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    caloriesPerGram *= 0.9;
                    break;
                case "chewy":
                    caloriesPerGram *= 1.1;
                    break;
                case "homemade":
                    caloriesPerGram *= 1.0;
                    break;
                default:
                    throw new ArgumentException("Invalid type of dough.");
            }
        }
    }
}
