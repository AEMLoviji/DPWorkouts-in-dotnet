namespace DPWorkout.Creational.Builder
{
    public class SkilletSpinachLasagnaBuilder : IMealBuilder
    {
        public Meal Meal { get; }

        public SkilletSpinachLasagnaBuilder()
        {
            Meal = new Meal();
        }
        public void SetName()
        {
            Meal.Name = nameof(SkilletSpinachLasagnaBuilder);
        }

        public void SetForVegetarians()
        {
            Meal.ForVegetarians = false;
        }       

        public void SetPreparationTime()
        {
            Meal.PreparationTime = 15;
        }

        public void SetPrice()
        {
            Meal.Price = 45;
        }
    }
}
