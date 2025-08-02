namespace Cars
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return "Seat engine - start!";
        }

        public string Stop()
        {
            return "Breaaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}.";    
        }
    }
}
