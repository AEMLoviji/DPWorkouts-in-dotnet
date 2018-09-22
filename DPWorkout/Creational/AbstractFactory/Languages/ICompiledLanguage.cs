namespace DPWorkout.Creational.AbstractFactory.Languages
{
    /// <summary>
    /// Defines an interface for compilers 
    /// </summary>
    public interface ICompiledLanguage
    {
        /// <summary>
        /// Compiles code
        /// </summary>
        /// <returns>Result of compiling</returns>
        string Compile();
    }
}
