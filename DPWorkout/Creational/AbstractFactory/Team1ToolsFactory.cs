using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    /// <summary>
    ///  Factory implementation for team 1 tools
    /// </summary>
    public class Team1ToolsFactory : IFactory
    {
        /// <inheritdoc />
        public ICompiledLanguage GetCompiler()
        {
            return new Csharp();
        }

        /// <inheritdoc />
        public IInterpretedLanguage GetInterpreter()
        {
            return new JavaScript();
        }
    }
}
