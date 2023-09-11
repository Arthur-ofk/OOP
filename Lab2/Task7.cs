using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task7
    {
        public List<int> FindLIS(int[] numbers)
        {
            int[] lengths = new int[numbers.Length]; 
            int[] previousIndices = new int[numbers.Length]; 
            int maxLength = 1;
            int endingIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                lengths[i] = 1;
                previousIndices[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] > numbers[j] && lengths[i] <= lengths[j] + 1)
                    {
                        lengths[i] = lengths[j] + 1;
                        previousIndices[i] = j;
                    }
                }

                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    endingIndex = i;
                }
            }

            List<int> longestIncreasingSubsequence = new List<int>();
            while (endingIndex != -1)
            {
                longestIncreasingSubsequence.Insert(0, numbers[endingIndex]);
                endingIndex = previousIndices[endingIndex];
            }

            return longestIncreasingSubsequence;
        }
    }
}
