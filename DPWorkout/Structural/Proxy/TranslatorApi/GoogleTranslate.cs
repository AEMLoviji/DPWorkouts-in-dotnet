using System;

namespace DPWorkout.Structural.TranslatorApi.Proxy
{
    /// <summary>
    /// Google translater API
    /// </summary>
    public class GoogleTranslate : ITranslator
    {
        public string Translate(string input)
        {
            var inputAsCharArray = input.ToCharArray();
            Array.Reverse(inputAsCharArray);

            return string.Join(string.Empty, inputAsCharArray);
        }
    }
}
