using PlayersAndMonsters;

string username = Console.ReadLine();
int level = int.Parse(Console.ReadLine());


SoulMaster soulMaster = new SoulMaster(username, level);

Console.WriteLine(soulMaster.ToString());