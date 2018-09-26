using System;

namespace DPWorkout.Structural.Adapter
{
    /// <summary>
    /// Defines an interface for getting date and time from different sources
    /// </summary>
    public interface IDateService
    {
        /// <summary>
        /// Gets date and time
        /// </summary>
        /// <returns>Returns current date time in <see cref="DateTime"/> format</returns>
        DateTime GetDateTime();
    }
}
