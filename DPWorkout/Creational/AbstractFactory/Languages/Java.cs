namespace DPWorkout.Creational.AbstractFactory.Languages
{
    class Java : ICompiledLanguage
    {
        public string Compile()
        {
            return $"{nameof(Java)} compiler Ran";
        }
    }
}
