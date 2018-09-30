namespace DPWorkout.Structural.Composite
{
    public abstract class FileStructure
    {
        protected string _name;

        public FileStructure(string name)
        {
            _name = name;
        }

        public abstract void Add(FileStructure c);

        public abstract void Remove(FileStructure c);

        public abstract void Display(int depth);
    }
}
