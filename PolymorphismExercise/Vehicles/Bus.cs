using System;
namespace Vehicles
{
    public class Bus : Vehicles
    {
        private const double BusAirConditionModifier = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity)
            : base(fuel, fuelConsumption, tankCapacity, BusAirConditionModifier)
        {

        }

        public void DriveEmpty(double distance)
        {
            //Calculate the required fuel

            double requiredFuel = this.FuelConsumption * distance;

            //Check if the require fuel is enough

            if (requiredFuel > this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            //Fuel modify

            this.Fuel -= requiredFuel; 
        }
    }
}
