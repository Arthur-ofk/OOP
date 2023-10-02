using Lab7.problem5.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem5
{
    public class Pet  :IBirthable
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public override string ToString()
        {
            return $"Pet - Name: {Name}, Birthdate: {Birthdate:dd/MM/yyyy}";
        }
    }
}
