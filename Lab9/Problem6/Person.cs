using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem6
{
    class Person6 : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person6 other)
        {
            int nameComparison = StringComparer.OrdinalIgnoreCase.Compare(this.Name, other.Name);
            if (nameComparison != 0)
                return nameComparison;

            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
