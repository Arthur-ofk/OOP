using Lab7.problem12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem1
{
    public class Citizen : IPerson , IBirthiable, IIdentifiable
    {
        public Citizen(string? name, int age, string? id, string? birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get ; set ; }
        public string Birthdate { get; set; }

        public string Id { get; set; }
    }
}
