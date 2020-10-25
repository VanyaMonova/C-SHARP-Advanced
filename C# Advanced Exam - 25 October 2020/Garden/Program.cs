using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            FillMatrix(rows, cols, matrix);

            string command;

            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] indexes = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rowIndex = indexes[0];
                int colIndex = indexes[1];

                if (rowIndex < 0 || rowIndex >= rows || colIndex < 0 || colIndex >= cols)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < rows; i++)
                {
                    matrix[i, colIndex] += 1;
                }

                for (int i = 0; i < cols; i++)
                {
                    matrix[rowIndex, i] += 1;
                }

                matrix[rowIndex, colIndex] = 1;
            }

            PrintMatrix(rows, cols, matrix);
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = 0;
                }
            }
        }

        private static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
