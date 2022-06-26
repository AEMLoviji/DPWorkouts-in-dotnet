namespace DPWorkout.Behavioral.TemplateMethod
{
    public class AWSProcessor : ETLProcessor
    {
        public override void Extract()
        {
            Console.WriteLine($"{nameof(AWSProcessor)} {nameof(MSProcessor.Extract)}");
        }

        public override void Load()
        {
            Console.WriteLine($"{nameof(AWSProcessor)} {nameof(MSProcessor.Load)}");
        }

        public override void Transform()
        {
            Console.WriteLine($"{nameof(AWSProcessor)} {nameof(MSProcessor.Transform)}");
        }
    }
}
