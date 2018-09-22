namespace DPWorkout.Creational.Factory.Countries
{
    /// <summary>
    /// Defines an interface for country 
    /// </summary>
    public interface ICountry
    {
        /// <summary>
        /// Gets information about country capital 
        /// </summary>
        /// <returns>Information as string</returns>
        string GetCapital();

        /// <summary>
        /// Gets information about country population 
        /// </summary>
        /// <returns>Information as string</returns>
        string GetPopulation();
    }
}
