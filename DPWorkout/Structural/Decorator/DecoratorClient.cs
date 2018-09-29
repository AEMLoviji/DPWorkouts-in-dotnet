using System;
using DPWorkout.Structural.Decorator;
using DPWorkout.Structural.Decorator.Models;

namespace DPWorkout.Structural.Proxy
{
    public class DecoratorClient : IPatternClient
    {
        public void Run()
        {
            Console.WriteLine($"\t{nameof(DecoratorClient)} calls standard object");
            IComputer computer = new Pc(Environment.MachineName);
            computer.Start();
            computer.Shutdown();

            Console.Write(Environment.NewLine);
            Console.WriteLine("\t\tSwitching");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"\t{nameof(DecoratorClient)} calls decorator object");

            AdministratorComputerDecorator decorator = new AdministratorComputerDecorator(computer);
            decorator.Start();
            decorator.Shutdown();
        }
    }
}
