namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// JavaScript implementation of <see cref="IInterpretedLanguage"/>
    /// </summary>
    public class JavaScript : IInterpretedLanguage
    {
        /// <inheritdoc />
        public string Execute()
        {
            return $"{nameof(JavaScript)} interpreter Executed";
        }
    }
}
