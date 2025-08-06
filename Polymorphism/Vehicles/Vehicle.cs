namespace Vehicles
{
    abstract class Vehicle
    {
        private double fuel;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double airConditioner)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
            this.AirConditioner = airConditioner;
        }

        protected double AirConditioner { get; set; }

        public double FuelQuantity
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

        public double FuelConsumptionPerKm { get; private set; }

        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            double requiredFuel = (this.FuelConsumptionPerKm + this.AirConditioner) * distance;

            if (requiredFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= requiredFuel;
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
