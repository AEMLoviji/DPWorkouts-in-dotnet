using System;

namespace DPWorkout.Creational.Singleton
{
    /// <summary>
    /// Clock class to work with system clock
    /// </summary>
    public class Clock
    {
        private static Clock instance;

        private static object obj = new object();

        private Clock() { }

        /// <summary>
        /// Gets the single instance of <see cref="Clock"/>
        /// </summary>
        public static Clock Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Clock();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Shows current clock
        /// </summary>
        public void ShowTime()
        {
            Console.WriteLine("Is is | {0} | o'clock", DateTime.Now.ToShortTimeString());
        }
    }
}
