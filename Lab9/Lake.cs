using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(IEnumerable<int> stoneNumbers)
        {
            this.stones = new List<int>(stoneNumbers);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }

            int lastEvenIndex = stones.Count % 2 == 0 ? stones.Count - 1 : stones.Count - 2;

            for (int i = lastEvenIndex; i >= 1; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
