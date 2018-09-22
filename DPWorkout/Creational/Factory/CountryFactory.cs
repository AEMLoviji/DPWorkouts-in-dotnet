using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    /// <summary>
    /// Abstract country factory
    /// </summary>
    public abstract class CountryFactory
    {
        protected abstract ICountry CreateCountry();

        /// <summary>
        /// Gets information about country capital 
        /// </summary>
        /// <returns>Information as string</returns>
        public string GetCapital()
        {
            ICountry country = CreateCountry();
            return country.GetCapital();
        }

        /// <summary>
        /// Gets information about country population 
        /// </summary>
        /// <returns>Information as string</returns>
        public string GetPopulation()
        {
            ICountry country = CreateCountry();
            return country.GetPopulation();
        }
    }
}
