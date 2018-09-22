using System;
using System.Collections.Generic;

namespace DPWorkout.Creational.Singleton
{
    /// <summary>
    /// Singleton class for procesing handling
    /// </summary>
    public class ProcessHandler
    {
        private static ProcessHandler _instance;

        // Lock synchronization object
        private static object obj = new object();

        private readonly List<string> _processHandlers;

        // Constructor should be defined as private|protected
        private ProcessHandler()
        {
            _processHandlers = new List<string>()
            {
                "Handler 1",
                "Handler 2",
                "Handler 3",
            };
        }

        /// <summary>
        /// Gets the single instance of <see cref="ProcessHandler"/>
        /// </summary>
        public static ProcessHandler Instance
        {
            get
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new ProcessHandler();
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// Shows all process
        /// </summary>
        public void ShowProcessList()
        {
            _processHandlers.ForEach(p => Console.WriteLine(p));
        }
    }
}