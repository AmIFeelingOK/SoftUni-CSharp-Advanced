using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();

            Func<string, string> addSir = knight => "Sir " + knight;

            foreach (var knight in text)
            {
                Console.WriteLine(addSir(knight));
            }
        }
    }
}
