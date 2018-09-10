namespace DPWorkout.Creational.Factory.Countries
{
    class Belarus : ICountry
    {
        const string Capital = "Minsk";
        const int Population = 9449074;

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
