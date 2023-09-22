using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Galaxy
    {
        private int[][] galaxy;
        private int rows;
        private int cols;

        public Galaxy(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.galaxy = new int[rows][];
            FillGalaxy();
        }

        private void FillGalaxy()
        {
            int value = 0;
            for (int row = 0; row < rows; row++)
            {
                this.galaxy[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    this.galaxy[row][col] = value++;
                }
            }
        }

        public int CollectStars(int ivoStartRow, int ivoStartCol, int evilStartRow, int evilStartCol)
        {
            int collectedStars = 0;

            while (ivoStartRow >= 0 && ivoStartCol < cols)
            {
                if (evilStartRow >= 0 && evilStartRow < rows && evilStartCol >= 0 && evilStartCol < cols)
                {
                    this.galaxy[evilStartRow][evilStartCol] = 0;
                } 

                if (ivoStartRow < rows && ivoStartCol >= 0)
                {
                    collectedStars += this.galaxy[ivoStartRow][ivoStartCol];
                }

               

                ivoStartRow--;
                ivoStartCol++;
                evilStartRow--;
                evilStartCol--;
            }

            return collectedStars;
        }
    }
}
