namespace Vehicles 
{
    class Bus : Vehicle
    {
        private const double busAirConditioner = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, busAirConditioner)
        {
        }

        public void DriveEmpty(double distance)
        {
            double requiredFuel = this.FuelConsumptionPerKm * distance;

            if (requiredFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= requiredFuel;
        }

    }
}
