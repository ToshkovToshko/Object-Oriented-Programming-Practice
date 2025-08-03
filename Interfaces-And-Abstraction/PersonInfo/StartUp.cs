using PersonInfo;

//Code for test Rebel and Citizen logic

int n = int.Parse(Console.ReadLine());

List<Citizen> citizens = new List<Citizen>();
List<Rebel> rebels = new List<Rebel>();

for (int i = 0; i <= n; i++)
{
    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

	string name = input[0];
	int age = int.Parse(input[1]);

	if (input.Length == 4)
	{
		string id = input[2];
		string birthdate = input[3];

		Citizen citizen = new Citizen(name, age, id, birthdate);
		citizens.Add(citizen);
	}
	else
	{
		string group = input[2];

		Rebel rebel = new Rebel(name, age, group);
		rebels.Add(rebel);
	}
}

string names = Console.ReadLine();

while (names != "End")
{
	foreach (var item in citizens)
	{
		if (item.Name == names)
		{
			item.BuyFood();
		}
	}

	foreach (var item in rebels)
	{
        if (item.Name == names)
        {
            item.BuyFood();
        }
    }

    names = Console.ReadLine();
}

foreach (var item in citizens)
{
    Console.WriteLine(item.Food);
}

foreach (var item in rebels)
{
    Console.WriteLine(item.Food);
}


// Code for test the rest of logic

//string input = Console.ReadLine();

//List<Citizen> citizens = new List<Citizen>();
//List<Robot> robots = new List<Robot>();
//List<Pet> pets = new List<Pet>();

//while (input != "End")
//{
//    string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//    string type = data[0];

//    if (type == "Citizen")
//    {
//        string name = data[1];
//        int age = int.Parse(data[2]);
//        string id = data[3];
//        string birthdate = data[4];

//        Citizen citizen = new Citizen(name, age, id, birthdate);
//        citizens.Add(citizen);
//    }
//    else if(type == "Robot")
//    {
//        string model = data[1];
//        string id = data[2];

//        Robot robot = new Robot(model, id);
//        robots.Add(robot);
//    }
//    else if (type == "Pet")
//    {
//        string name = data[1];
//        string birthdate = data[2];

//        Pet pet = new Pet(name, birthdate);
//        pets.Add(pet);
//    }

//    input = Console.ReadLine();
//}

//foreach (var item in citizens)
//{
//    Console.WriteLine($"The citizen {item.Name} is {item.Age} years old, has Id: {item.Id} and the birthdate is at {item.Birthdate}.");
//}

//foreach (var item in robots)
//{
//    Console.WriteLine($"The robot {item.Model} with Id: {item.Id} is added.");
//}

//foreach (var item in pets)
//{
//    Console.WriteLine($"The pet {item.Name} with birthdate {item.Birthdate} is added.");
//}