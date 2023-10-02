using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem5.Contracts
{
    interface IBuyer
    {
        int Food { get; }
        void BuyFood();
    }
}
