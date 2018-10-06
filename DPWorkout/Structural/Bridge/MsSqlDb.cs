using System;

namespace DPWorkout.Structural.Bridge
{
    public class MsSqlDb : IDatabase
    {
        public void DeleteUser(string userName)
        {
            Console.WriteLine($"#{nameof(MsSqlDb)} - Delete User: {userName}");
        }

        public void GetUser(string userName)
        {
            Console.WriteLine($"#{nameof(MsSqlDb)} - Select User: {userName}");
        }

        public void InsertUser(string userName)
        {
            Console.WriteLine($"#{nameof(MsSqlDb)} - Insert User: {userName}");
        }

        public void UpdateUser(string userName, string newUserName)
        {
            Console.WriteLine($"#{nameof(MsSqlDb)} - Update User: {userName} with {newUserName}");
        }
    }
}
