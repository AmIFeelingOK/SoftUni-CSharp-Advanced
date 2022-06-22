using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engineModels = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(engineData[0], int.Parse(engineData[1]));

                try
                {
                    if (Int32.TryParse(engineData[2], out _))
                    {
                        engine.Displacement = engineData[2];
                    }
                    else
                    {
                        engine.Efficiency = engineData[2];
                    }
                    if (Int32.TryParse(engineData[3], out _))
                    {
                        engine.Displacement = engineData[3];
                    }
                    else
                    {
                        engine.Efficiency = engineData[3];
                    }

                }
                catch (Exception)
                {
                }
                engineModels.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car currentCar = new Car(carInfo[0], engineModels.First(e => e.Model == carInfo[1]));
                try
                {
                    if (Int32.TryParse(carInfo[2], out _))
                    {
                        currentCar.Weight = carInfo[2];
                    }
                    else
                    {
                        currentCar.Color = carInfo[2];
                    }
                    if (Int32.TryParse(carInfo[3], out _))
                    {
                        currentCar.Weight = carInfo[3];
                    }
                    else
                    {
                        currentCar.Color = carInfo[3];
                    }
                }
                catch (Exception)
                {
                }
                cars.Add(currentCar);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
