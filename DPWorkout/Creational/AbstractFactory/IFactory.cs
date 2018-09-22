using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    /// <summary>
    /// Defines an interface for Factory classes
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Returns Compiler
        /// </summary>
        /// <returns>Returns <see cref="IInterpretedLanguage"/> </returns>
        ICompiledLanguage GetCompiler();

        /// <summary>
        /// Returns Interpreter
        /// </summary>
        /// <returns>Returns <see cref="IInterpretedLanguage"/> </returns>
        IInterpretedLanguage GetInterpreter();
    }
}
