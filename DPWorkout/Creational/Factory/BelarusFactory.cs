using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    /// <summary>
    /// Belarus factory implementation
    /// </summary>
    public class BelarusFactory : CountryFactory
    {
        protected override ICountry CreateCountry()
        {
            return new Belarus();
        }
    }
}
