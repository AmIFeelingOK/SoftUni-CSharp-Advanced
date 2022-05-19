using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.BasicQueueOperations
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

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
                queue.Enqueue(numbers[i]);

            for (int j = 0; j < s; j++)
                queue.Dequeue();
            if (queue.Count == 0)
                Console.WriteLine(0);

            else if (queue.Contains(x))
                Console.WriteLine("true");

            else if (!queue.Contains(x))
                Console.WriteLine(queue.Min());
        }
    }
}
