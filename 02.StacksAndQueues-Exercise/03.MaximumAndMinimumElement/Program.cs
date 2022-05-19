using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                if (input[0] == "1")
                    stack.Push(int.Parse(input[1]));

                else if (input[0] == "2")
                {
                    if (stack.Any())
                        stack.Pop();
                }
                else if (input[0] == "3")
                {
                    if (stack.Any())
                        Console.WriteLine(stack.Max());
                }
                else if (input[0] == "4")
                {
                    if (stack.Any())
                        Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
