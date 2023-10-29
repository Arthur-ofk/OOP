using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem6
{
    class AgeComparator : IComparer<Person6>
    {
        public int Compare(Person6 x, Person6 y)
        {
            return x.Age - y.Age;
        }
    }
}
