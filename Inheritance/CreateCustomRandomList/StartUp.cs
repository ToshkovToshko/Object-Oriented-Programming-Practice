using CreateCustomRandomList;

RandomList list = new RandomList();

list.Add("First");
list.Add("Second");
list.Add("Third");
list.Add("Fourth");
list.Add("Fifth");

foreach (var item in list)
{
    Console.WriteLine(item);
}

list.Remove("Second");

foreach (var item in list)
{
    Console.WriteLine(item);
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(list.RandomString());
}
