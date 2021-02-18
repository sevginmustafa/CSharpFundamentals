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

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "end")
            {
                var text = input.Split('/');
                string type = text[0];
                string brand = text[1];
                string model = text[2];

                if (type == "Truck")
                {
                    int weight = int.Parse(text[3]);
                    Truck currentTruck = new Truck(brand, model, weight);
                    trucks.Add(currentTruck);
                }
                else
                {
                    int horsePower = int.Parse(text[3]);
                    Car currentCar = new Car(brand, model, horsePower);
                    cars.Add(currentCar);
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(car.ToString());
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine(truck.ToString());
                }
            }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }

            public override string ToString()
            {
                return $"{Brand}: {Model} - {Weight}kg";
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsePower;
            }

            public override string ToString()
            {
                return $"{Brand}: {Model} - {HorsePower}hp";
            }
        }
    }
}
