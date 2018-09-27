using System;

namespace DPWorkout.Structural.Facade
{
    /// <summary>
    /// Facade class
    /// </summary>
    public class UserBrowserFacade
    {
        private CloudInfoSystem _cloudInfoSystem;
        private AuthUserDecoder _authUserDecoder;

        public UserBrowserFacade(CloudInfoSystem cloudInfoSystem, AuthUserDecoder authUserDecoder)
        {
            _cloudInfoSystem = cloudInfoSystem;
            _authUserDecoder = authUserDecoder;
        }

        public void Navigate(string login)
        {
            try
            {
                var cloudInfo = _cloudInfoSystem.Athenticate(new Models.User()
                {
                    Name = login
                });

                var decodedData = _authUserDecoder.Decode(cloudInfo);

                Console.WriteLine($"User navigating to: {decodedData}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
