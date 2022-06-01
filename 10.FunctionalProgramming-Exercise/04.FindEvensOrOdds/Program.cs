using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            string evenOrOdd = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
                numbers.Add(i);

            Predicate<int> predicate = null;

            if (evenOrOdd == "even")
                predicate = number => number % 2 == 0;
            else if (evenOrOdd == "odd")
                predicate = number => number % 2 != 0;

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
        }
    }
}
