using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.problem4
{
    public class Smartphone : IBrowsable, ICallable
    {
        public string Call(string number)
        {
           return  $"Calling... {number}";
        }

        public string Browse(string site)
        {
            if (site.Any(char.IsDigit))
            {
                throw  new ArgumentException("Invalid URL!");
            }
            else
            {
                return$"Browsing: {site}!";
            }
        }
    }
}
