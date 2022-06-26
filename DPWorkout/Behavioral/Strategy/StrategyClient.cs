namespace DPWorkout.Behavioral.Strategy
{
    public class StrategyClient : IPatternClient
    {
        public void Run()
        {
            SearchEngine searchEngine = new SearchEngine();
            searchEngine.Boost("parameter_x", "1.0");
            searchEngine.Boost("parameter_y", "1.1");

            searchEngine.SetSearchStrategy(new Algorithm1());
            Console.WriteLine(searchEngine.Search("test"));

            searchEngine.SetSearchStrategy(new Algorithm2());
            Console.WriteLine(searchEngine.Search("test"));
        }
    }
}
