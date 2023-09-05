using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  class Task1
    {
      
        public  int Scan(string[] statement1, string[ ] statement2)
        {
            int commonLength = 0;
            int minLength = Math.Min(statement1.Length, statement2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (statement1[i] == statement2[i])
                {
                    commonLength++;
                }
                else
                {
                    break;
                }
            }
            int j = 1;
            while (j <= minLength)
            {
                if (statement1[statement1.Length - j] == statement2[statement2.Length - j])
                {
                    commonLength++;
                    j++;
                }
                else
                {
                    break;
                }
            }

            return commonLength;
        }
    }
}
