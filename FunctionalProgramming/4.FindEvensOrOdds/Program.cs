using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvenPredicate = num => num % 2 == 0;

            Action<List<int>> printNums = nums => Console.WriteLine(string.Join(' ', nums));

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> nums = new List<int>();

            int startNum = input[0];
            int endNum = input[1];

            for (int i = startNum; i <= endNum; i++)
            {
                nums.Add(i);
            }

            string numType = Console.ReadLine();
            List<int> result = new List<int>();

            if (numType == "even")
            {
                result = nums.FindAll(x => isEvenPredicate(x));
            }
            else
            {
                result = nums.FindAll(x => !isEvenPredicate(x));
            }
            printNums(result);
        }
    }
}
