namespace DPWorkout.Behavioral.Strategy
{
    public class SearchEngine
    {
        private SearchStrategy _searchStrategy;
        private readonly Dictionary<string, string> _boostParameters = new();

        public void SetSearchStrategy(SearchStrategy searchStrategy)
        {
            _searchStrategy = searchStrategy;

        }

        public void Boost(string parameterName, string parameterValue)
        {
            _ = _boostParameters.TryAdd(parameterName, parameterValue);
        }

        public string Search(string query)
        {
            return _searchStrategy.Search(query);
        }
    }
}
