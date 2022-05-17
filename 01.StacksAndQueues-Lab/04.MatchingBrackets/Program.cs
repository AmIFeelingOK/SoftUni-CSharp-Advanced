using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expr.Length; i++)
            {
                char chr = expr[i];

                if (chr == '(')
                {
                    stack.Push(i);
                }
                else if (chr == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpr = expr.Substring(startIndex, endIndex - startIndex + 1);

                    Console.WriteLine(subExpr);
                }
            }
        }
    }
}
