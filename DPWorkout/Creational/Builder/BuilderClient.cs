using System;

namespace DPWorkout.Creational.Builder
{
    public class BuilderClient : IPatternClient
    {
        public void Run()
        {
            Meal meal;
            Cooker cooker;
            IMealBuilder mealBuilder;

            mealBuilder = new BreadedParmesanRanchChickenBuilder();
            cooker = new Cooker(mealBuilder);
            cooker.Cook();
            meal = mealBuilder.Meal;
            Console.WriteLine($"First meal info: {meal.ToString()}");

            mealBuilder = new SkilletSpinachLasagnaBuilder();
            cooker = new Cooker(mealBuilder);
            cooker.Cook();
            meal = mealBuilder.Meal;
            Console.WriteLine($"Second meal info: {meal.ToString()}");
        }
    }
}
