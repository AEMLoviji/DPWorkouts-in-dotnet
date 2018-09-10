using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    class BelarusFactory : CountryFactory
    {
        protected override ICountry CreateCountry()
        {
            return new Belarus();
        }
    }
}
