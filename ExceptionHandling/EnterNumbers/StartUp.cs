using System;

int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
	ReadNumber(startNumber, endNumber);
}

static void ReadNumber(int startNumber, int endNumber)
{
	int currentNumber = int.Parse(Console.ReadLine());

	if (currentNumber < startNumber || currentNumber > endNumber)
	{
		throw new ArgumentOutOfRangeException($"The number should be in the range {startNumber} - {endNumber}");
	}
}