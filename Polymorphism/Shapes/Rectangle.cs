﻿namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; set; }

        public double Width { get; set; }

        public override double CalculateArea()
        {
            double area = this.Height * this.Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }

        public override string Draw()
        {
            return $"{base.Draw()}Rectangle..." ;

            DrawLine(this.Width, '*', '*');

            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }

            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
