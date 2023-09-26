using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Product
    {
        public string Name { get; private set; }
        public double Cost { get; private set; }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
