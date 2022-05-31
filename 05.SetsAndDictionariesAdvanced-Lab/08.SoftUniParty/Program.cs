using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "PARTY")
                    break;

                guests.Add(command);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                    break;

                if (guests.Contains(command))
                    guests.Remove(command);
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
                if (char.IsDigit(guest[0]))
                    Console.WriteLine(guest);

            foreach (var guest in guests)
                if (char.IsLetter(guest[0]))
                    Console.WriteLine(guest);
        }
    }
}
