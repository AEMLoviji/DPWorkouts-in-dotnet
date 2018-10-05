using DPWorkout.Structural.Flyweight;
using System.Collections.Generic;

namespace DPWorkout.Structural.Proxy
{
    public class FlyweightClient : IPatternClient
    {
        public void Run()
        {
            var categoryFactory = new CategoryFactory();
            var categoryUtilities = categoryFactory.GetCategory(1);
            var categoryMobile = categoryFactory.GetCategory(2);
            var serviceList = new List<Service>
            {
                new Service()
                {
                    ServiceName = "Azerishiq",
                    Category = categoryUtilities
                },
                new Service()
                {
                    ServiceName = "Bakcel",
                    Category = categoryMobile
                },
                new Service()
                {
                    ServiceName = "Azercel",
                    Category = categoryMobile
                }
            };

            foreach (var service in serviceList)
            {
                service.PromptInfo();
            }
        }
    }
}
