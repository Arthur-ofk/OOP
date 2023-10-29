using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int index;

        public ListyIterator(List<T> collection)
        {
            this.collection = collection;
            this.index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return index < collection.Count - 1;
        }

        public void Print()
        {
            if (collection.Count == 0 || index >= collection.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(collection[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void PrintAll()
        {

            foreach (var item in collection)
            {
                Console.Write(item+" ");
            }
        }
    }
}
