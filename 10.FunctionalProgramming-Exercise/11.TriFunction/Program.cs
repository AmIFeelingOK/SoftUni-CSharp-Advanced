using System;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();
            Console.WriteLine(names.First(x => x.Select(y => (int)y).Sum() >= n));
        }
    }
}
