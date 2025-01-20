namespace NeedForSpeed
{
    public class Vehicle
    {
        private double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, HP: {this.HorsePower}, Fuel rest: {this.Fuel}";
        }
    }
}
