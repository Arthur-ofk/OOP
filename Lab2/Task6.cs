using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task6
    {
        public int[] Find(int[] numbers)
        {
            int maxLength = 0;
            int currentLength = 1;
            int endIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        endIndex = i;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            if (maxLength > 1)
            {
                return numbers.Skip(endIndex - maxLength + 1).Take(maxLength).ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}
