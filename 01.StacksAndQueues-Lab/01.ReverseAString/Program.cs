using System;
using System.Collections.Generic;

namespace _01.StacksAndQueues_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var chr in input)
            {
                stack.Push(chr);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
