using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> input = new Stack<string>(Console.ReadLine().Split().Reverse());

            while (input.Count > 1)
            {
                int a = int.Parse(input.Pop());

                string symbol = input.Pop();

                int b = int.Parse(input.Pop());

                if (symbol == "+")
                {
                    input.Push((a + b).ToString());
                }
                else if (symbol == "-")
                {
                    input.Push((a - b).ToString());
                }
            }

            Console.WriteLine(input.Pop());
        }
    }
}
