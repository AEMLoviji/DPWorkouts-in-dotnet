using System;

namespace DPWorkout.Structural.Flyweight
{
    public class Service
    {
        public string ServiceName { get; set; }

        public Category Category { get; set; }

        public void PromptInfo() {
            Console.WriteLine($"ServiceName: {ServiceName}, Category: {Category.Name}");
        }
    }
}
