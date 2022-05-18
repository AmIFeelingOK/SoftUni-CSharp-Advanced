using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    foreach (var customer in queue)
                    {
                        Console.WriteLine(customer);
                    }

                    queue.Clear();
                    command = Console.ReadLine();
                    continue;
                }
                
                queue.Enqueue(command);
                command = Console.ReadLine();                
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
