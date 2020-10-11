using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());

            Func<int, bool> predicate = num => num % n != 0;

            Action<List<int>> printNums = numbers => Console.WriteLine(string.Join(' ', numbers));

            printNums(numbers.Where(predicate).ToList());
        }
    }
}
