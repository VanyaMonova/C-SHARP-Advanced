using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                if (!occurences.ContainsKey(current))
                {
                    occurences.Add(current, 0);
                }
                occurences[current]++;
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
