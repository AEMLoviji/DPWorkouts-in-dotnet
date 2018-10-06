using System;
using DPWorkout.Creational.Factory;
using DPWorkout.Creational.AbstractFactory;
using DPWorkout.Creational.Singleton;
using DPWorkout.Creational.Prototype;
using DPWorkout.Creational.Builder;
using DPWorkout.Creational.Structural;
using DPWorkout.Structural.Facade;
using DPWorkout.Structural.Proxy;
using DPWorkout.Structural.Composite;
using DPWorkout.Structural.Bridge;

namespace DPWorkout
{
    public class Program
    {
        private static IPatternClient patternClient;

        static void Main(string[] args)
        {
            #region Creational Pattern Clients
            //patternClient = new AbstractFactoryClient();
            //patternClient = new FactoryClient();
            //patternClient = new SingletonClient();
            //patternClient = new PrototypeClient();
            //patternClient = new BuilderClient();
            #endregion

            #region Structural Pattern Clients
            //patternClient = new AdapterClient();
            //patternClient = new FacadeClient();
            //patternClient = new ProxyClient();
            //patternClient = new DecoratorClient();
            //patternClient = new CompositeClient();
            //patternClient = new FlyweightClient();
            patternClient = new BridgeClient();
            patternClient.Run();
            #endregion

            Console.ReadLine();
        }
    }
}
