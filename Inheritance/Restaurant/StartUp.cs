using Restaurant;

string input = Console.ReadLine();

string[] data = input.Split();

string name  = data[0];
decimal price = decimal.Parse(data[1]);


if (name == "Coffee")
{
    double caffeine = double.Parse(data[2]);

    Coffee coffee = new Coffee(name, caffeine);
    Console.WriteLine($"{coffee.Name}, {coffee.Price}, {coffee.Caffeine}, {coffee.Mililiters}");
}
else if (name == "Soup")
{
    double grams = double.Parse(data[2]);

    Soup soup = new Soup(name, price, grams);

    Console.WriteLine($"{soup.Name}, {soup.Price}, {soup.Grams}");
}