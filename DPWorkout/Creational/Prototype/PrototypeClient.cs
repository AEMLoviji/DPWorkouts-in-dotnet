using System;

namespace DPWorkout.Creational.Prototype
{
    public class PrototypeClient : IPatternClient
    {
        public void Run()
        {
            var computer1 = new Computer()
            {
                Manufacturer = "Asus",
                Ram = 8,
                Hdd = 256,
                HasCamera = true
            };
            Console.WriteLine($"{nameof(computer1)}: {computer1}");

            var computer2 = computer1.Clone();
            Console.WriteLine($"{nameof(computer1)} cloned to {nameof(computer2)}");
            Console.WriteLine($"{nameof(computer2)}: {computer2}");
        }
    }
}
