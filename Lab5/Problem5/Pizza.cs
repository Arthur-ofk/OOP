using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Problem5
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Pizza name cannot be empty or whitespace.");
                if (value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            private set { dough = value; }
        }

        public IReadOnlyCollection<Topping> Toppings
        {
            get { return toppings.AsReadOnly(); }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            toppings.Add(topping);
        }

        public double CalculateCalories()
        {
            double doughCalories = Dough.Weight * Dough.CaloriesPerGram;
            double toppingsCalories = toppings.Sum(t => t.Weight * t.CaloriesPerGram);

            return doughCalories + toppingsCalories;
        }
    }
}
