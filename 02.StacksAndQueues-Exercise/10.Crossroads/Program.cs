﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindowTime = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int counter = 0;

            while (command != "END")
            {
                int greenLightLeft = greenLight;
                int freeWindowLeft = freeWindowTime;

                if (command == "green")
                {
                    while (greenLightLeft > 0 && cars.Any())
                    {
                        string car = cars.Dequeue();
                        greenLightLeft -= car.Length;
                        if (greenLightLeft >= 0)
                        {
                            counter++;
                        }
                        else
                        {
                            freeWindowLeft += greenLightLeft;
                            if (freeWindowLeft < 0)
                            {
                                Console.WriteLine($"A crash happened!\n{car} was hit at {car[car.Length + freeWindowLeft]}.");
                                return;
                            }

                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Everyone is safe.\n{counter} total cars passed the crossroads.");
        }
    }
}