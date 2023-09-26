using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Person
    {
        public string Name { get; private set; }
        public double Money { get; private set; }
        public List<Product> Bag { get; private set; }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Bag.Add(product);
            Money -= product.Cost;
        }

        public override string ToString()
        {
            string products = Bag.Any() ? string.Join(", ", Bag.Select(p => p.Name)) : "Nothing bought";
            return $"{Name} - {products}";
        }
    }
}
