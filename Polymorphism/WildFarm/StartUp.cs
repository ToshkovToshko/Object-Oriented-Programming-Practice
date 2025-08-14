using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

string input = Console.ReadLine();

List<Animal> animals = new List<Animal>();

while (input != "End")
{
    string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string[] foodData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    Animal animal = CreateAnimal(data);
    animals.Add(animal);

    Food food = CreateFood(foodData);

    Console.WriteLine(animal.ProduceSound());

    try
    {
        animal.Eat(food);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

foreach (var animal in animals)
{
    Console.WriteLine(animal);
}

static Animal CreateAnimal(string[] data)
{
    Animal animal = null;

    string type = data[0];
    string name = data[1];
    double weight = double.Parse(data[2]);

    if (type == "Hen")
    {
        int wingSize = int.Parse(data[3]);

        animal = new Hen(name, weight, wingSize);
    }
    else if (type == "Owl")
    {
        int wingSize = int.Parse(data[3]);

        animal = new Owl(name, weight, wingSize);
    }
    else if (type == "Mouse")
    {
        string livingRegion = data[3];

        animal = new Mouse(name, weight, livingRegion);
    }
    else if (type == "Cat")
    {
        string livingRegion = data[3];
        string breed = data[4];

        animal = new Cat(name, weight, livingRegion, breed);
    }
    else if (type == "Dog")
    {
        string livingRegion = data[3];

        animal = new Dog(name, weight, livingRegion);
    }
    else if (type == "Tiger")
    {
        string livingRegion = data[3];
        string breed = data[4];

        animal = new Tiger(name, weight, livingRegion, breed);
    }

    return animal;
}

static Food CreateFood(string[] data)
{
    Food food = null;

    string type = data[0];
    int quantity = int.Parse(data[1]);

    if (type == "Vegetable")
    {
        food = new Vegetable(quantity);
    }
    else if (type == "Fruit")
    {
        food = new Fruit(quantity);
    }
    else if (type == "Meat")
    {
        food = new Meat(quantity);
    }
    else if (type == "Seeds")
    {
        food = new Seeds(quantity);
    }

    return food;
}