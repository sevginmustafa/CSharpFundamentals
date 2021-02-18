using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Vehicle> vehicles = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                Vehicle vehicle = new Vehicle(command[0], command[1], command[2], double.Parse(command[3]));
                vehicles.Add(vehicle);
            }

            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                int index = vehicles.FindIndex(x => x.Model == model);
                Console.WriteLine(vehicles[index].ToString());
                model = Console.ReadLine();
            }

            var cars = vehicles.FindAll(x => x.Type == "car");
            var carHorsePower = cars.Sum(x => x.HorsePower);
            var carsAverageHorsePower = carHorsePower / cars.Count;

            var trucks = vehicles.FindAll(x => x.Type == "truck");
            var truckHorsePower = trucks.Sum(x => x.HorsePower);
            var trucksAverageHorsePower = truckHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                carsAverageHorsePower = 0;
            }
            if (trucks.Count == 0)
            {
                trucksAverageHorsePower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
        }

        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model, string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();

                if (Type == "car")
                {
                    result.AppendLine("Type: Car");
                }
                else
                {
                    result.AppendLine("Type: Truck");
                }
                result.AppendLine("Model: " + Model);
                result.AppendLine("Color: " + Color);
                result.AppendLine("Horsepower: " + HorsePower);

                return result.ToString().TrimEnd();
            }
        }
    }
}
