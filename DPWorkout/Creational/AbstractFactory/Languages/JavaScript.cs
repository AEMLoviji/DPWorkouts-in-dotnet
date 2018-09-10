namespace DPWorkout.Creational.AbstractFactory.Languages
{
    class JavaScript : IInterpretedLanguage
    {
        public string Execute()
        {
            return $"{nameof(JavaScript)} interpreter Executed";
        }
    }
}
