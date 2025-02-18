

namespace PizzaCalories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingtechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingtechnique;
            this.Weight = weight;
        }

        public string FlourType 
        {
            get => this.flourType;
            private set
            {
                Validator.ThrowIfValueIsNotAllowed(new HashSet<string> { "white", "wholegrain"}, value.ToLower(), "Invalid type of dough!");

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                Validator.ThrowIfValueIsNotAllowed(new HashSet<string> {"crispy", "chewy", "homemade"}, value.ToLower(), "Invalid baking technique!");

                this.bakingTechnique = value;
            }
        }

        public int Weight 
        {
            get => this.weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(Constants.DoughMinWeight, Constants.DoughMaxWeight, value, $"Dough weight should be in the range [{Constants.DoughMinWeight}...{Constants.DoughMaxWeight}]!");

                this.weight = value;
            }
        }
        
        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return this.Weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetBakingTechniqueModifier()
        {
            var bakingTechniqueLower = this.BakingTechnique.ToLower();

            if (bakingTechniqueLower == "crispy")
            {
                return 0.9;
            }
            
            if (bakingTechniqueLower == "chewy")
            {
                return 1.1;
            }

            return 1.0;
        }

        private double GetFlourTypeModifier()
        {
            var flourTypeLower = this.FlourType.ToLower();

            if (flourTypeLower == "white")
            {
                return 1.5;
            }

            return 1;
        }
    }
}
