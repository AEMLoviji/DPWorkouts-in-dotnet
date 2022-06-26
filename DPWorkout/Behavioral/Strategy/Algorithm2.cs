namespace DPWorkout.Behavioral.Strategy
{
    public class Algorithm2 : SearchStrategy
    {
        public override string Search(string query)
        {
            return $"{nameof(Algorithm2)} search result for {query}";
        }
    }
}
