namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;

        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;

            this.toppings = new List<Topping>();
        }

        public string Name 
        {
            get => this.name;
            set
            {
                if (value.Length < Constants.PizzaNameMinLength || value.Length > Constants.PizzaNameMaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between {Constants.PizzaNameMinLength} and {Constants.PizzaNameMaxLength} symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough { get; set;  }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == Constants.PizzaMaxPermittedToppings)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [{Constants.PizzaMinPermittedToppings}...{Constants.PizzaMaxPermittedToppings}]");
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            return this.dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
        }
    }
}
