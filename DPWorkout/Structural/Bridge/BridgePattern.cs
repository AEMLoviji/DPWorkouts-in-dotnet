
namespace DPWorkout.Structural.Bridge
{
    public class BridgeClient : IPatternClient
    {
        public void Run()
        {
            //Database can be switched to Oracle one
            IDatabase database = new MsSqlDb();

            var userBusinessLayer = new UserBL(database);
            userBusinessLayer.Insert("AEMLoviji");
            userBusinessLayer.Get("AEMLoviji");
            userBusinessLayer.Update("AEMLoviji", "AEMLoviji2");
            userBusinessLayer.Delete("AEMLoviji2");
        }
    }
}
