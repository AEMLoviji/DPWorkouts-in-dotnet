using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    class FactoryTeam1Tools : IFactory
    {
        public ICompiledLanguage GetCompiler()
        {
            return new Csharp();
        }

        public IInterpretedLanguage GetInterpreter()
        {
            return new JavaScript();
        }
    }
}
