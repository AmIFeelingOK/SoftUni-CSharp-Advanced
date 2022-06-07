using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            (int rows, int cols) = (nums[0], nums[1]);

            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);

            int sum = 0;
            int maxSum = 0;
            int rowStartIndex = 0;
            int colStartIndex = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowStartIndex = row;
                        colStartIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowStartIndex; row <= rowStartIndex + 2; row++)
            {
                for (int col = colStartIndex; col <= colStartIndex + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
