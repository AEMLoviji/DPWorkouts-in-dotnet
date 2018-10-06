using System;

namespace DPWorkout.Structural.Bridge
{
    public class OracleDb : IDatabase
    {
        public void DeleteUser(string userName)
        {
            Console.WriteLine($"#{nameof(OracleDb)} - Delete User: {userName}");
        }

        public void GetUser(string userName)
        {
            Console.WriteLine($"#{nameof(OracleDb)} - Select User: {userName}");
        }

        public void InsertUser(string userName)
        {
            Console.WriteLine($"#{nameof(OracleDb)} - Insert User: {userName}");
        }

        public void UpdateUser(string userName, string newUserName)
        {
            Console.WriteLine($"#{nameof(OracleDb)} - Update User: {userName} with {newUserName}");
        }
    }
}
