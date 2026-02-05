using ValidateAttributes.Attributes;

namespace ValidateAttributes
{
    public class Person
    {
        private const int MinAge = 12;
        private const int MaxAge = 90;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        [MyRequired]
        public string Name { get; private set; }

        [MyRange(MinAge, MaxAge, false)]
        public int Age { get; private set; }

    }
}
