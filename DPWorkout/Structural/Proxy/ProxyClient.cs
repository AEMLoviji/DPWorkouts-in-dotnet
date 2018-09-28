using DPWorkout.Structural.TranslatorApi.Proxy;

namespace DPWorkout.Structural.Proxy
{
    public class ProxyClient : IPatternClient
    {
        public void Run()
        {
            ITranslator translatorProxy = new TranslatorProxy();
            translatorProxy.Translate("1010");
        }
    }
}
