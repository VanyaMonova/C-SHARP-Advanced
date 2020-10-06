using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("../../../text.txt"))
            {
                string line = streamReader.ReadLine();
                int lineCounter = 1;

                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Regex pattern = new Regex("[-,.!?]");
                        line = pattern.Replace(line, "@");
                        var array = line.Split().ToArray().Reverse();
                        Console.WriteLine(String.Join(" ",line));
                    }
                    lineCounter++;
                    line = streamReader.ReadLine();
                }
            }



        }
    }
}
