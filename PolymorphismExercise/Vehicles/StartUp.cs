using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicles car = CreateVehicle();
            Vehicles truck = CreateVehicle();
            Vehicles bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgsStrings = Console.ReadLine().Split();

                string command = commandArgsStrings[0];
                string vehicleType = commandArgsStrings[1];
                double parameter = double.Parse(commandArgsStrings[2]);

                try
                {
                    if (vehicleType == nameof(Car))
                    {
                        ProcessCommand(car, command, parameter);
                    }
                    else if (vehicleType == nameof(Bus))
                    {
                        ProcessCommand(bus, command, parameter);
                    }
                    else
                    {
                        ProcessCommand(truck, command, parameter);
                    }
                }
                catch (Exception ex)
                when(ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        public static void ProcessCommand(Vehicles vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {

                vehicle.Drive(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");


            }
            else if (command == "DriveEmpty")
            {
                ((Bus) vehicle).DriveEmpty(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else
            {
                vehicle.Refuel(parameter);
            }
        }

        private static Vehicles CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();

            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumption = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);
            Vehicles vehicles = null;

            if (type == nameof(Car))
            {
                vehicles = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicles = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicles = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            return vehicles;
        }
    }
}
