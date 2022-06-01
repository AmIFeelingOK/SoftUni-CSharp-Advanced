using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (command == "add")
                        nums[i] += 1;
                    else if (command == "multiply")
                        nums[i] *= 2;
                    else if (command == "subtract")
                        nums[i] -= 1;
                    else if (command == "print")
                    {
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
