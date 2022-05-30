using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(boxes);

            int sum = 0;
            int numberOfRacks = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum <= rackCapacity)
                    stack.Pop();
                else
                {
                    numberOfRacks++;
                    sum = 0;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
