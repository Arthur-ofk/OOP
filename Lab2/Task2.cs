using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  class Task2
    {
        public int[] SumArray(int[] array, int position)
        {
            int[] sum = new int[array.Length];
            for (int i = 0; i < position; i++)
            {
                Rotate(array);
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += array[j];
                }
            }
            return sum;
        }
        private void  Rotate(int[] array)
        {
            int length = array.Length;
            int[] temp = new int[length];
            int lastElement = array[length - 1];

            // Shift elements to the right
            for (int i = length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            // Place the last element at the beginning
            array[0] = lastElement;
        }
       
        
    }
}
