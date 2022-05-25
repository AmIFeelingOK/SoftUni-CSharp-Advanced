using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Dictionary<double, int>();

            double[] arrayOfNumbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            foreach (var number in arrayOfNumbers)
            {
                if (counter.ContainsKey(number))
                    counter[number]++;
                else
                    counter[number] = 1;
            }

            foreach (var pair in counter)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
