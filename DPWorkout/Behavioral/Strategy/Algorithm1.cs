namespace DPWorkout.Behavioral.Strategy
{
    public class Algorithm1 : SearchStrategy
    {
        public override string Search(string query)
        {
            return $"{nameof(Algorithm1)} search result for {query}";
        }
    }
}
