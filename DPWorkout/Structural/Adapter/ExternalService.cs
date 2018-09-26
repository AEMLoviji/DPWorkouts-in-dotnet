using System;

namespace DPWorkout.Structural.Adapter
{
    /// <summary>
    /// External service which return date time in number of ticks
    /// </summary>
    /// <remarks>
    /// <para>
    /// Imagine this class is received from 3-rd partly library and it is not changable
    /// </para>
    /// <para>
    /// So we need to create Adapter class 
    /// which makes the <see cref="ExternalService"/>
    /// compatible with the <see cref="IDateService"/> interface
    /// </para>
    /// </remarks>
    public class ExternalService
    {
        public long GetDateTime()
        {
            return DateTime.Now.Ticks;
        }
    }
}
