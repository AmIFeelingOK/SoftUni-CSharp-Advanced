﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; } = "n/a";
        public string Efficiency { get; set; } = "n/a";

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public override string ToString()
        {
            return $"{Model}:\n    Power: {Power}\n    Displacement: {Displacement}\n    Efficiency: {Efficiency}";
        }
    }
}
