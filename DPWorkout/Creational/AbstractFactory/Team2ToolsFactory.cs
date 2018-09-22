using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    /// <summary>
    ///  Factory implementation for Team 2 tools
    /// </summary>
    public class Team2ToolsFactory : IFactory
    {
        /// <inheritdoc />
        public ICompiledLanguage GetCompiler()
        {
            return new Java();
        }

        /// <inheritdoc />
        public IInterpretedLanguage GetInterpreter()
        {
            return new Ruby();
        }
    }
}
