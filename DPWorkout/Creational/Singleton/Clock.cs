using System;

namespace DPWorkout.Creational.Singleton
{
    public class Clock
    {
        private static Clock instance;

        private static object obj = new object();

        private Clock() { }

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

        public void ShowTime()
        {
            Console.WriteLine("Is is | {0} | o'clock", DateTime.Now.ToShortTimeString());
        }
    }
}
