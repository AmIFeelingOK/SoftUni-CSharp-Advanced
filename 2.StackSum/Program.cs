using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while(true)
            {
                string[] cmd = Console.ReadLine().ToLower().Split();

                if (cmd[0] == "add")
                {
                    stack.Push(int.Parse(cmd[1]));
                    stack.Push(int.Parse(cmd[2]));
                }
                else if (cmd[0] == "remove")
                {
                    if (stack.Count >= int.Parse(cmd[1]))
                    {
                        for (int i = 0; i < int.Parse(cmd[1]); i++)
                            stack.Pop();
                    }
                }

                if (cmd[0] == "end")
                    break;
            }
            int sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
