using System;
using System.Linq;

namespace _2.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = name => Console.WriteLine($"Sir " + name);
            string[] names = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                print(name);
            }
        }
    }
}
