using DPWorkout.Creational.AbstractFactory.Languages;

namespace DPWorkout.Creational.AbstractFactory
{
    interface IFactory
    {
        ICompiledLanguage GetCompiler();
        IInterpretedLanguage GetInterpreter();
    }
}
