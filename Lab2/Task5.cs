using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task5
    {
        public string[] Compare(char[] array1, char[] array2)
        {

            int minLength = Math.Min(array1.Length, array2.Length);
            bool arraysEqual = true;
            string[] result= new string[2];

            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] < array2[i])
                {
                    result[0]=new string(array1);
                    result[1] = new string(array2);
                    arraysEqual = false;
                    break;
                }
                else if (array1[i] > array2[i])
                {
                    result[0] = new string(array2);
                    result[1] = new string(array1);
                    arraysEqual = false;
                    break;
                }
            }

            if (arraysEqual)
            {
                if (array1.Length < array2.Length)
                {
                    result[0] = new string(array1);
                    result[1] = new string(array2);
                }
                else
                {
                    result[0] = new string(array2);
                    result[1] = new string(array1);
                }
            }
            return result;
        }
    }
}
