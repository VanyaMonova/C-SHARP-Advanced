using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFunc = inputNums => inputNums.Min();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(minFunc(nums));
        }
    }
}
