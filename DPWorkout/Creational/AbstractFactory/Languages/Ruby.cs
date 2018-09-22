namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// Ruby implementation of <see cref="IInterpretedLanguage"/>
    /// </summary>
    public class Ruby : IInterpretedLanguage
    {
        /// <inheritdoc />
        public string Execute()
        {
            return $"{nameof(Ruby)} interpreter Executed";
        }
    }
}