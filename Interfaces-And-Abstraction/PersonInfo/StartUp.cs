using PersonInfo;

string input = Console.ReadLine();

List<Citizen> citizens = new List<Citizen>();
List<Robot> robots = new List<Robot>();

while (input != "End")
{
    string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (data.Length == 4)
    {
        string name = data[0];
        int age = int.Parse(data[1]);
        string id = data[2];
        string birthdate = data[3];

        Citizen citizen = new Citizen(name, age, id, birthdate);
        citizens.Add(citizen);
    }
    else
    {
        string model = data[0];
        string id = data[1];

        Robot robot = new Robot(model, id);
        robots.Add(robot);
    }

    input = Console.ReadLine();
}

string fakeId = Console.ReadLine();

List<string> fakeIds = new List<string>();

foreach (var item in citizens)
{
    if (item.Id.EndsWith(fakeId))
    {
        fakeIds.Add(item.Id);
    }
}

foreach (var item in robots)
{
    if (item.Id.EndsWith(fakeId))
    {
        fakeIds.Add(item.Id);
    }
}

foreach (var item in fakeIds)
{
    Console.WriteLine(item);
}