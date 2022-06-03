using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> database = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] data = command.Split();

                if (data[1] == "joined")
                {
                    if (database.ContainsKey(data[0]) == false)
                    {
                        database.Add(data[0], new Dictionary<string, HashSet<string>>());
                        database[data[0]].Add("followers", new HashSet<string>());
                        database[data[0]].Add("following", new HashSet<string>());
                    }
                }
                else if (data[1] == "followed")
                {
                    string member = data[2];

                    if (data[0] != member && database.ContainsKey(data[0]) && database.ContainsKey(member))
                    {
                        database[data[0]]["following"].Add(member);
                        database[member]["followers"].Add(data[0]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {database.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in database.OrderByDescending(v => v.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}
