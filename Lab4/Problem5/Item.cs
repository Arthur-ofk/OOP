using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Problem5
{
    public class Item
    {
        public string Name { get; set; }
        public long Quantity { get; set; }

        public Item(string name, long quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
