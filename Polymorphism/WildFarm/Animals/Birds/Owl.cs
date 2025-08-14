using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    class Owl : Bird
    {
        private const double owlWeightModifier = 0.25;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, allowedFoods, owlWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }
    }
}
