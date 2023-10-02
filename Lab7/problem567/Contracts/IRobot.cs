using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem5.Contracts
{
     interface IRobot
    {
        string Model { get; set; }
        string Id { get; set; }
        bool CheckId(int lastDigits);
    }
}
