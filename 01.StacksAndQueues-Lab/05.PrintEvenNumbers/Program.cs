using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Queue<int> inputStack = new Queue<int>(input);

            int counter = inputStack.Count;

            for (int i = 0; i < counter; i++)
            {
                if (inputStack.Peek() % 2 == 1)
                    inputStack.Dequeue();
                else
                    inputStack.Enqueue(inputStack.Dequeue());
            }

            Console.WriteLine(string.Join(", ", inputStack));
        }
    }
}
