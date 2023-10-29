using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    
        public class CustomStack<T> : IEnumerable<T>
        {
            private List<T> stack;

            public CustomStack()
            {
                stack = new List<T>();
            }

            public void Push(params T[] elements)
            {
                stack.AddRange(elements);
            }

            public T Pop()
            {
                if (stack.Count > 0)
                {
                    int lastIndex = stack.Count - 1;
                    T element = stack[lastIndex];
                    stack.RemoveAt(lastIndex);
                    return element;
                }
                throw new InvalidOperationException("No elements");
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int i = stack.Count - 1; i >= 0; i--)
                {
                    yield return stack[i];
                }
            }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}
