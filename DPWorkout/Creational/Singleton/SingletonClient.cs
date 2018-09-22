namespace DPWorkout.Creational.Singleton
{
    public class SingletonClient : IPatternClient
    {
        private ProcessHandler _processHandler = ProcessHandler.Instance;

        public void Run()
        {
            _processHandler.ShowProcessList();
        }
    }
}
