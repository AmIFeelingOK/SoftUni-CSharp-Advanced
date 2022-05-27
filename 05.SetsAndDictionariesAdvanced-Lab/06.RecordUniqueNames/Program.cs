using System;
using System.Collections.Generic;

namespace _06.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> namesCollection = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();

                namesCollection.Add(names);
            }

            foreach (string name in namesCollection)
                Console.WriteLine(name);
        }
    }
}
