using System;
using DPWorkout.Structural.Facade.Models;

namespace DPWorkout.Structural.Facade
{
    /// <summary>
    /// Simulator of External library which is responsible to get Information from Cloud
    /// </summary>
    public class CloudInfoSystem
    {
        public AuthResult Athenticate(User user)
        {
            var result = new AuthResult();
            if (user.Name != "Elvin")
            {
                throw new Exception("User not found");
            }

            result.Sid = Guid.NewGuid().ToString();
            return result;
        }
    }
}
