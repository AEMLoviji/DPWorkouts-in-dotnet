using System;
using DPWorkout.Creational.Factory;

namespace DPWorkout
{
    class Program
    {
        static void Main(string[] args)
        {
            new FactoryClient().GetInformationAboutCountry();

            Console.ReadLine();
        }
    }
}
