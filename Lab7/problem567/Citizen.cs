using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7.problem5.Contracts;

namespace Lab7.problem5
{
    class Citizen5 : ICitizen, IBirthable, IIdentifiable5 , IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public DateTime Birthdate { get ; set ; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public bool CheckId(int lastDigits)
        {
            return Id.EndsWith(lastDigits.ToString());
        }

        public override string ToString()
        {
            return $"Citizen - Name: {Name}, Age: {Age}, ID: {Id}";
        }
    }
}
