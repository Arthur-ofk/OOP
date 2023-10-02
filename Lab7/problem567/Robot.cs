using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7.problem5.Contracts;

namespace Lab7.problem5
{
    class Robot :IRobot , IIdentifiable5
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public bool CheckId(int lastDigits)
        {
            return Id.EndsWith(lastDigits.ToString());
        }

        public override string ToString()
        {
            return $"Robot - Model: {Model}, ID: {Id}";
        }
    }
}
