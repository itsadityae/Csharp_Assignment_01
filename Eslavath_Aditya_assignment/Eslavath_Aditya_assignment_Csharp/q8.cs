using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    class Location
    {
        public string PlaceName { get; set; }
        public string Elevation { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string WeatherType { get; set; }
    }

    internal class q8
    {
        static void Main(string[] args)
        {
            List<Location> locations = new List<Location>();

            locations.Add(new Location { PlaceName = "Hyderabad", Elevation = "542m", Longitude = 78.4867, Latitude = 17.3850, WeatherType = "Hot" });
            locations.Add(new Location { PlaceName = "Delhi", Elevation = "216m", Longitude = 77.1025, Latitude = 28.7041, WeatherType = "Cold" });
            locations.Add(new Location { PlaceName = "Chennai", Elevation = "6m", Longitude = 80.2707, Latitude = 13.0827, WeatherType = "Humid" });

            Console.Write("Enter Place Name: ");
            string name = Console.ReadLine();

            bool found = false;

            foreach (Location loc in locations)
            {
                if (loc.PlaceName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Elevation: " + loc.Elevation);
                    Console.WriteLine("Longitude: " + loc.Longitude);
                    Console.WriteLine("Latitude: " + loc.Latitude);
                    Console.WriteLine("WeatherType: " + loc.WeatherType);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Not Found Message");
            }
        }
    }
}
