namespace DPWorkout.Behavioral.TemplateMethod
{
    internal class MSProcessor : ETLProcessor
    {
        public override void Extract()
        {
            Console.WriteLine($"{nameof(MSProcessor)} {nameof(MSProcessor.Extract)}");
        }

        public override void Load()
        {
            Console.WriteLine($"{nameof(MSProcessor)} {nameof(MSProcessor.Load)}");
        }

        public override void Transform()
        {
            Console.WriteLine($"{nameof(MSProcessor)} {nameof(MSProcessor.Transform)}");
        }
    }
}
