using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem5.Contracts
{
     class Rebel :IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }

        public override string ToString()
        {
            return $"Rebel - Name: {Name}, Age: {Age}, Group: {Group}";
        }
    }
}
