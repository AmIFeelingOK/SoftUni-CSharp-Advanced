using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> reverse = i =>
            {
                for (int j = 0; j < i.Length / 2; j++)
                {
                    int swap = i[j];
                    i[j] = i[i.Length - 1 - j];
                    i[i.Length - 1 - j] = swap;
                }
            };

            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divNum = int.Parse(Console.ReadLine());

            Predicate<int> predicate = i => i % divNum != 0;

            reverse(nums);

            Console.WriteLine(string.Join(" ", nums.ToList().FindAll(predicate)));
        }
    }
}
