using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem7
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int nameComparison = string.Compare(this.Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0)
                return nameComparison;

            int ageComparison = this.Age.CompareTo(other.Age);
            if (ageComparison != 0)
                return ageComparison;

            return string.Compare(this.Town, other.Town, StringComparison.Ordinal);
        }
    }
}
