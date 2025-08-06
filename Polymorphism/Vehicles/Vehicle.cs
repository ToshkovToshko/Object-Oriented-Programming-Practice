namespace Vehicles
{
    abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double airConditioner)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption;
            this.AirConditioner = airConditioner;
        }

        private double AirConditioner { get; set; }

        public double FuelQuantity { get; private set; }

        public double FuelConsumptionPerKm { get; private set; }

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
            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
