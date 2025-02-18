namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ThrowIfStringIsNullOrEmpty(value, "Name cannot be empty!");

                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            set
            {
                Validator.ThrowIfMoneyIsNegative(value, "Cost cannot be negative number!");

                this.cost = value;
            }
        }

    }
}
