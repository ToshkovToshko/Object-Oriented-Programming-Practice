namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double with, double height)
        {
            this.Length = length;
            this.Width = with;
            this.Height = height;
        }

        public double Length 
        {
            get => this.length;
            private set
            {
                ThrowInvalidSide(value, nameof(Length));

                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                ThrowInvalidSide(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                ThrowInvalidSide(value, nameof(Height));

                this.height = value;
            }
        }

        public double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        private void ThrowInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
