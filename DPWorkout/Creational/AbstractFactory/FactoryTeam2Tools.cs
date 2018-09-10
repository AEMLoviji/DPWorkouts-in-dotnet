using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    class FactoryTeam2Tools : IFactory
    {
        public ICompiledLanguage GetCompiler()
        {
            return new Java();
        }

        public IInterpretedLanguage GetInterpreter()
        {
            return new Ruby();
        }
    }
}
