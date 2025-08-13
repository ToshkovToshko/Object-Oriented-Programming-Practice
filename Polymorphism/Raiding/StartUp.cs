using Raiding;

int n = int.Parse(Console.ReadLine());

List<BaseHero> heroes = new List<BaseHero>();

while (heroes.Count < n)
{
    string name = Console.ReadLine();
    string type = Console.ReadLine();

    BaseHero hero = CreateHero(type, name);

    if (hero == null)
    {
        Console.WriteLine("Invalid hero");
        continue;
    }

    heroes.Add(hero);
}

int bossPower = int.Parse(Console.ReadLine());

foreach (var hero in heroes)
{
    Console.WriteLine(hero.CastAbility());
    bossPower -= hero.Power;
}

if (bossPower <= 0)
{
    Console.WriteLine("Victory!");
}
else
{
    Console.WriteLine("Defeat...");
}


static BaseHero CreateHero(string type, string name)
{
    BaseHero hero = null;

    if (type == "Druid")
    {
        hero = new Druid(name);
    }
    else if (type == "Paladin")
    {
        hero = new Paladin(name);
    }
    else if (type == "Rogue")
    {
        hero = new Rogue(name);
    }
    else if (type == "Warrior")
    {
        hero = new Warrior(name);
    }

    return hero;
}