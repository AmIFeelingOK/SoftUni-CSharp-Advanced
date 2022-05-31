using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> cups = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (cups.Peek() - bottles.Peek() <= 0)
                {
                    wastedWater += Math.Abs(cups.Peek() - bottles.Peek());
                    cups.Pop();
                }
                else
                {
                    cups.Push(cups.Pop() - bottles.Peek());
                }
                bottles.Pop();
            }

            if (cups.Count == 0)            
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");            
            else            
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
