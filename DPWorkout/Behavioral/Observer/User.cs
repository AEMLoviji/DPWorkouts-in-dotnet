using DPWorkout.Behavioral.Observer;

namespace DPWorkout.Behavioral
{
    public interface IUser
    {
        public void Update(ChatGroup group);
    }

    public class User : IUser
    {
        public string Name { get; init; }

        public User(string name) { Name = name; }

        public void Update(ChatGroup group)
        {
            Console.WriteLine("User {0} Notified from group {1}", Name, group.Name);
        }
    }
}
