using System;
using System.IO;

namespace DPWorkout.Structural.Composite
{
    public class CompositeClient : IPatternClient
    {
        public void Run()
        {
            var rootDirectoryInfo = new DirectoryInfo(@"C:\");
            var dirs = rootDirectoryInfo.GetDirectories();

            Folder rootFolder = new Folder("C");
            foreach (var dir in dirs)
            {
                var folder = new Folder(dir.Name);

                try
                {
                    foreach (var files in dir.GetFiles())
                    {
                        folder.Add(new File(files.Name));
                    }
                }
                catch
                {
                    //Trying to reference to some files will throw UnauthorizedAccessException
                    //to prevent this behaviour run VS as administrator
                }

                rootFolder.Add(folder);
            }

            rootFolder.Display(1);
        }
    }
}
