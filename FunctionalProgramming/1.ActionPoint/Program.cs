using System;
using System.Linq;

namespace _1.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = items => Console.WriteLine(string.Join(Environment.NewLine, items));
            string[] names = Console.ReadLine().Split().ToArray();
            print(names);
        }
    }
}
