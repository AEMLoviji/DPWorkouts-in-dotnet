using System;
using DPWorkout.Creational.AbstractFactory;
using DPWorkout.Creational.Factory;
using DPWorkout.Creational.Singleton;

namespace DPWorkout
{
    public class Program
    {
        private static IPatternClient patternClient;

        static void Main(string[] args)
        {

            //patternClient = new AbstractFactoryClient();
            //patternClient = new FactoryClient();
            patternClient = new SingletonClient();
            patternClient.Run();

            Console.ReadLine();
        }
    }
}
