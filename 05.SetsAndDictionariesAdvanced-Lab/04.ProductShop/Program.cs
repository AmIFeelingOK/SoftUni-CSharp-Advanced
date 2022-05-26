using System;
using System.Collections.Generic;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string line = Console.ReadLine();
                
                if (line == "Revision")
                {
                    PrintPrices(prices);
                    break;
                }

                string[] input = line.Split(", ");
                string shop = input[0];
                string product = input[1];
                decimal price = decimal.Parse(input[2]);

                AddProduct(prices, shop, product, price);
            }
        }

        private static void AddProduct(Dictionary<string, Dictionary<string, decimal>> prices, string shop, string product, decimal price)
        {
            if (!prices.ContainsKey(shop))
            {
                prices.Add(shop, new Dictionary<string, decimal>());
                prices[shop][product] = price;
            }
        }

        private static void PrintPrices(Dictionary<string, Dictionary<string, decimal>> prices)
        {
            foreach (var shopAndProducts in prices)
            {
                string shopName = shopAndProducts.Key;
                Console.WriteLine(shopName + "->");
                var products = shopAndProducts.Value;

                foreach (var productAndPrice in products)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value}");
                }
            }
        }
       
    }
}
