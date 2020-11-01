using System;
using System.Linq;

namespace _05.GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                box.Values.Add(input);
            }
            string targetItem = Console.ReadLine();

            int result = box.GreaterValuesThan(targetItem);
            
            Console.WriteLine(result);
        }
    }
}
