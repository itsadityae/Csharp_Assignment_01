using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;
    }

    class CarCatalog
    {
        List<Car> cars = new List<Car>();

        public void AddCar()
        {
            Car c = new Car();
            Console.Write("Enter Make: ");
            c.Make = Console.ReadLine();
            Console.Write("Enter Model: ");
            c.Model = Console.ReadLine();
            Console.Write("Enter Year: ");
            c.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            c.Price = double.Parse(Console.ReadLine());
            cars.Add(c);
        }

        public void ModifyCar()
        {
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            foreach (Car c in cars)
            {
                if (c.Model == model)
                {
                    Console.Write("Enter New Price: ");
                    c.Price = double.Parse(Console.ReadLine());
                    return;
                }
            }
        }

        public void SearchCar()
        {
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            foreach (Car c in cars)
            {
                if (c.Model == model)
                {
                    Console.WriteLine(c.Make + " " + c.Model + " " + c.Year + " " + c.Price);
                    return;
                }
            }
        }

        public void ListCars()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c.Make + " " + c.Model + " " + c.Year + " " + c.Price);
            }
        }

        public void DeleteCar()
        {
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == model)
                {
                    cars.RemoveAt(i);
                    return;
                }
            }
        }
    }

    internal class q3
    {
        static void Main(string[] args)
        {
            CarCatalog catalog = new CarCatalog();
            int choice;

            do
            {
                Console.WriteLine("1.Add  2.Modify  3.Search  4.List  5.Delete  6.Quit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: catalog.AddCar(); break;
                    case 2: catalog.ModifyCar(); break;
                    case 3: catalog.SearchCar(); break;
                    case 4: catalog.ListCars(); break;
                    case 5: catalog.DeleteCar(); break;
                }
            }
            while (choice != 6);
        }
    }
}
