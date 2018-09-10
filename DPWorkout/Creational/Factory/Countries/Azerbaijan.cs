namespace DPWorkout.Creational.Factory.Countries
{
    class Azerbaijan : ICountry
    {
        const string Capital = "Baku";
        const int Population = 9942898;

        public string GetCapital()
        {
            return $"Capital is: {Capital}";
        }

        public string GetPopulation()
        {
            return $"Population is {Population:N0}";
        }
    }
}
