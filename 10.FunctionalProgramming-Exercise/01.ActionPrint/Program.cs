using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();

            Action<string> print = name => Console.WriteLine(name);

            text.ForEach(print);
        }
    }
}
