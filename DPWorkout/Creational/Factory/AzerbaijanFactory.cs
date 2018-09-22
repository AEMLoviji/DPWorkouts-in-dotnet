using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    /// <summary>
    /// Azerbaijan factory implementation
    /// </summary>
    public class AzerbaijanFactory : CountryFactory
    {
        protected override ICountry CreateCountry()
        {
            return new Azerbaijan();
        }
    }
}
