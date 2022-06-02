using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string secondCmd = command.Split()[1];
                string argument = command.Split()[2];

                Predicate<string> predicate = GetPredicate(command);

                if (command.StartsWith("Double"))
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        string person = people[i];

                        if (predicate(person))
                        {
                            people.Insert(i + 1, person);
                            i++;
                        }
                    }
                }
                else if (command.StartsWith("Remove"))
                {
                    people.RemoveAll(predicate);
                }

                command = Console.ReadLine();
            }

            if (people.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string command)
        {
            string secondCmd = command.Split()[1];
            string argument = command.Split()[2];

            Predicate<string> predicate = null;

            if (secondCmd == "StartsWith")
            {
                predicate = name => name.StartsWith(argument);
            }
            else if (secondCmd == "EndsWith")
            {
                predicate = name => name.EndsWith(argument);
            }
            else if (secondCmd == "Length")
            {
                predicate = name => name.Length == int.Parse(argument);
            }

            return predicate;
        }
    }
}
