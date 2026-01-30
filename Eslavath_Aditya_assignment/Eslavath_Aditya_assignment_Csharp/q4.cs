using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Eslavath_Aditya_assignment_Csharp
{
    class car1
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
    }


    internal class q4
    {
        static void WriteJson(List<car1> cars)
        {
            string json = JsonSerializer.Serialize(cars);
            File.WriteAllText("cars.json", json);
        }

        static List<car1> ReadJson()
        {
            string json = File.ReadAllText("cars.json");
            return JsonSerializer.Deserialize<List<car1>>(json);
        }

        static void PrintCars(List<car1> cars)
        {
            foreach (car1 c in cars)
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Year + " " + c.Price);
            }
        }

        static void Main(string[] args)
        {
            List<car1> cars = new List<car1>()
            {
                new car1{ Make="Toyota", Model="Innova", Year=2022, Price=2500000 },
                new car1{ Make="Honda", Model="City", Year=2021, Price=1500000 },
                new car1{ Make="Hyundai", Model="Creta", Year=2023, Price=1800000 },
                new car1{ Make="Tata", Model="Nexon", Year=2022, Price=1200000 },
                new car1{ Make="Kia", Model="Seltos", Year=2023, Price=1900000 }
            };

            WriteJson(cars);

            List<car1> newCars = ReadJson();

            PrintCars(newCars);
        }
    }
}
