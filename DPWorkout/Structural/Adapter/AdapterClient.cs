using System;
using System.Threading;
using DPWorkout.Structural.Adapter;

namespace DPWorkout.Creational.Structural
{
    public class AdapterClient : IPatternClient
    {
        public void Run()
        {
            IDateService dateService = new InternalService();
            Console.WriteLine($"Result from internal service: {dateService.GetDateTime()}");
            
            dateService = new ExternalServiceAdapter(new ExternalService());
            Console.WriteLine($"Result from external service: {dateService.GetDateTime()}");
        }
    }
}
