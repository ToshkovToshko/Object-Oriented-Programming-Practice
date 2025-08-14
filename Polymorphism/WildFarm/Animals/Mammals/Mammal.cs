
namespace WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, HashSet<string> allowedFoods, double weightModifier, string livingRegion) 
            : base(name, weight, allowedFoods, weightModifier)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
    }
}
