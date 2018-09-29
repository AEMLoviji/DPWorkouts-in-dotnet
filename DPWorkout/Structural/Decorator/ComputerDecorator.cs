using DPWorkout.Structural.Decorator.Models;

namespace DPWorkout.Structural.Decorator
{
    public abstract class ComputerDecorator : IComputer
    {
        protected IComputer _computer;

        public ComputerDecorator(IComputer computer)
        {
            _computer = computer;
        }

        public void Start()
        {
            _computer.Start();
        }

        public void Shutdown()
        {
            _computer.Shutdown();
        }
    }
}
