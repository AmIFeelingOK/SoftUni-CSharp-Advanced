using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            SortedDictionary<char, int> counts = new SortedDictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
                if (counts.ContainsKey(str[i]))
                    counts[str[i]]++;
                else
                    counts.Add(str[i], 1);

            foreach (var count in counts)
                Console.WriteLine($"{count.Key}: {count.Value} time/s");
        }
    }
}
