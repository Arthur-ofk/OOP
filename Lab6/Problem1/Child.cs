using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Problem1
{
    public class Child : Person
    {
        public Child(string name, int age)
          : base(name, age)
        {
        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
               if(((value < 0)|| value>15))
                {
                    throw new ArgumentException("Age can`t be greater than 15");
                }

                base.Age = value;
            }
        }
    }
}
