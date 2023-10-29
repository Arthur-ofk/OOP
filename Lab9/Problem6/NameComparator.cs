using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem6
{
    class NameComparator : IComparer<Person6>
    {
        public int Compare(Person6 x, Person6 y)
        {
            if (x.Name.Length == y.Name.Length)
            {
                return StringComparer.OrdinalIgnoreCase.Compare(x.Name[0], y.Name[0]);
            }

            return x.Name.Length - y.Name.Length;
        }
    }
}
