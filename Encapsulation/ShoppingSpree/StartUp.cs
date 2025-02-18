using ShoppingSpree;

var people = ReadPeople();
var products = ReadProducts();

while (true)
{
    var line = Console.ReadLine();

    if (line == "END")
    {
        break;
    }

    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    var personName = parts[0];
    var productName = parts[1];

    var person = people[personName];
    var product = products[productName];

    try
    {
        person.AddProduct(product);

        Console.WriteLine($"{person.Name} bought {product.Name}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex);
    }
}

foreach (var person in people.Values)
{
    Console.WriteLine(person.ToString());
}


static Dictionary<string, Product> ReadProducts()
{
    var result = new Dictionary<string, Product>();

    var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

    foreach (var part in parts)
    {
        var productData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

        var name = productData[0];
        var cost = decimal.Parse(productData[1]);

        result[name] = new Product(name, cost);
    }

    return result;
}

static Dictionary<string, Person> ReadPeople()
{
    var result = new Dictionary<string, Person>();

    var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

    foreach (var part in parts)
    {
        var personData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

        var name = personData[0];
        var money = decimal.Parse(personData[1]);

        result[name] = new Person(name, money);
    }

    return result;
}