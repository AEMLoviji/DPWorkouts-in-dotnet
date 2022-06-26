namespace DPWorkout.Behavioral
{
    public class ObserverClient : IPatternClient
    {
        public void Run()
        {
            // Create manager group and attach users
            ManagersGroup managerGroup = new ManagersGroup("ManagersGroup");
            managerGroup.Attach(new User("Elvin"));
            managerGroup.Attach(new User("Telman"));

            // Fluctuating prices will notify investors
            managerGroup.StoreMessage("initial message");
            managerGroup.StoreMessage("Hello mates");
            managerGroup.StoreMessage("Bye");
        }
    }
}
