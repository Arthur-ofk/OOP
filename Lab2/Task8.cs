using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task8
    {
        public Tuple<int, int> Find(int[] numbers)
        {
            Dictionary<int, int> numberFrequency = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (numberFrequency.ContainsKey(num))
                {
                    numberFrequency[num]++;
                }
                else
                {
                    numberFrequency[num] = 1;
                }
            }

            int maxFrequency = numberFrequency.Values.Max();
            int mostFrequentNumber = numbers.First(num => numberFrequency[num] == maxFrequency);

            return new Tuple<int, int>(mostFrequentNumber, maxFrequency);
        }
    }
}
