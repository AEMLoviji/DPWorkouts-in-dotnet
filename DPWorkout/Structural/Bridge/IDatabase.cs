
namespace DPWorkout.Structural.Bridge
{
    /// <summary>
    /// Implementor used in Bridge pattern
    /// </summary>
    public interface IDatabase
    {
        void InsertUser(string userName);

        void UpdateUser(string userName, string newUserName);

        void DeleteUser(string userName);

        void GetUser(string userName);
    }
}
