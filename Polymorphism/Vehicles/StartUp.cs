using Vehicles;

Vehicle car = CreateVehicle();
Vehicle truck = CreateVehicle();
Vehicle bus = CreateVehicle();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];
    string type = commands[1];
    double ammount = double.Parse(commands[2]);

    try
    {
        if (type == nameof(Car))
        {
            ProcessCommand(car, command, ammount);
        }
        else if (type == nameof(Truck))
        {
            ProcessCommand(truck, command, ammount);
        }
        else if (type == nameof(Bus))
        {
            ProcessCommand(bus, command, ammount);
        }
    }
    catch (Exception ex)
        when(ex is InvalidOperationException || ex is ArgumentException)
    {
        Console.WriteLine(ex.Message);
    }

    
}

Console.WriteLine(car);
Console.WriteLine(truck);
Console.WriteLine(bus);

static Vehicle CreateVehicle()
{
    string[] vehicleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string type = vehicleInfo[0];
    double fuelQuantity = double.Parse(vehicleInfo[1]);
    double fuelConsumption = double.Parse(vehicleInfo[2]);
    double tankCapacity = double.Parse(vehicleInfo[3]);

    Vehicle vehicle = null;

    if (type == nameof(Car))
    {
        vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
    }
    else if (type == nameof(Truck))
    {
        vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
    }
    else if (type == nameof(Bus))
    {
        vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
    }

    return vehicle;
}

static void ProcessCommand(Vehicle vehicle, string command, double parameter)
{
    if (command == "Drive")
    {
        vehicle.Drive(parameter);

        Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
    }
    else if (command == "Refuel")
    {
        vehicle.Refuel(parameter);
    }
    else if (command == "DriveEmpty")
    {
        ((Bus)vehicle).DriveEmpty(parameter);

        Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
    }
}