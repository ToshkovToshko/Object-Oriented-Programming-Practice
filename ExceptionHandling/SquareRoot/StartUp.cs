int number = 0;

try
{
	number = int.Parse(Console.ReadLine());

	if (number < 0)
	{
		throw new ArgumentException("The number cannot be a negative number");
	}

    Console.WriteLine(CalculateNumber(number));
}
catch (ArgumentException ex)
{
    Console.WriteLine("Please insert valid number!");

    number = int.Parse(Console.ReadLine());

    Console.WriteLine(CalculateNumber(number));
}
finally
{
    Console.WriteLine("Good bye");
}

static double CalculateNumber(int number)
{
    double squareRoot = Math.Sqrt((double)number);

    return squareRoot;
}