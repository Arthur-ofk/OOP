using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem5.Contracts
{
     interface ICitizen
    {
        string Name { get; set; }
        int Age { get; set; }
        string Id { get; set; }
        bool CheckId(int lastDigits);
    }
}
