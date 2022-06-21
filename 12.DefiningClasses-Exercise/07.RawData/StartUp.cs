using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                string model = data.Split()[0];
                int engineSpeed = int.Parse(data.Split()[1]);
                int enginePower = int.Parse(data.Split()[2]);
                int cargoWeight = int.Parse(data.Split()[3]);
                string cargoType = data.Split()[4];
                double tireOnePressure = double.Parse(data.Split()[5]);
                int tireOneAge = int.Parse(data.Split()[6]);
                double tireTwoPressure = double.Parse(data.Split()[7]);
                int tireTwoAge = int.Parse(data.Split()[8]);
                double tireThreePressure = double.Parse(data.Split()[9]);
                int tireThreeAge = int.Parse(data.Split()[10]);
                double tireFourPressure = double.Parse(data.Split()[11]);
                int tireFourAge = int.Parse(data.Split()[12]);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tires tireOne = new Tires(tireOneAge, tireOnePressure);
                Tires tireTwo = new Tires(tireTwoAge, tireTwoPressure);
                Tires tireThree = new Tires(tireThreeAge, tireThreePressure);
                Tires tireFour = new Tires(tireFourAge, tireFourPressure);

                List<Tires> tires = new List<Tires>();

                tires.Add(tireOne);
                tires.Add(tireTwo);
                tires.Add(tireThree);
                tires.Add(tireFour);

                Engine engine = new Engine(engineSpeed, enginePower);
                Car car = new Car(model, engine, tires, cargo);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                Console.WriteLine(string.Join("\n", cars.FindAll(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1))));
            }
            else if (command == "flammable")
            {
                Console.WriteLine(string.Join("\n", cars.FindAll(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250)));
            }
        }
    }
}
