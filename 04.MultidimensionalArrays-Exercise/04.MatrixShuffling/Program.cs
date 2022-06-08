using System;
using System.Linq;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            (int rows, int cols) = (nums[0], nums[1]);

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (!ValidateCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    string[] commandParts = command.Split();

                    int rowOne = int.Parse(commandParts[1]);
                    int colOne = int.Parse(commandParts[2]);
                    int rowTwo = int.Parse(commandParts[3]);
                    int colTwo = int.Parse(commandParts[4]);

                    string firstElement = matrix[rowOne, colOne];
                    string secondElement = matrix[rowTwo, colTwo];
                    matrix[rowTwo, colTwo] = firstElement;
                    matrix[rowOne, colOne] = secondElement;

                    PrintMatrix(matrix);
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
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

        private static bool ValidateCommand(string command, int rows, int cols)
        {
            string[] commandParts = command.Split();

            if (commandParts[0] == "swap" && commandParts.Length == 5)
            {
                int row1 = int.Parse(commandParts[1]);
                int col1 = int.Parse(commandParts[2]);
                int row2 = int.Parse(commandParts[3]);
                int col2 = int.Parse(commandParts[4]);

                if (row1 >= 0 && row1 < rows
                    && col1 >= 0 && col1 < cols
                    && row2 >= 0 && row2 < rows
                    && col2 >= 0 && col2 < cols)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
