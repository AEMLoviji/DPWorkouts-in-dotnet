using DPWorkout.Creational.Factory.Countries;

namespace DPWorkout.Creational.Factory
{
    abstract class CountryFactory
    {
        protected abstract ICountry CreateCountry();

        public string GetCapital()
        {
            ICountry country = CreateCountry();
            return country.GetCapital();
        }

        public string GetPopulation()
        {
            ICountry country = CreateCountry();
            return country.GetPopulation();
        }
    }
}
