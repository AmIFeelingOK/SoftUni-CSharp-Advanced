using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string color = input.Split(" -> ")[0];

                if (!wardrobe.ContainsKey(color))
                    wardrobe.Add(color, new Dictionary<string, int>());

                Dictionary<string, int> clothes = wardrobe[color];
                string[] inputClothes = input.Split(" -> ")[1].Split(",");

                foreach (var clothing in inputClothes)
                {
                    if (!clothes.ContainsKey(clothing))
                        clothes.Add(clothing, 1);
                    else
                        clothes[clothing]++;
                }
            }

            string searchedItem = Console.ReadLine();
            string searchedColor = searchedItem.Split()[0];
            string searchedClothing = searchedItem.Split()[1];

            foreach (var colorEntry in wardrobe)
            {
                Console.WriteLine($"{colorEntry.Key} clothes:");
                Dictionary<string, int> clothes = colorEntry.Value;

                foreach (var clothing in clothes)
                {
                    if (clothing.Key == searchedClothing && colorEntry.Key == searchedColor)
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    else
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
        }
    }
}
