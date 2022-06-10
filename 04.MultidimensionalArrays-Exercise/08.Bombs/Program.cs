using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string[] bombs = Console.ReadLine().Split();

            for (int i = 0; i < bombs.Length; i++)
            {
                string[] currBombcoordinates = bombs[i].Split(",");
                int rowIndex = int.Parse(currBombcoordinates[0]);
                int colIndex = int.Parse(currBombcoordinates[1]);
                int bombing = matrix[rowIndex, colIndex];

                if (bombing > 0)
                {
                    
                    if (Exist(matrix, rowIndex - 1, colIndex - 1) && matrix[rowIndex - 1, colIndex - 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex - 1, colIndex - 1] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex - 1, colIndex) && matrix[rowIndex - 1, colIndex] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex - 1, colIndex] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex - 1, colIndex + 1) && matrix[rowIndex - 1, colIndex + 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex - 1, colIndex + 1] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex, colIndex + 1) && matrix[rowIndex, colIndex + 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex, colIndex + 1] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex + 1, colIndex + 1) && matrix[rowIndex + 1, colIndex + 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex + 1, colIndex + 1] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex + 1, colIndex) && matrix[rowIndex + 1, colIndex] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex + 1, colIndex] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex + 1, colIndex - 1) && matrix[rowIndex + 1, colIndex - 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex + 1, colIndex - 1] -= matrix[rowIndex, colIndex];
                    }
                    
                    if (Exist(matrix, rowIndex, colIndex - 1) && matrix[rowIndex, colIndex - 1] > 0 &&
                        matrix[rowIndex, colIndex] > 0)
                    {
                        matrix[rowIndex, colIndex - 1] -= matrix[rowIndex, colIndex];
                    }

                    matrix[rowIndex, colIndex] = 0;
                }

            }

            int counter = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        counter++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");

            PrintMatrix(matrix);
        }

        private static bool Exist(int[,] matrix, int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex < matrix.GetLength(0) 
                && colIndex >= 0 && colIndex < matrix.GetLength(1);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
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
