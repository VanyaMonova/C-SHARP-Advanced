using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string text = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            Queue<char> queue = new Queue<char>(text);
            FillMatrix(rows, cols, matrix, queue);
            PrintMatrix(rows, cols, matrix);

        }
        static void FillMatrix(int rows, int cols, char[,] matrix, Queue<char> queue)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(matrix[row, col]);
                    }
                }
                else
                {
                    for (int col = cols-1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(matrix[row, col]);
                    }
                }
               
            }
        }
        static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
