using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Task9
    {
        public Dictionary<char, int> Index(string word)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Dictionary<char, int> letterIndices = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                int index = Array.IndexOf(alphabet, letter);
                letterIndices[letter] = index;
            }

            return letterIndices;
        }
    }
}
