using System;

namespace DPWorkout.Creational.Prototype
{
    /// <summary>
    /// Class which represents computer object
    /// </summary>
    /// <remarks>
    /// <para>
    /// Class must implement <see cref="ComputerPrototype"/> if we need implement prototype pattern in classic way
    /// </para>
    /// </remarks>
    public class Computer : ICloneable
    {
        public string Manufacturer { get; set; }

        public int Ram { get; set; }

        public int Hdd { get; set; }

        public bool HasCamera { get; set; }

        public object Clone()
        {
            //it is swallow copy. You need implement deep copy if you need reference types to be copied as well
            return MemberwiseClone() as Computer;
        }

        //Below Clone method can be used if we are going implement prototype in classic way
        //public override ComputerPrototype Clone()
        //{
        //    return MemberwiseClone() as ComputerPrototype;
        //}

        public override string ToString()
        {
            return $"{nameof(Manufacturer)}: {Manufacturer}, {nameof(Ram)}: {Ram}, {nameof(Hdd)}: {Hdd}, {nameof(HasCamera)}: {HasCamera}";
        }
    }
}
