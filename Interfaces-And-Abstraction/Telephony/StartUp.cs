using Telephony;

string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Smartphone smartphone = new Smartphone();
StationaryPhone stationaryPhone = new StationaryPhone();

foreach (var number in numbers)
{
	try
	{
        string result = number.Length == 10
        ? smartphone.Call(number)
        : stationaryPhone.Call(number);

        Console.WriteLine(result);
    }
	catch (InvalidOperationException ex)
	{
        Console.WriteLine(ex.Message);
    }
}

foreach (var url in urls)
{
    try
    {
        string result = smartphone.Browse(url);

        Console.WriteLine(result);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}