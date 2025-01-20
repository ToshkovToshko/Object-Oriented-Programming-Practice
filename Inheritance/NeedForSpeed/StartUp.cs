using NeedForSpeed;

int horsePower = int.Parse(Console.ReadLine());
double fuel = double.Parse(Console.ReadLine());
double kilometers = double.Parse(Console.ReadLine());

RaceMotorcycle raceMoto = new RaceMotorcycle(horsePower, fuel);

raceMoto.Drive(kilometers);

Console.WriteLine(raceMoto.ToString());