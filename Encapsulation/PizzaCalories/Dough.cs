namespace PizzaCalories
{
    class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingtechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType 
        {
            get => this.flourType;
            private set
            {
                var valueAsLower = value.ToLower();

                if (valueAsLower != "white" && valueAsLower != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough!");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                var valueAsLower = value.ToLower();

                if (valueAsLower != "crispy" && valueAsLower != "chewy" && valueAsLower != "homemade")
                {
                    throw new ArgumentException("Invalid baking technique!");
                }

                this.bakingTechnique = value;
            }
        }

        public int Weight 
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minWeight}...{maxWeight}]!");
                }

                this.weight = value;
            }
        }

    }
}
