using DPWorkout.Structural.Facade.Models;

namespace DPWorkout.Structural.Facade
{
    /// <summary>
    /// Site to interact with
    /// </summary>
    public class AuthUserDecoder
    {
        public string Decode(AuthResult input)
        {
            if (!string.IsNullOrEmpty(input.Sid))
            {
                return "https://www.bing.com";
            }

            return string.Empty;
        }
    }
}
