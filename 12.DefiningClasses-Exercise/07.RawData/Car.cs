using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tires> Tires { get; set; }


        public Car(string model, Engine engine, List<Tires> tires, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Tires = tires;
            Cargo = cargo;
        }
        public override string ToString()
        {
            return Model;
        }
    }
}
