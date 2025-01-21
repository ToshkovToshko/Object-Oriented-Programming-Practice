using PersonsInfoWithSalary;

int n = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    Person person = new Person(input[0],
                            input[1],
                            int.Parse(input[2]),
                            decimal.Parse(input[3]));

    persons.Add(person);
}

var parcentage = decimal.Parse(Console.ReadLine());

persons.ForEach(p => p.IncreaseSalary(parcentage));

persons.ForEach(p => Console.WriteLine(p.ToString()));