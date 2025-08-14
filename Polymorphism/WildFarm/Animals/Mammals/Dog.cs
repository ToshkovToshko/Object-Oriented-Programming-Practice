using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    class Dog : Mammal
    {
        private const double dogWeightModifier = 0.40;
        private static HashSet<string> dogAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, dogAllowedFoods, dogWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return $"Woof!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
