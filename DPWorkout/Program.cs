using System;
using DPWorkout.Creational.Factory;
using DPWorkout.Creational.AbstractFactory;
using DPWorkout.Creational.Singleton;
using DPWorkout.Creational.Prototype;
using DPWorkout.Creational.Builder;

namespace DPWorkout
{
    public class Program
    {
        private static IPatternClient patternClient;

        static void Main(string[] args)
        {
            //patternClient = new AbstractFactoryClient();
            //patternClient = new FactoryClient();
            //patternClient = new SingletonClient();
            //patternClient = new PrototypeClient();
            patternClient = new BuilderClient();
            patternClient.Run();

            Console.ReadLine();
        }
    }
}
