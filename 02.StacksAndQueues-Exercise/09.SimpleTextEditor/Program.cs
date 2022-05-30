using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();

            Stack<string> textHistory = new Stack<string>();

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("1"))
                {
                    textHistory.Push(text.ToString());
                    string textForAdd = command.Split()[1];
                    text.Append(textForAdd);
                }
                else if (command.StartsWith("2"))
                {
                    textHistory.Push(text.ToString());
                    int count = int.Parse(command.Split()[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(command.Split()[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command.StartsWith("4"))
                {
                    text = new StringBuilder(textHistory.Pop());
                }

            }
        }
    }
}
