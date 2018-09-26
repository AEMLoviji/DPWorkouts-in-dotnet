using System;

namespace DPWorkout.Structural.Adapter
{
    public class ExternalServiceAdapter : IDateService
    {
        private readonly ExternalService _externalService;

        public ExternalServiceAdapter(ExternalService externalService)
        {
            _externalService = externalService;
        }

        public DateTime GetDateTime()
        {
            return new DateTime(_externalService.GetDateTime());
        }

    }
}
