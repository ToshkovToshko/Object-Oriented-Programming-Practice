using CreateCustomStackOfStrings;

CustomStack stack = new CustomStack();

stack.AddRange(new List<string>()
{
    "123",
    "456",
    "789",
    "Test"
});

foreach (var item in stack)
{
    Console.WriteLine(item);
}