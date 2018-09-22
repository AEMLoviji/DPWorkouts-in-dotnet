namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// Csharp implementation of <see cref="ICompiledLanguage"/>
    /// </summary>
    public class Csharp : ICompiledLanguage
    {
        /// <inheritdoc />
        public string Compile()
        {
            return $"{nameof(Csharp)} compiler Ran";
        }
    }
}
