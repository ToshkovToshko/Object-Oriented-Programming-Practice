namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = batery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            return "Tesla engine - start!";
        }

        public string Stop()
        {
            return "Breaaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Bateries.";
        }
    }
}
