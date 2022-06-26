namespace DPWorkout.Behavioral.TemplateMethod
{
    public abstract class ETLProcessor
    {
        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();

        public void Run()
        {
            Extract();
            Transform();
            Load();
        }
    }
}
