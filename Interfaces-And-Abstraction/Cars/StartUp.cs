using Cars;

string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

string model = data[0];
string color = data[1];

if (data.Length == 2)
{
    ICar seat = new Seat(model, color);
    Console.WriteLine(seat.ToString());
}
else if (data.Length == 3)
{
    int batery = int.Parse(data[2]);

    ICar tesla = new Tesla(model, color, batery);
    Console.WriteLine(tesla.ToString());
}