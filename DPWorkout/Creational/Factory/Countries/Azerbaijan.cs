namespace DPWorkout.Creational.Factory.Countries
{

    /// <summary>
    /// Azerbaijan country implementation
    /// </summary>
    public class Azerbaijan : ICountry
    {
        private const string Capital = "Baku";
        private const int Population = 9942898;

        /// <inheritdoc />
        public string GetCapital()
        {
            return $"Capital is: {Capital}";
        }

        /// <inheritdoc />
        public string GetPopulation()
        {
            return $"Population is {Population:N0}";
        }
    }
}
