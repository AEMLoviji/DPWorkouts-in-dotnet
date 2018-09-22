namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// Java implementation of <see cref="ICompiledLanguage"/>
    /// </summary>
    public class Java : ICompiledLanguage
    {
        /// <inheritdoc />
        public string Compile()
        {
            return $"{nameof(Java)} compiler Ran";
        }
    }
}
