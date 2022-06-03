using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elementsSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] elements = line.Split();

                foreach (var chEl in elements)
                    elementsSet.Add(chEl);
            }

            Console.WriteLine(string.Join(" ", elementsSet));
        }
    }
}
