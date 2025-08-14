namespace WildFarm.Foods
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            FoodQuantity = quantity;
        }

        public int FoodQuantity { get; set; }
    }
}
