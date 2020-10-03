using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> occurences = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!occurences.ContainsKey(num))
                {
                    occurences.Add(num, 0);
                }

                occurences[num]++;
            }
            foreach (var item in occurences)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
