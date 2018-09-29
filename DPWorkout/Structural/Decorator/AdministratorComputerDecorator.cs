using System;
using DPWorkout.Structural.Decorator.Models;

namespace DPWorkout.Structural.Decorator
{
    public class AdministratorComputerDecorator : ComputerDecorator
    {
        public AdministratorComputerDecorator(IComputer computer) : base(computer) { }

        public new void Start()
        {
            base.Start();
            Console.WriteLine("Administrator log: Computer is Started");
        }

        public new void Shutdown()
        {

            Console.WriteLine("Administrator log: Computer is Shutting down");
            base.Shutdown();
        }
    }
}
