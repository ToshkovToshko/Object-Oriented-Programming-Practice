
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    class Hen : Bird
    {
        private const double henWeightModifier = 0.35;
        private static HashSet<string> henAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, henAllowedFoods, henWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return $"Cluck";
        }
    }
}
