namespace ValidatePerson
{
    class Person
    {
        private const int minAge = 0;
        private const int maxAge = 120;

        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        {
            get => this.firstName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new FormatException("The first name should be a valid name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new FormatException("The last name should be a valid name!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < minAge && value > maxAge)
                {
                    throw new ArgumentOutOfRangeException($"The age should be in range {minAge} - {maxAge}");
                }

                this.age = value;
            }
        }

    }
}
