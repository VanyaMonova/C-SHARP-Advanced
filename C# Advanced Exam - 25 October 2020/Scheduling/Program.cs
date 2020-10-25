using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var threads = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int toBeKilled = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(tasks);

            Queue<int> queue = new Queue<int>(threads);

            int killer = 0;

            while (true)
            {
                int currTask = stack.Peek();
                int currThread = queue.Peek();

                if (currTask == toBeKilled)
                {
                    killer = currThread;
                    stack.Pop();
                    break;
                }

                if (currThread >= currTask)
                {
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {killer} killed task {toBeKilled}");

            Console.WriteLine(string.Join(' ', queue));
        }
    }
}
