namespace DPWorkout.Behavioral.TemplateMethod
{
    public class TemplateMethodClient : IPatternClient
    {
        public void Run()
        {
            ETLProcessor categories = new MSProcessor();
            categories.Run();

            ETLProcessor products = new AWSProcessor();
            products.Run();
        }
    }
}
