namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// Defines an interface for interpreters 
    /// </summary>
    public interface IInterpretedLanguage
    {
        /// <summary>
        /// Executes code
        /// </summary>
        /// <returns>Result of executing</returns>
        string Execute();
    }
}
