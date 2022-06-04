using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .ToArray();

            (int rows, int cols) = (nums[0], nums[1]);

            int[,] matrix = new int [rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] command = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = command[col];
                }
            }

            long sum = 0;

            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    sum += matrix[row, col];

            Console.WriteLine($"{rows}\n{cols}\n{sum}");
        }
    }
}
