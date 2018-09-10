using System;
using DPWorkout.Creational.AbstractFactory;
using DPWorkout.Creational.Factory;

namespace DPWorkout
{
    class Program
    {
        static void Main(string[] args)
        {
            //new FactoryClient().GetInformationAboutCountry();
            new AbstractFactoryClient().RunSimpleOperation();

            Console.ReadLine();
        }
    }
}
