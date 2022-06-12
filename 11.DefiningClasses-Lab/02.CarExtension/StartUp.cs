using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            {
                car.Make = "Fiat";
                car.Model = "Brava";
                car.Year = 1997;
                car.FuelConsumption = 200;
                car.FuelQuantity = 200;
                car.Drive(2000);

                Console.WriteLine(car.WhoAmI());
            }            
        }
    }
}
