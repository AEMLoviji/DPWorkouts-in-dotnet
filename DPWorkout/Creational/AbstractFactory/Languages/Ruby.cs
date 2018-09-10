namespace DPWorkout.Creational.AbstractFactory.Languages
{
    class Ruby : IInterpretedLanguage
    {
        public string Execute()
        {
            return $"{nameof(Ruby)} interpreter Executed";
        }
    }
}