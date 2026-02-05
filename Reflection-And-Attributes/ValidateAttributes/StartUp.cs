using ValidateAttributes;

var person = new Person("Toshko", 12);

bool isValidEntity = Validator.IsValid(person);

Console.WriteLine(isValidEntity);
