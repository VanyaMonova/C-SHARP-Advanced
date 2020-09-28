using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                double[] rowValues = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[row] = rowValues;
            }
            for (int row = 0; row < rows - 1; row++)
            {
                double[] rowOne = matrix[row];
                double[] rowTwo = matrix[row + 1];
                if (rowOne.Length == rowTwo.Length)
                {
                    matrix[row] = rowOne.Select(x => x * 2).ToArray();
                    matrix[row + 1] = rowTwo.Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = rowOne.Select(x => x / 2).ToArray();
                    matrix[row + 1] = rowTwo.Select(x => x / 2).ToArray();
                }
            }
            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commandElements = commands.Split();
                string command = commandElements[0];
                int row = int.Parse(commandElements[1]);
                int col = int.Parse(commandElements[2]);
                int value = int.Parse(commandElements[3]);

                if (!isValidCell(matrix, row, col))
                {
                    continue;
                }
                if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool isValidCell(double[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
        }
    }
}

