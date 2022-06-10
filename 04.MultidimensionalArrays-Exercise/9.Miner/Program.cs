using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            char[,] mineGalleries = new char[n, n];

            Queue<string> commands = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            int countCoal = 0;
            int minerRow = 0;
            int minerCol = 0;

            for (int row = 0; row < mineGalleries.GetLength(0); row++)
            {
                char[] temp = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < mineGalleries.GetLength(1); col++)
                {
                    mineGalleries[row, col] = temp[col];

                    if (temp[col].Equals('c'))
                    {
                        countCoal++;
                    }

                    if (temp[col].Equals('s'))
                    {
                        minerRow = row;
                        minerCol = col;
                    }

                }
            }

            int collectedCoal = 0;
            bool isExitLoop = false;
            bool isGameOver = false;

            while ((commands.Count > 0) && (!isExitLoop))
            {
                int colStep = 0;
                int rowStep = 0;

                switch (commands.Dequeue().ToLower())
                {
                    case "left":
                        colStep--;
                        break;
                    case "right":
                        colStep++;
                        break;
                    case "up":
                        rowStep--;
                        break;
                    case "down":
                        rowStep++;
                        break;
                    default:
                        break;
                }

                if (ValidIndex(mineGalleries.GetLength(0), mineGalleries.GetLength(1), minerRow + rowStep, minerCol + colStep))
                {
                    mineGalleries[minerRow, minerCol] = '*';
                    if (mineGalleries[minerRow + rowStep, minerCol + colStep].Equals('c'))
                    {
                        collectedCoal++;
                        countCoal--;
                    }

                    if (mineGalleries[minerRow + rowStep, minerCol + colStep].Equals('e'))
                    {
                        isGameOver = true;
                        isExitLoop = true;
                    }

                    if (countCoal.Equals(0))
                    {
                        isExitLoop = true;
                    }

                    minerRow += rowStep;
                    minerCol += colStep;

                    mineGalleries[minerRow, minerCol] = 's';
                }
            }

            if (countCoal.Equals(0))
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
            else if (isGameOver)
                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            else
                Console.WriteLine($"{countCoal} coals left. ({minerRow}, {minerCol})");
        }

        static bool ValidIndex(int maxRow, int maxCol, int newRow, int newCol)
        {
            bool result = ((newRow >= 0) && (newCol >= 0));
            result = ((result) && (newRow < maxRow) && (newCol < maxCol));

            return result;
        }
    }
}
