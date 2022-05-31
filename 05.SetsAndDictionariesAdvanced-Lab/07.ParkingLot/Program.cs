using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] argCmd = command.Split(", ");

                if (argCmd[0] == "IN")
                    cars.Add(argCmd[1]);
                else if (argCmd[0] == "OUT")
                    cars.Remove(argCmd[1]);

                command = Console.ReadLine();
            }

            if (cars.Count <= 0)
                Console.WriteLine("Parking Lot is Empty");
            else
                Console.WriteLine(string.Join("\n", cars));
        }
    }
}
