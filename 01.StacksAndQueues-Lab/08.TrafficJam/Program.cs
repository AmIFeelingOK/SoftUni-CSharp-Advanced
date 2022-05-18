using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            int carsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            carsPassed++;
                        }
                    }

                }
                else if (command == "end")
                {
                    Console.WriteLine($"{carsPassed} passed the crossroads.");
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}
