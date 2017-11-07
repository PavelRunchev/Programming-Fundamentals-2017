using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }

    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }

    class VehicleCatalogue
    {
        static void Main()
        {
            List<Car> dataCars = new List<Car>();
            List<Truck> dataTrucks = new List<Truck>();

            AddVehicles(dataTrucks, dataCars);
            SearchVehiclesAndPritHim(dataTrucks, dataCars);

            double averageTrucksHorsePower = 0;
            double averageCarsHorsePower = 0;
            if (dataTrucks.Count > 0)
            {
                averageTrucksHorsePower = dataTrucks.Average(a => a.Horsepower);
            }

            if(dataCars.Count > 0)
            {
                averageCarsHorsePower = dataCars.Average(c => c.Horsepower);
            }
    
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:f2}.");           
        }

        private static void SearchVehiclesAndPritHim(List<Truck> dataTrucks, List<Car> dataCars)
        {
            string vehicleCatalogueInput = Console.ReadLine();
            while (vehicleCatalogueInput != "Close the Catalogue")
            {
                if (dataTrucks.Any(t => t.Model == vehicleCatalogueInput))
                {
                    var currentTruck = dataTrucks.FirstOrDefault(m => m.Model == vehicleCatalogueInput);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {currentTruck.Model}");
                    Console.WriteLine($"Color: {currentTruck.Color}");
                    Console.WriteLine($"Horsepower: {currentTruck.Horsepower}");
                }
                else if (dataCars.Any(c => c.Model == vehicleCatalogueInput))
                {
                    var currentCar = dataCars.FirstOrDefault(c => c.Model == vehicleCatalogueInput);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {currentCar.Model}");
                    Console.WriteLine($"Color: {currentCar.Color}");
                    Console.WriteLine($"Horsepower: {currentCar.Horsepower}");
                }
                vehicleCatalogueInput = Console.ReadLine();
            }
        }

        private static void AddVehicles(List<Truck> dataTrucks, List<Car> dataCars)
        {
            var input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0].ToLower();
                string model = tokens[1];
                string color = tokens[2];
                int horsepower = int.Parse(tokens[3]);
                if (type == "truck")
                {
                    Truck truck = new Truck();
                    truck.Model = model;
                    truck.Color = color;
                    truck.Horsepower = horsepower;
                    dataTrucks.Add(truck);
                }
                else if (type == "car")
                {
                    Car car = new Car();
                    car.Model = model;
                    car.Color = color;
                    car.Horsepower = horsepower;
                    dataCars.Add(car);
                }

                input = Console.ReadLine();
            }
        }
    }
}
