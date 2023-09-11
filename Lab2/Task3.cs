using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task3
    {
        public int[] Fold(int[] array)
        {
            int n = array.Length / 4;

            int rowLength = array.Length/2;
            int[,] rows = new int[ rowLength,2];
            int[] result= new int[rowLength];
            
            for (int i = 0; i < 2; i++)
            {
                if (!(i == 1))
                {
                    int j = 0;
                    for (int m = n-1; m>= 0; m--)
                    { 
                        rows[j,i]=array[m];
                        j++;
                    }

                    for (int m =array.Length-1 ; m >= array.Length-n ; m--)
                    {
                        rows[j, i] = array[m];
                        j++;
                    }
                }
                i++;
                int o = 0;
                for (int m = n; m < array.Length-n; m++)
                {
                    rows[o,i] = array[m];
                    o++;
                }
            }
                for (int k = 0; k < rowLength; k++)
            {
                result[k] = rows[k,0] + rows[k,1];
            }
            return result;
        }
    }
}
