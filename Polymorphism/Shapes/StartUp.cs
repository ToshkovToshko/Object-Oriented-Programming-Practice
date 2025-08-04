using Shapes;

string input = Console.ReadLine();

while (input != "End")
{
    string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string type = data[0];

    Shape shape = null;

    if (type == "Circle")
    {
        double radius = double.Parse(data[1]);

        shape = new Circle(radius);
    }
    if (type == "Rectangle")
    {
        double height = double.Parse(data[1]);
        double width = double.Parse(data[2]);

        shape = new Rectangle(height, width);
    }

    Console.WriteLine(shape.CalculateArea());
    Console.WriteLine(shape.CalculatePerimeter());
    Console.WriteLine(shape.Draw());

    input = Console.ReadLine();
}