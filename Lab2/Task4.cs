using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task4
    {
        public bool[] IsPrime(int n)
        {
            bool[] isPrime = new bool[n + 1]; 
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true; 
            }

           
            for (int p = 2; p * p <= n; p++)
            {
                
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false; 
                    }
                }
            }
            return isPrime;
        }
    }
}
