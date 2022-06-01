using System;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            foreach (var name in names)
                if (name.Length <= n)
                    Console.WriteLine(name);
        }
    }
}
