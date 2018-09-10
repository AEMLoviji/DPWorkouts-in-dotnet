using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    class AzerbaijanFactory : CountryFactory
    {
        protected override ICountry CreateCountry()
        {
            return new Azerbaijan();
        }
    }
}
