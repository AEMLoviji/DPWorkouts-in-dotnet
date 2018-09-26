using System;

namespace DPWorkout.Creational.AbstractFactory
{
    public class AbstractFactoryClient : IPatternClient
    {
        public void Run()
        {
            Console.WriteLine($"{nameof(AbstractFactoryClient)} ran with {nameof(Team1ToolsFactory)}");
            InvokeMethodsInternal(new Team1ToolsFactory());

            Console.WriteLine("\n *** Switching *** \n");

            Console.WriteLine($"{nameof(AbstractFactoryClient)} ran with {nameof(Team2ToolsFactory)}");
            InvokeMethodsInternal(new Team2ToolsFactory());
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
