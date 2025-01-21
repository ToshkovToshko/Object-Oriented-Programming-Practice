namespace PersonsInfo
{
    public class Person
    {
        public Person(string fistName, string lastName, int Age)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.Age = Age;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }

    }
}
