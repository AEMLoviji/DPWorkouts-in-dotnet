namespace DPWorkout.Creational.Builder
{
    public interface IMealBuilder
    {
        void SetName();

        void SetForVegetarians();

        void SetPrice();

        void SetPreparationTime();

        Meal Meal { get; }
    }
}
