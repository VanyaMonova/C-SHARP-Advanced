﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToArray();
                var color = input[0];
                var clothes = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }

            var clothingToFind = Console.ReadLine().Split().ToArray();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothing in item.Value)
                {
                    Console.Write($"* {clothing.Key} - {clothing.Value} ");

                    if (clothing.Key == clothingToFind[1] && item.Key == clothingToFind[0])
                    {
                        Console.Write("(found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
