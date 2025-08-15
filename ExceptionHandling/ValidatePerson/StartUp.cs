using ValidatePerson;

//Test with invalid name
try
{
	Person person = new Person(string.Empty, "Ivanov", 15);
}
catch (FormatException ex)
{
    Console.WriteLine($"Exception thrown: {0}", ex.Message);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Exception thrown: {0}", ex.Message);
}

//Test with invalid age
//try
//{
//    Person person = new Person("Ivan", "Ivanov", -15);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Exception thrown: {0}", ex.Message);
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Exception thrown: {0}", ex.Message);
//}