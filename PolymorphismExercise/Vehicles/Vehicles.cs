using System;

namespace Vehicles
{
    public abstract class Vehicles
    {
        private double fuel;
        protected Vehicles(double fuel, double fuelConsumption, double tankCapacity, double airConditionModifier)
        {
            this.TankCapacity = tankCapacity;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionModifier = airConditionModifier;
        }

        private double AirConditionModifier { get; set; }

        public double Fuel
        {
            get => this.fuel;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuel = 0;
                }
                else
                {
                    this.fuel = value;
                }
            }
        }

        public double FuelConsumption { get; private set; }


        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            //Calculate the required fuel

            double requiredFuel = (this.FuelConsumption + this.AirConditionModifier) * distance;

            //Check if the require fuel is enough

            if (requiredFuel > this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            //Fuel modify

            this.Fuel -= requiredFuel;
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.Fuel + amount > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }
    }
}
