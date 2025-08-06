namespace Vehicles
{
    class Truck : Vehicle
    {
        private const double airConditioner = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption, airConditioner)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);
        }
    }
}
