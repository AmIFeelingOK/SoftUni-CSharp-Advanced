using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = array[0];
            int s = array[1];
            int x = array[2];

            int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
                stack.Push(numbers[i]);

            for (int j = 0; j < s; j++)
                stack.Pop();
            if (stack.Count == 0)
                Console.WriteLine(0);
            
            else if (stack.Contains(x))
                Console.WriteLine("true");
            
            else if (!stack.Contains(x))
                Console.WriteLine(stack.Min());
        }
    }
}
