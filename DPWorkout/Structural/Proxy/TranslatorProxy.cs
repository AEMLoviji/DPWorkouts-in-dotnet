using System;

namespace DPWorkout.Structural.TranslatorApi.Proxy
{
    /// <summary>
    ///     Translater module of the application
    /// </summary>
    /// <remarks>
    ///  <para>
    ///     Lets say, GoogleTransle translator API not logs our request 
    ///  </para> 
    ///  <para>
    ///     or somethink else what we need to do before translating given input
    ///  </para> 
    ///  <para>
    ///     So Creating this class allows to as add additional func. to base translation flow
    ///  </para> 
    /// </remarks>
    public class TranslatorProxy : ITranslator
    {
        private ITranslator _translator = new GoogleTranslate();

        public string Translate(string input)
        {
            Console.WriteLine("Simple Console Logger | User provided phrase '{0}' to translate", input);
            var result = _translator.Translate(input);
            Console.WriteLine("Simple Console Logger | Translation result: '{0}'", result);

            return result;
        }
    }
}
