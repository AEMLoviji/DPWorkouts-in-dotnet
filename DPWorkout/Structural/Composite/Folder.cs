using System;
using System.Collections.Generic;

namespace DPWorkout.Structural.Composite
{
    public class Folder : FileStructure
    {
        List<FileStructure> _files = new List<FileStructure>();

        public Folder(string name) : base(name)
        {
        }

        public override void Add(FileStructure file)
        {
            _files.Add(file);
        }

        public override void Display(int depth)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{new String('-', depth)}{_name} /d");
            Console.ResetColor();

            foreach (var file in _files)
            {
                file.Display(depth + 1);
            }
        }

        public override void Remove(FileStructure file)
        {
            _files.Remove(file);
        }
    }
}
