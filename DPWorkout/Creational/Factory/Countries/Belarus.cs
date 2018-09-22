namespace DPWorkout.Creational.Factory.Countries
{
    /// <summary>
    /// Belarus country implementation
    /// </summary>
    public class Belarus : ICountry
    {
        private const string Capital = "Minsk";
        private const int Population = 9449074;

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
