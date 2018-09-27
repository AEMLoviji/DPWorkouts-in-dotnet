namespace DPWorkout.Structural.Facade
{
    public class FacadeClient : IPatternClient
    {
        public void Run()
        {
            UserBrowserFacade userBrowser = new UserBrowserFacade(new CloudInfoSystem(), new AuthUserDecoder());

            userBrowser.Navigate("Elvins");
        }
    }
}
