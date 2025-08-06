using Vehicles;

Vehicle car = CreateVehicle();
Vehicle truck = CreateVehicle();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];
    string type = commands[1];
    double ammount = double.Parse(commands[2]);

    if (command == "Drive")
    {
        try
        {
            if (type == nameof(Car))
            {
                car.Drive(ammount);
            }
            else if (type == nameof(Truck))
            {
                truck.Drive(ammount);
            }

            Console.WriteLine($"{type} travelled {ammount} km");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    else if (command == "Refuel")
    {
        if (type == nameof(Car))
        {
            car.Refuel(ammount);
        }
        else if (type == nameof(Truck))
        {
            truck.Refuel(ammount);
        }
    }
}

Console.WriteLine(car);
Console.WriteLine(truck);

static Vehicle CreateVehicle()
{
    string[] vehicleInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string type = vehicleInfo[0];
    double fuelQuantity = double.Parse(vehicleInfo[1]);
    double fuelConsumption = double.Parse(vehicleInfo[2]);

    Vehicle vehicle = null;

    if (type == nameof(Car))
    {
        vehicle = new Car(fuelQuantity, fuelConsumption);
    }
    else if (type == nameof(Truck))
    {
        vehicle = new Truck(fuelQuantity, fuelConsumption);
    }

    return vehicle;
}