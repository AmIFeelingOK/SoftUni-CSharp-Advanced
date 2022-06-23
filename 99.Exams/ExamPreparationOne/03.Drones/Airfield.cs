using System;
using System.Collections.Generic;
using System.Linq;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        public int Count => Drones.Count(x => x.Available);

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name)
                || string.IsNullOrEmpty(drone.Brand)
                || drone.Range < 5
                || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (Drones.Count >= Capacity)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            int count = Drones.RemoveAll(x => x.Name == name);
            return count > 0;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.RemoveAll(x => x.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = Drones.FirstOrDefault(x => x.Name == name);

            if (drone == null)
            {
                return null;
            }
            drone.Available = false;

            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = Drones.Where(x => x.Range >= range).ToList();

            foreach (var drone in drones)
            {
                drone.Available = false;
            }
            return drones;
        }

        public string Report()
        {
            var availableDrones = Drones.Where(x => x.Available == true);

            return $"Drones available at {Name}:" + Environment.NewLine + string.Join(Environment.NewLine, availableDrones);
        }
    }
}
