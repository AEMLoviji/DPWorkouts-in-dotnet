namespace DPWorkout.Creational.Builder
{
    public class Cooker
    {
        private static IMealBuilder _mealBuilder;

        public Cooker(IMealBuilder builder)
        {
            _mealBuilder = builder;
        }

        public void Cook()
        {
            _mealBuilder.SetName();
            _mealBuilder.SetForVegetarians();
            _mealBuilder.SetPreparationTime();
            _mealBuilder.SetPrice();
        }
    }
}
