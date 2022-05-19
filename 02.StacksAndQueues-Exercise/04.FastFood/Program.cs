using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine($"{queue.Max()}");

            int counter = queue.Count;

            for (int i = 1; i <= counter; i++)
            {
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Peek();
                    queue.Dequeue();
                }
                else
                    break;
            }

            if (!queue.Any())
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: " + string.Join(" ", queue));
            }            
        }
    }
}
