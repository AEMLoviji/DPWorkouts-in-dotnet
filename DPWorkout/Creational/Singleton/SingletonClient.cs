namespace DPWorkout.Creational.Singleton
{
    public class SingletonClient : IPatternClient
    {
        public void Run()
        {
            Clock.Instance.ShowTime();
        }
    }
}
