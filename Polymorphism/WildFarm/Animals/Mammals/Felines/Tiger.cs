using WildFarm.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    class Tiger : Feline
    {
        private const double tigerWeightModifier = 1.00;
        private static HashSet<string> tigerAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, tigerAllowedFoods, tigerWeightModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return $"ROAR!!!";
        }
    }
}
