using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> deviders = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .Distinct()
                .ToList();

            List<int> nums = new List<int>();

            for (int i = 1; i <= n; i++)
                if (DevidersInfo(i, deviders))
                    nums.Add(i);

            Console.WriteLine(string.Join(" ", nums));
        }

        private static bool DevidersInfo(int n, List<int> deviders)
        {
            bool isTrue = true;

            foreach (int divaider in deviders)
                if (n % divaider != 0)
                    isTrue = false;

            return isTrue;
        }
    }
}
