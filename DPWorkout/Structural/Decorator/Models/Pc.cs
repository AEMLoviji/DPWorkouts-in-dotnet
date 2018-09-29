using System;

namespace DPWorkout.Structural.Decorator.Models
{
    public class Pc : IComputer
    {
        public string Name { get; set; }

        public Pc(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine($"{nameof(Pc)} #{Name} is Starting");
        }

        public void Shutdown()
        {
            Console.WriteLine($"{nameof(Pc)} #{Name} is Shutting down");
        }
    }
}
