using System;

namespace DPWorkout.Creational.AbstractFactory
{
    class AbstractFactoryClient : IPatternClient
    {
        public void Run()
        {
            Console.WriteLine($"{nameof(AbstractFactoryClient)} ran with {nameof(FactoryTeam1Tools)}");
            InvokeMethodsInternal(new FactoryTeam1Tools());

            Console.WriteLine("\n *** Switching *** \n");

            Console.WriteLine($"{nameof(AbstractFactoryClient)} ran with {nameof(FactoryTeam2Tools)}");
            InvokeMethodsInternal(new FactoryTeam2Tools());

        }

        private void InvokeMethodsInternal(IFactory factory)
        {
            var compiler = factory.GetCompiler();
            Console.WriteLine(compiler.Compile());

            var interpreter = factory.GetInterpreter();
            Console.WriteLine(interpreter.Execute());
        }
    }
}
