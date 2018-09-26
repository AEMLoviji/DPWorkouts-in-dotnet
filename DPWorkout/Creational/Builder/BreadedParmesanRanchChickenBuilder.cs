namespace DPWorkout.Creational.Builder
{
    public class BreadedParmesanRanchChickenBuilder : IMealBuilder
    {
        public Meal Meal { get; }

        public BreadedParmesanRanchChickenBuilder()
        {
            Meal = new Meal();
        }

        public void SetName()
        {
            Meal.Name = nameof(BreadedParmesanRanchChickenBuilder);
        }

        public void SetForVegetarians()
        {
            Meal.ForVegetarians = true;
        }

        public void SetPreparationTime()
        {
            Meal.PreparationTime = 25;
        }

        public void SetPrice()
        {
            Meal.Price = 85;
        }
    }
}
