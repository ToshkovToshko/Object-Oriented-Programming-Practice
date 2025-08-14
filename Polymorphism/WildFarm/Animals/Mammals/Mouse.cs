using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    class Mouse : Mammal
    {
        private const double mouseWeightModifier = 0.10;
        private static HashSet<string> mouseAllowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, mouseAllowedFoods, mouseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return $"Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
