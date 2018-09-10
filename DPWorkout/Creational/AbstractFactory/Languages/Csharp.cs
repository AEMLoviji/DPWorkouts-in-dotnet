namespace DPWorkout.Creational.AbstractFactory.Languages
{
    class Csharp : ICompiledLanguage
    {
        public string Compile()
        {
            return $"{nameof(Csharp)} compiler Ran";
        }       
    }
}
