namespace PizzaCalories
{
    class Pizza
    {
        private const int nameMinLength = 1;
        private const int nameMaxLength = 15;

        private string name;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
        }

        public string Name 
        {
            get => this.name;
            set
            {
                if (value.Length < nameMinLength || value.Length > nameMaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between {nameMinLength} and {nameMaxLength} symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough { get; set;  }

    }
}
