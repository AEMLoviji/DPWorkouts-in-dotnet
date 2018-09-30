using System;

namespace DPWorkout.Structural.Composite
{
    public class File : FileStructure
    {
        public File(string name) : base(name) { }

        public override void Add(FileStructure c)
        {
            throw new Exception("Can not add to Basic Element");
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('-', depth)}{_name} /f");
        }

        public override void Remove(FileStructure c)
        {
            throw new Exception("Can not remove from Basic Element");
        }
    }
}
