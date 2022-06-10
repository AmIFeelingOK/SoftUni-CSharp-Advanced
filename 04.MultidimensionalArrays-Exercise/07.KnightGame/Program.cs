using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];

        Dictionary<string, int> matrixDictionary = new Dictionary<string, int>();

        int counter = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string colEl = Console.ReadLine();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colEl[col];
            }
        }
        while (MaxValue(matrix, matrixDictionary, n) > 0)
        {
            string[] coordinates = CoordinatesForRemovingTheKnight(matrixDictionary);
            string rows = coordinates[0];
            string column = coordinates[1];
            matrix[int.Parse(rows), int.Parse(column)] = '0';
            counter++;
            matrixDictionary.Clear();
        }

        Console.WriteLine(counter);
    }

    private static int MaxValue(char[,] matrix, Dictionary<string, int> matrixDictionary, int n)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var currElement = matrix[row, col];

                if (currElement == 'K')
                {
                    matrixDictionary.Add($"{row},{col}", 0);

                    if (col - 2 >= 0 && row - 1 >= 0)
                        if (currElement == matrix[row - 1, col - 2])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col - 1 >= 0 && row - 2 >= 0)
                        if (currElement == matrix[row - 2, col - 1])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col - 2 >= 0 && row + 1 < n)
                        if (currElement == matrix[row + 1, col - 2])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col - 1 >= 0 && row + 2 < n)
                        if (currElement == matrix[row + 2, col - 1])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col + 2 < n && row - 1 >= 0)
                        if (currElement == matrix[row - 1, col + 2])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col + 1 < n && row - 2 >= 0)
                        if (currElement == matrix[row - 2, col + 1])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col + 1 < n && row + 2 < n)
                        if (currElement == matrix[row + 2, col + 1])
                            matrixDictionary[$"{row},{col}"]++;

                    if (col + 2 < n && row + 1 < n)
                        if (currElement == matrix[row + 1, col + 2])
                            matrixDictionary[$"{row},{col}"]++;
                }
            }
        }

        var sortedDic = matrixDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        int maxValue = 0;

        foreach (var item in sortedDic)
            if (item.Value > maxValue)
                maxValue = item.Value;

        return maxValue;

    }

    private static string[] CoordinatesForRemovingTheKnight(Dictionary<string, int> matrixDictionary)
    {
        var sortedDic = matrixDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        int maxValue = 0;
        string[] cooredinates = new string[2];

        foreach (var item in sortedDic)
        {
            if (item.Value > maxValue)
            {
                maxValue = item.Value;
                cooredinates = item.Key.Split(",");
            }
        }
        return cooredinates;
    }
}
