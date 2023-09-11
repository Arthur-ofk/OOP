using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task10
    {
        public int[][] Pairs (int[] numbers, int difference)
        {
            int[][] pairs = new int[0][];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        Array.Resize(ref pairs, pairs.Length + 1);
                        pairs[pairs.Length - 1] = new int[] { numbers[i], numbers[j] };
                    }
                }
            }

            return pairs;
        }
    }
}
