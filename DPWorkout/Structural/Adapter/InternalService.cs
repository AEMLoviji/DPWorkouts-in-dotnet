using System;

namespace DPWorkout.Structural.Adapter
{
    /// <summary>
    /// Internal Service which gets system date and time
    /// </summary>
    public class InternalService : IDateService
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
