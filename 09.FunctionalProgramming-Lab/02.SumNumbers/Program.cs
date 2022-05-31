using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers.Length));
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}
