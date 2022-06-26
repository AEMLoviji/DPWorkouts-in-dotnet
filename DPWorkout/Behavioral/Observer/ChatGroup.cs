namespace DPWorkout.Behavioral.Observer
{
    public abstract class ChatGroup
    {
        private readonly List<IUser> _users = new();
        private readonly List<string> _messagePool = new();

        public string Name { get; init; }

        public ChatGroup(string name)
        {
            Name = name;
        }

        public void Attach(IUser investor)
        {
            _users.Add(investor);
        }

        public void Detach(IUser investor)
        {
            _users.Remove(investor);
        }

        public void Notify()
        {
            foreach (IUser user in _users)
            {
                user.Update(this);
            }
        }

        public void StoreMessage(string msg)
        {
            _messagePool.Add(msg);
            Notify();
        }
    }

    public class ManagersGroup : ChatGroup
    {
        public ManagersGroup(string name) : base(name) { }
    }
}
